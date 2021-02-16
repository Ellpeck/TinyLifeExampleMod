# [Lot](./Lot.md)

Namespace: [TinyLife]() > [World]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./Lot.md), [IPricedObject](./IPricedObject.md)

## Summary
A lot is a designated area in the world (created using the `TinyLife.Tools.LotTool`).  In the way it works, it acts similarly to a small `TinyLife.World.Map`, allowing the retrieval of various object types only in its designated area.  A lot has a `TinyLife.World.LotType`, which determines what things can be done on the lot.

## Constructors

| Name | Summary | 
| --- | --- | 
| Lot ( [`Map`](./Map.md), [`Rectangle`](./Lot.md) ) | Creates a new lot on the given map with the given area | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Rectangle](./Lot.md) | Area | The area in the world that this lot occupies | 
| [Guid](https://docs.microsoft.com/en-us/dotnet/api/System.Guid) | Id | The unique id of this lot.  This is randomly generated when the lot is first added to the world, and then persists across savings to disk. | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | Name | The name of this lot, as set by the player in build mode | 
| [LotType](./LotType.md) | Type | The `TinyLife.World.LotType` that this lot has.  This value defaults to the "Residential" lot type. | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [Household](./Household.md) | Household | The household that is currently occupying this `TinyLife.World.Lot`.  This can only be non-null if the `TinyLife.World.Lot.Type` has `TinyLife.World.LotType.IsResidential` set to true. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | AreRequirementsMet (  ) | Returns whether this lot `TinyLife.World.Lot.Type`'s `TinyLife.World.LotType.RequiredFurniture` requirements are currently met | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | CanImport ( [`ExportedLot`](./ExportedLot.md) ) | A method that calculates whether the given `TinyLife.World.ExportedLot` can be imported.  A lot can be imported if the `TinyLife.World.Lot.Household` has enough money, and if this lot's `TinyLife.World.Lot.Area` is greater than or equal to the exported lot's area. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | CanMove ( [`Direction2`](./Lot.md) ) | Returns whether or not the entire lot can be moved in the given direction.  The decision is based on this lot's `TinyLife.World.Lot.GetCoveredArea` and its `TinyLife.World.Lot.Area`. | 
| [ExportedLot](./ExportedLot.md) | Export (  ) | Exports this lot's data, including all of its `TinyLife.Objects.Furniture`, `TinyLife.World.Wall` and `TinyLife.World.Roof` obejects and its `TinyLife.World.Tile` ground.  Note that this does not change the lot itself, as it doesn't remove or add anything to it. | 
| [RectangleF](./Lot.md) | GetCoveredArea (  ) | Returns a `MLEM.Misc.RectangleF` that represents the area that this lot actually covers.  The area covered by this lot is always bounded by its `TinyLife.World.Lot.Area`, but will be smaller if there are fewer objects on the lot. | 
| [Wall](./Wall.md) | GetFrontDoor (  ) | Returns the `TinyLife.World.Wall` that this lot's front door is located in.  The front door is the door that is closest to this lot's `TinyLife.Objects.FurnitureType.Mailbox` that also connects a non-room (the outside) to a room (the inside). | 
| [Vector2](./Lot.md) | GetHomeLocation ( [`Person`](./../Objects/Person.md) ) | Returns the home location of the given `TinyLife.Objects.Person` on this lot.  The home position is the position of the front door on a residential lot (`TinyLife.World.LotType.IsResidential`) or the closest border position to the passed `TinyLife.Objects.Person` otherwise. | 
| [IEnumerable](./Lot.md)\<[T](./Lot.md)> | GetObjects (  ) | Returns the set of all of the `TinyLife.Objects.MapObject` instances on this lot's map that are contained in this lot's `TinyLife.World.Lot.Area`. | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | GetPrice (  ) |  | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[Roof](./Roof.md)> | GetRoofs (  ) | Returns a set of all of the `TinyLife.World.Roof` instances on this lot's map that are contained in this lot's `TinyLife.World.Lot.Area` | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[Wall](./Wall.md)> | GetWalls (  ) | Returns a set of all of the `TinyLife.World.Wall` instances on this lot's map that are contained in this lot's `TinyLife.World.Lot.Area` | 
| void | Import ( [`ExportedLot`](./ExportedLot.md) ) | Imports the given `TinyLife.World.ExportedLot` onto this lot.  Note that everything that was previously on this lot will be removed (and the money will be returned to this lot's `TinyLife.World.Lot.Household`).  Also note that the `TinyLife.World.Lot.Household` stays the same, and all tiles outside of the exported lot's area (if it is smaller) are replaced with Grass. | 
| void | Move ( [`Direction2`](./Lot.md) ) | Move the entire lot in the given direction (by one tile).  Note that `TinyLife.World.Lot.CanMove(MLEM.Misc.Direction2)` is not called internally. | 
| void | Validate ( [`Map`](./Map.md) ) |  | 


