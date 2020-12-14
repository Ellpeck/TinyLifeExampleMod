using System.Collections.Generic;
using ExtremelySimpleLogger;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MLEM.Data;
using MLEM.Data.Content;
using MLEM.Textures;
using TinyLife;
using TinyLife.Mods;
using TinyLife.Objects;
using TinyLife.Utilities;

namespace ExampleMod {
    public class ExampleMod : Mod {

        // the logger that we can use to log info about this mod
        public static Logger Logger { get; private set; }

        // visual data about this mod
        public override string Name => "Example Mod";
        public override string Description => "This is the example mod for Tiny Life!";

        private DataTextureAtlas customFurniture;
        private UniformTextureAtlas customClothes;
        private UniformTextureAtlas customClothesIcons;

        public override void AddGameContent(GameImpl game) {
            // adding a custom furniture item
            FurnitureType.Register(new FurnitureType.TypeSettings("ExampleMod.CustomTable", new Point(1, 1), ObjectCategory.Table, 150, ColorScheme.SimpleWood) {
                Construct = (i, t, c, m, p) => new CustomTable(i, t, c, m, p)
            });

            // adding custom clothing
            Clothes.Register(new Clothes("ExampleMod.DarkShirt", ClothesLayer.Shirt,
                this.customClothes[0, 0], // the top left in-world region (the rest will be auto-gathered from the atlas)
                this.customClothesIcons[0, 0], // the region to use for the icon in the character editor
                ColorScheme.WarmDark));
        }

        public override void Initialize(Logger logger, RawContentManager content) {
            Logger = logger;

            // loads the custom furniture texture atlas
            // the texture atlas combines the png texture and the .atlas information
            // see https://mlem.ellpeck.de/api/MLEM.Data.DataTextureAtlas.html for more info
            this.customFurniture = content.LoadTextureAtlas("CustomFurniture");

            // loads a texture atlas with the given amount of separate texture regions in the x and y axes
            this.customClothes = new UniformTextureAtlas(content.Load<Texture2D>("CustomClothes"), 4, 6);
            this.customClothesIcons = new UniformTextureAtlas(content.Load<Texture2D>("CustomClothesIcons"), 16, 16);
        }

        public override IEnumerable<DataTextureAtlas> GetCustomFurnitureTextures() {
            // tell the game about our custom furniture texture
            yield return this.customFurniture;
        }

    }
}