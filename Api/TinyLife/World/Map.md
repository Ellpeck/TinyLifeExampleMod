# [Map](./Map.md)

Namespace: [TinyLife]() > [World]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./Map.md)

## Summary
A map holds all of the data about a city, like its tiles, its objects and its roads.  A map is split into `TinyLife.World.MapSection` objects which allows faster retrieval of objects in an area.

## Constructors

| Name | Summary | 
| --- | --- | 
| Map ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String), [`Point`](./Map.md) ) | Creates a new map with the given name and size | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | Name | The name of this map | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [Point](./Map.md) | Size | The size in tiles that this map has.  This is always `TinyLife.World.Map.SizeInSections` multiplied by `TinyLife.World.MapSection.Size`. | 
| [Point](./Map.md) | SizeInSections | The size, in sections (not tiles) that this map has | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | StaticVersion | The static version of this map.  When a new save file is created, a static version of each map is loaded and used as the save file's basis.  If the static version of the save file is newer, their save file is updated to the new static map version, which causes all non-lot objects to be copied to the saved map. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Household](./Household.md) | AddHousehold ( [`Lot`](./Lot.md), [`Person`](./Map.md)[] ) | Adds a new household to this map by calling the `TinyLife.World.Household` constructor. | 
| [Lot](./Lot.md) | AddLot ( [`Rectangle`](./Map.md) ) | Adds a new lot with the given area to this map's lots | 
| void | AddObject ( [`MapObject`](./../Objects/MapObject.md) ) | Adds the given object to this map.  Note that, if the object's `TinyLife.Objects.MapObject.Id` is already present on this map, this method will cause an exception. | 
| void | AddRoad ( [`Point`](./Map.md) ) | Adds a road to the map at the given position.  This doesn't actually add the road tiles, but it notifies the pathfinder that there is a road center at this location. | 
| void | AddRoof ( [`Roof`](./Roof.md) ) | Adds the given roof to this map | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | AddWall ( [`Point`](./Map.md), [`Point`](./Map.md) ) | Adds the given wall to the given position. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | AddWall ( [`Wall`](./Wall.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | Adds the given wall to the given position.  Optionally, the `TinyLife.World.Room` related to that wall is re-calculated. | 
| void | Draw ( [`GameTime`](./Map.md), [`SpriteBatch`](./Map.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | Draws this map and all of its objects.  Note that drawing in this manner uses multiple `Microsoft.Xna.Framework.Graphics.RenderTarget2D` objects, for things like the ground and the lightmaps. | 
| [Nullable](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[Point](./Map.md)> | GetClosestEmptyTile ( [`Vector2`](./Map.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | Returns the position of the closest tile that is empty.  An empty tile is a tile that has no `TinyLife.Objects.MapObject` instances on it. | 
| [Point](./Map.md) | GetClosestRoad ( [`Point`](./Map.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) ) | Returns the clost road marker to the given position, keeping the given radius in mind. | 
| [Point](./Map.md) | GetClosestSidewalk ( [`Point`](./Map.md), [`Vector2`](./Map.md) ) | Returns the closest sidewalk position to the given road position.  A sidewalk is a tile whose name starts with "Concrete" that is `TinyLife.World.Map.RoadRadius`+1 tiles away from the road marker.  Note that the road position must have `TinyLife.World.Map.IsRoad(Microsoft.Xna.Framework.Point)` return true for it. | 
| [Person](./../Objects/Person.md) | GetDeadPerson ( [`Guid`](https://docs.microsoft.com/en-us/dotnet/api/System.Guid) ) | Returns a dead `TinyLife.Objects.Person` with the given `System.Guid` id | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | GetDepth ( [`Vector2`](./Map.md), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | Gets the depth that should be used for drawing an object at the given tile position | 
| [Household](./Household.md) | GetHousehold ( [`Person`](./../Objects/Person.md) ) | Returns the household that the given `TinyLife.Objects.Person` lives in | 
| [Household](./Household.md) | GetHousehold ( [`Lot`](./Lot.md) ) | Returns the household that lives on the given `TinyLife.World.Lot` | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[Household](./Household.md)> | GetHouseholds (  ) | Returns a set of all of the `TinyLife.World.Household` instances that live on this map | 
| [Lot](./Lot.md) | GetLot ( [`Guid`](https://docs.microsoft.com/en-us/dotnet/api/System.Guid) ) | Returns the lot with the given id on this map.  The returned lot's `TinyLife.World.Lot.Id` will equal the given id. | 
| [Lot](./Lot.md) | GetLot ( [`Point`](./Map.md) ) | Returns the lot that is present at the given position.  The lot returned will always have its `TinyLife.World.Lot.Area` contain the passed position. | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[Lot](./Lot.md)> | GetLots (  ) | Returns a set of all of the `TinyLife.World.Lot` objects on this map | 
| [T](./Map.md) | GetObject ( [`Guid`](https://docs.microsoft.com/en-us/dotnet/api/System.Guid) ) | Returns the object with the given id of the given type.  If there is no object with that id, or its type does not match, null is returned. | 
| [IEnumerable](./Map.md)\<[T](./Map.md)> | GetObjects ( [`RectangleF`](./Map.md) ) | Returns a set of objects that are present in the given area. | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | GetPathCost ( [`Point`](./Map.md), [`Point`](./Map.md) ) | Returns the cost to pathfind from the given current position to the given next position.  Note that, for this method to return a proper result, `` has to be directly or diagonally adjacent to ``. | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[Person](./../Objects/Person.md)> | GetPeople (  ) | Returns all of the `TinyLife.Objects.Person` objects that are on this map | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[Point](./Map.md)> | GetRoads (  ) | Returns a set of all of the road markers on this map | 
| [Roof](./Roof.md) | GetRoof ( [`Point`](./Map.md) ) | Gets a `TinyLife.World.Roof` whose area contains the given position | 
| [Room](./Room.md) | GetRoom ( [`Point`](./Map.md) ) | Returns the room that the given position is contained in | 
| [MapSection](./MapSection.md) | GetSection ( [`Point`](./Map.md) ) | Returns the `TinyLife.World.MapSection` at the given tile position | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[MapSection](./MapSection.md)> | GetSections ( [`Point`](./Map.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) ) | Returns a set of sections that are contained in (or intersect with) the given area | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[MapSection](./MapSection.md)> | GetSections ( [`RectangleF`](./Map.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) ) | Returns a set of sections that are contained in (or intersect with) the given area | 
| [Tile](./Tile.md) | GetTile ( [`Point`](./Map.md) ) | Returns the tile at the given position on this map | 
| [Wall](./Wall.md) | GetWallBetween ( [`Point`](./Map.md), [`Point`](./Map.md) ) | Returns the wall between the `` and ``.  A wall is between two positions if its `TinyLife.World.Wall.Positions` are exactly those two positions, ignoring their order. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | IsFreeSpot ( [`Point`](./Map.md) ) | Returns whether or not the given position on the given map is free for a `TinyLife.Objects.Person` to stand in | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | IsInBounds ( [`Point`](./Map.md) ) | Returns whether the given position is in bounds of this map's `TinyLife.World.Map.Size` | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | IsInSectionBounds ( [`Point`](./Map.md) ) | Returns whether the given section position is in bounds of this map's `TinyLife.World.Map.SizeInSections`. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | IsRoad ( [`Point`](./Map.md) ) | Returns whether the given position contains a road.  This doesn't query road tiles, but it queries for road markers added by `TinyLife.World.Map.AddRoad(Microsoft.Xna.Framework.Point)`. | 
| void | MarkDirtyForPathfinding ( [`Point`](./Map.md) ) | Marks the given position dirty for pathfinding purposes.  When a path is found again close to this position, its cost (`TinyLife.World.Map.GetPathCost(Microsoft.Xna.Framework.Point,Microsoft.Xna.Framework.Point)`) will be re-calculated.  This method is called by `TinyLife.Objects.Furniture` when it is placed for removed. | 
| [SoundEffectInstance](./Map.md) | PlaySound ( [`SoundEffect`](./Map.md), [`Vector2`](./Map.md), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | Plays a sound at the given location (in world space) statically.  If the sound should move while being played, use `TinyLife.World.Map.PlaySound(Microsoft.Xna.Framework.Audio.SoundEffect,Microsoft.Xna.Framework.Audio.AudioEmitter,System.Single,System.Single,System.Boolean)` instead.  Note that the returned `Microsoft.Xna.Framework.Audio.SoundEffectInstance` does not need to be disposed when it is finished playing. | 
| [SoundEffectInstance](./Map.md) | PlaySound ( [`SoundEffect`](./Map.md), [`AudioEmitter`](./Map.md), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | Plays a sound at the given location (in world space) with the given `Microsoft.Xna.Framework.Audio.AudioEmitter`, whose `Microsoft.Xna.Framework.Audio.AudioEmitter.Position` can be updated by the caller (in screen space).  If the sound should move in a static locatdion, use `TinyLife.World.Map.PlaySound(Microsoft.Xna.Framework.Audio.SoundEffect,Microsoft.Xna.Framework.Vector2,System.Single,System.Single,System.Boolean)` instead.  Note that the returned `Microsoft.Xna.Framework.Audio.SoundEffectInstance` does not need to be disposed when it is finished playing. | 
| void | RemoveHousehold ( [`Household`](./Household.md) ) | Removes the given household from this map | 
| void | RemoveLot ( [`Lot`](./Lot.md) ) | Removes the given lot from this map's lots | 
| void | RemoveObject ( [`MapObject`](./../Objects/MapObject.md) ) | Removes the given object from this map and its underlying `TinyLife.World.MapSection`.  This also calls `TinyLife.Objects.MapObject.OnRemoved`. | 
| void | RemoveRoof ( [`Roof`](./Roof.md) ) | Removes the given `TinyLife.World.Roof` from this map | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | RemoveWall ( [`Wall`](./Wall.md) ) | Removes the given wall from the map | 
| void | SetTile ( [`Point`](./Map.md), [`Tile`](./Tile.md) ) | Sets the tile at the given position to the given tile | 
| void | Update ( [`GameTime`](./Map.md), [`TimeSpan`](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan), [`GameSpeed`](./../GameSpeed.md) ) | Updates this map, its `TinyLife.World.MapSection` objects and its `TinyLife.World.Household`s. | 
| void | Validate (  ) | This method is called when this object is loaded from disk.  When called on a map, each `TinyLife.World.MapSection` is validated, and roads and rooms are generated. | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | RoadRadius | This field holds the radius that roads are required to have (in road tiles) excluding the center dotted line tiles.  It is set to 2. | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Map](./Map.md) | LoadStaticMap ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String) ) | Loads a static map with the given name from the game's content directory.  Note that the map is not validated (`TinyLife.World.Map.Validate`). | 


