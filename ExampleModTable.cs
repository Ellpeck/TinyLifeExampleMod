using System;
using System.Runtime.Serialization;
using TinyLife.Objects;
using TinyLife.World;

namespace ExampleMod;

// note that having a custom class for a furniture item like this is entirely optional
// but it allows for additional functionalities as displayed in this example
public class ExampleModTable : Furniture {

    // anything whose base classes have the DataContract attribute automatically gets saved and loaded to and from disk
    // this means that you can add custom DataMember members to have them saved and loaded
    [DataMember]
    public float TestValue;

    public ExampleModTable(Guid id, FurnitureType type, int[] colors, Map map, Vector2 pos) : base(id, type, colors, map, pos) {
        this.TestValue = Furniture.Random.NextSingle();
    }

    public override void OnAdded() {
        base.OnAdded();
        ExampleMod.Logger.Info("The custom table was added at " + this.Position);
    }

    public override void OnRemoved() {
        base.OnRemoved();
        ExampleMod.Logger.Info("The custom table was removed from " + this.Position);
    }

    // validate is called when this object is loaded from disk
    // returning false causes the object to be marked as invalid and removed
    public override bool Validate() {
        return base.Validate() && this.TestValue <= 1;
    }

}
