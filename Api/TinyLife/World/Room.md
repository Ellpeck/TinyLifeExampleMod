# [Room](./Room.md)

Namespace: [TinyLife]() > [World]()

Assembly: Tiny Life.dll

## Summary
A room is an area on a `TinyLife.World.Room.Map` that is surrounded by `TinyLife.World.Wall` objects

## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Point](./Room.md) | Center | The position that is considered to be the center of this room.  This is the average of all of its covered `TinyLife.World.Room.Tiles`, and the `TinyLife.World.MapSection` that this room is on is determined by this value. | 
| [HashSet](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1)\<[MapSection](./MapSection.md)> | CoveredSections | A set of `TinyLife.World.MapSection` instances that are covered by this room | 
| [Map](./Map.md) | Map | The map that this room is on | 
| [HashSet](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1)\<[Point](./Room.md)> | Tiles | A set of `Microsoft.Xna.Framework.Point` positions on the `TinyLife.World.Room.Map` that are contained in this room | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[Room](./Room.md)> | GetConnectedRooms (  ) | Returns a set of `TinyLife.World.Room` objects which are connected to this room.  A connected room is a room that is directly adjacent, and that a `TinyLife.Objects.Person` can walk into through an `TinyLife.World.Opening`. | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | GetDecorativeRating (  ) | Returns the combined decorative rating of all of the `TinyLife.Objects.Furniture` in this room.  This method uses the `TinyLife.Objects.FurnitureType.TypeSettings.DecorativeRating` function. | 
| [IEnumerable](./Room.md)\<[T](./Room.md)> | GetObjects (  ) | Returns all of the `TinyLife.Objects.MapObject` instances that are contained in this room | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[ValueTuple](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple-2)\<[Wall](./Wall.md), [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)>> | GetWalls ( [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | Returns all of the `TinyLife.World.Wall` instances that are border walls or internal walls of this room.  An internal wall is a wall for which both sides are contained in the room, rather than just one. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | IsFullyRoofed (  ) | Returns whether or not this room has a `TinyLife.World.Roof` on all of its `TinyLife.World.Room.Tiles` | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | IsSameRoom ( [`ICollection`](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1)\<[`Point`](./Room.md)> ) | Returns whether this room has the same covered `TinyLife.World.Room.Tiles` as the given collection | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | Validate (  ) | This method is called when this object is loaded from disk. | 


