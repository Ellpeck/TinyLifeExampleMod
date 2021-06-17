using System.Collections.Generic;
using System.Linq;
using ExtremelySimpleLogger;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MLEM.Data;
using MLEM.Data.Content;
using MLEM.Textures;
using TinyLife;
using TinyLife.Actions;
using TinyLife.Emotions;
using TinyLife.Mods;
using TinyLife.Objects;
using TinyLife.Utilities;

namespace ExampleMod {
    public class ExampleMod : Mod {

        // the logger that we can use to log info about this mod
        public static Logger Logger { get; private set; }

        public static EmotionModifier GrassSittingModifier;

        // visual data about this mod
        public override string Name => "Example Mod";
        public override string Description => "This is the example mod for Tiny Life!";
        public override TextureRegion Icon => this.uiTextures[0, 0];

        private UniformTextureAtlas customClothes;
        private UniformTextureAtlas uiTextures;

        public override void AddGameContent(GameImpl game) {
            // adding a custom furniture item
            FurnitureType.Register(new FurnitureType.TypeSettings("ExampleMod.CustomTable", new Point(1, 1), ObjectCategory.Table, 150, ColorScheme.SimpleWood) {
                ConstructedType = typeof(CustomTable),
                Icon = this.Icon,
                // allow chairs and plates to be slotted into and onto the table
                ObjectSpots = ObjectSpot.TableSpots(new Point(1, 1)).ToArray()
            });

            // adding custom clothing
            var darkShirt = new Clothes("ExampleMod.DarkShirt", ClothesLayer.Shirt,
                this.customClothes[0, 0], // the top left in-world region (the rest will be auto-gathered from the atlas)
                100, // the price
                ClothesIntention.Everyday | ClothesIntention.Workout, // the clothes item's use cases
                this.Icon, false, ColorScheme.WarmDark);
            Clothes.Register(darkShirt);

            // adding an event subscription to people
            MapObject.OnEventsAttachable += o => {
                if (o is Person person) {
                    // changing the walk speed to be doubled if a person is wearing our dark shirt
                    person.OnGetWalkSpeed += (ref float s) => {
                        if (person.CurrentOutfit.TryGetValue(ClothesLayer.Shirt, out var shirt) && shirt.Type == darkShirt)
                            s *= 2;
                    };
                }
            };

            // adding a simple action: sitting down in the grass, which also gives us a nice emotion modifier
            ActionType.Register(new ActionType.TypeSettings("ExampleMod.SitOnGrass", ObjectCategory.Ground, typeof(SitDownOnGrassAction)) {
                // we set this action to be executable only on grass tiles, not on other ground
                CanExecute = (info, automatic) => {
                    var tile = info.Map.GetTile(info.ActionLocation.ToPoint());
                    if (tile.Name.StartsWith("Grass"))
                        return ActionType.CanExecuteResult.Valid;
                    // hidden means the action won't be displayed in the ring menu
                    return ActionType.CanExecuteResult.Hidden;
                },
                // since this action doesn't use objects (like chairs etc.), we set a texture to display instead 
                Texture = this.uiTextures[1, 0]
            });
            GrassSittingModifier = EmotionModifier.Register(
                new EmotionModifier("ExampleMod.GrassSitting", this.uiTextures[1, 0], EmotionType.Happy));
        }

        public override void Initialize(Logger logger, RawContentManager content, RuntimeTexturePacker texturePacker) {
            Logger = logger;

            // loads a texture atlas with the given amount of separate texture regions in the x and y axes
            // we submit it to the texture packer to increase rendering performance. The callback is invoked once packing is completed
            texturePacker.Add(content.Load<Texture2D>("CustomClothes"), r => this.customClothes = new UniformTextureAtlas(r, 4, 8));
            texturePacker.Add(content.Load<Texture2D>("UiTextures"), r => this.uiTextures = new UniformTextureAtlas(r, 8, 8));
        }

        public override IEnumerable<string> GetCustomFurnitureTextures() {
            // tell the game about our custom furniture texture
            // this needs to be a path to a data texture atlas, relative to our "Content" directory
            // the texture atlas combines the png texture and the .atlas information
            // see https://mlem.ellpeck.de/api/MLEM.Data.DataTextureAtlas.html for more info
            yield return "CustomFurniture";
        }

    }
}