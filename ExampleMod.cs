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
using TinyLife.World;

namespace ExampleMod;

public class ExampleMod : Mod {

    // the logger that we can use to log info about this mod
    public static Logger Logger { get; private set; }

    public static EmotionModifier GrassSittingModifier { get; private set; }

    // visual data about this mod
    public override string Name => "Example Mod";
    public override string Description => "This is the example mod for Tiny Life!";
    public override TextureRegion Icon => this.uiTextures[0, 0];

    private UniformTextureAtlas customTops;
    private UniformTextureAtlas customHairs;
    private UniformTextureAtlas customBottoms;
    private UniformTextureAtlas uiTextures;
    private Dictionary<Point, TextureRegion> wallpaperTextures;

    public override void AddGameContent(GameImpl game, ModInfo info) {
        // adding a custom furniture item
        FurnitureType.Register(new FurnitureType.TypeSettings("ExampleMod.CustomTable", new Point(1, 1), ObjectCategory.Table, 150, ColorScheme.SimpleWood) {
            // specify the type that should be constructed when this furniture type is placed
            // if this is not specified, the  Furniture class is used, which is used for furniture without special animations or data
            ConstructedType = typeof(CustomTable),
            // specifying icons for custom clothes and furniture is optional, but using the mod's icon helps users recognize a mod's features
            Icon = this.Icon,
            // allow chairs and plates to be slotted into and onto the table
            ObjectSpots = ObjectSpot.TableSpots(new Point(1, 1)).ToArray()
        });

        // adding custom clothing
        var darkShirt = new Clothes("ExampleMod.DarkShirt", ClothesLayer.Shirt,
            this.customTops[0, 0], // the top left in-world region (the rest will be auto-gathered from the atlas)
            100, // the price
            ClothesIntention.Everyday | ClothesIntention.Workout, // the clothes item's use cases
            ColorScheme.WarmDark) {Icon = this.Icon};
        Clothes.Register(darkShirt);
        // adding some more custom clothing
        Clothes.Register(new Clothes("ExampleMod.PastelPants", ClothesLayer.Pants, this.customBottoms[4, 0], 100, ClothesIntention.Everyday, ColorScheme.Pastel) {Icon = this.Icon});
        Clothes.Register(new Clothes("ExampleMod.PastelShoes", ClothesLayer.Shoes, this.customBottoms[0, 0], 100, ClothesIntention.Everyday, ColorScheme.Pastel) {Icon = this.Icon});
        Clothes.Register(new Clothes("ExampleMod.WeirdHair", ClothesLayer.Hair, this.customHairs[0, 0], 0, ClothesIntention.None, ColorScheme.Modern) {Icon = this.Icon});

        // adding an event subscription to people
        MapObject.OnEventsAttachable += o => {
            if (o is Person person) {
                // changing the walk speed to be doubled if a person is wearing our dark shirt
                person.OnGetWalkSpeed += (ref float s) => {
                    if (person.CurrentOutfit.Clothes.TryGetValue(ClothesLayer.Shirt, out var shirt) && shirt.Type == darkShirt)
                        s *= 2;
                };
            }
        };

        // adding a simple action: sitting down in the grass, which also gives us a nice emotion modifier
        ActionType.Register(new ActionType.TypeSettings("ExampleMod.SitOnGrass", ObjectCategory.Ground, typeof(SitDownOnGrassAction)) {
            // we set this action to be executable only on grass tiles, not on other ground
            CanExecute = (actionInfo, automatic) => {
                if (!actionInfo.Map.IsInBounds(actionInfo.ActionLocation.ToPoint()))
                    return CanExecuteResult.Hidden;
                var tile = actionInfo.Map.GetTile(actionInfo.ActionLocation.ToPoint());
                // hidden means the action won't be displayed in the ring menu, Valid means the player (or AI) is able to enqueue and execute it
                return tile.Name.StartsWith("Grass") ? CanExecuteResult.Valid : CanExecuteResult.Hidden;
            },
            Ai = {
                // we allow the action to be done even if the solved needs aren't low enough on a person
                CanDoRandomly = true,
                // the solved needs indicate when the AI should mark this action as important, they don't actually have to match the action's behavior
                SolvedNeeds = new[] {NeedType.Energy},
                // make people more likely to sit down in the grass if they're uncomfortable 
                PassivePriority = p => p.Emotion == EmotionType.Uncomfortable ? 150 : 25
            },
            // since this action doesn't use objects (like chairs etc.), we set a texture to display instead 
            Texture = this.uiTextures[1, 0]
        });

        // we use this emotion modifier in SitDownOnGrassAction
        ExampleMod.GrassSittingModifier = EmotionModifier.Register(
            new EmotionModifier("ExampleMod.GrassSitting", this.uiTextures[1, 0], EmotionType.Happy));

        // adding a custom wallpaper (we're using the top left texture region, which is why we pass 0, 0 as the texture coordinate)
        Wallpaper.Register("ExampleMod.CrossedWallpaper", 15, this.wallpaperTextures, new Point(0, 0), ColorScheme.Modern, this.Icon);
    }

    public override void Initialize(Logger logger, RawContentManager content, RuntimeTexturePacker texturePacker, ModInfo info) {
        ExampleMod.Logger = logger;

        // loads a texture atlas with the given amount of separate texture regions in the x and y axes
        // we submit it to the texture packer to increase rendering performance. The callback is invoked once packing is completed
        texturePacker.Add(content.Load<Texture2D>("CustomTops"), r => this.customTops = new UniformTextureAtlas(r, 4, 8));
        texturePacker.Add(content.Load<Texture2D>("CustomHairs"), r => this.customHairs = new UniformTextureAtlas(r, 4, 6));
        texturePacker.Add(content.Load<Texture2D>("CustomBottomsShoes"), r => this.customBottoms = new UniformTextureAtlas(r, 8, 6));
        texturePacker.Add(content.Load<Texture2D>("UiTextures"), r => this.uiTextures = new UniformTextureAtlas(r, 8, 8));
        // wallpaper textures require special treatment to work with openings, the x and y values are passed to the UniformTextureAtlas constructor
        WallMode.ApplyMasks(content.Load<Texture2D>("Wallpapers"), 4, 5, texturePacker, r => this.wallpaperTextures = r);
    }

    public override IEnumerable<string> GetCustomFurnitureTextures(ModInfo info) {
        // tell the game about our custom furniture texture
        // this needs to be a path to a data texture atlas, relative to our "Content" directory
        // the texture atlas combines the png texture and the .atlas information
        // see https://mlem.ellpeck.de/api/MLEM.Data.DataTextureAtlas.html for more info
        yield return "CustomFurniture";
    }

}
