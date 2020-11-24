using System;
using Microsoft.Xna.Framework;
using TinyLife.Objects;
using TinyLife.World;

namespace ExampleMod {
    public class CustomTable : Furniture {

        public CustomTable(Guid id, FurnitureType type, int[] colors, Map map, Vector2 pos) : base(id, type, colors, map, pos) {
        }

        public override void OnAdded() {
            base.OnAdded();
            ExampleMod.Logger.Info("We were added at " + this.Position);
        }

        public override void OnRemoved() {
            base.OnRemoved();
            ExampleMod.Logger.Info("We were removed from " + this.Position);
        }

    }
}