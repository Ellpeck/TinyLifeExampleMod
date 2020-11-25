using System;
using System.Collections.Generic;
using ExtremelySimpleLogger;
using Microsoft.Xna.Framework;
using MLEM.Data;
using MLEM.Data.Content;
using MLEM.Misc;
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

        public override void AddGameContent(GameImpl game) {
            // adding a custom furniture item
            FurnitureType.Register(new FurnitureType.TypeSettings("ExampleMod.CustomTable", new Point(1, 1), ObjectCategory.Table, 150, ColorScheme.SimpleWood) {
                Construct = (i, t, c, m, p) => new CustomTable(i, t, c, m, p)
            });
        }

        public override void Initialize(Logger logger, RawContentManager content) {
            Logger = logger;

            // loads the custom furniture texture atlas
            // the texture atlas combines the png texture and the .atlas information
            // see https://mlem.ellpeck.de/api/MLEM.Data.DataTextureAtlas.html for more info
            this.customFurniture = content.LoadTextureAtlas("CustomFurniture");
        }

        public override IEnumerable<DataTextureAtlas> GetCustomFurnitureTextures() {
            // tell the game about our custom furniture texture
            yield return this.customFurniture;
        }

    }
}