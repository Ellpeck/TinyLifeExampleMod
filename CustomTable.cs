using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using MonoGame.Extended;
using TinyLife.Objects;
using TinyLife.World;

namespace ExampleMod {
    public class CustomTable : Furniture {

        private static readonly Random Random = new();

        // anything whose base classes have the DataContract attribute automatically gets saved and loaded to and from disk
        // this means that you can add custom DataMember members to have them saved and loaded
        [DataMember]
        public float TestValue;

        public CustomTable(Guid id, FurnitureType type, int[] colors, Map map, Vector2 pos) : base(id, type, colors, map, pos) {
            this.TestValue = Random.NextSingle();
        }

        public override void OnAdded() {
            base.OnAdded();
            ExampleMod.Logger.Info("We were added at " + this.Position);
        }

        public override void OnRemoved() {
            base.OnRemoved();
            ExampleMod.Logger.Info("We were removed from " + this.Position);
        }

        // validate is called when this object is loaded from disk
        // returning false causes the object to be marked as invalid and removed
        public override bool Validate() {
            return base.Validate() && this.TestValue <= 1;
        }

    }
}