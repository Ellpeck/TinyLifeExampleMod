# [MapSection](./MapSection.md)

Namespace: [TinyLife]() > [World]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./MapSection.md)

## Summary
A map section is a small area in a `TinyLife.World.MapSection.Map` that actually contains the area's objects.  A map section is always `TinyLife.World.MapSection.Size`x`TinyLife.World.MapSection.Size` tiles large.

## Constructors

| Name | Summary | 
| --- | --- | 
| MapSection ( [`Map`](./Map.md), [`Point`](./MapSection.md) ) | Creates a new map section on the given map, with the given section position.  Also fills this map's tile array with the Grass tile. | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Point](./MapSection.md) | SectionPos | The position, in section coordinates, of this section on the map. | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [Point](./MapSection.md) | Pos | The position, in tile coordinates, of this section's top left corner. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | RemoveOutdatedRooms (  ) | Removes all outdated rooms on this map.  This is called by `TinyLife.World.Map.AddWall(TinyLife.World.Wall,System.Boolean)` and a few other methods. | 
| void | Update ( [`GameTime`](./MapSection.md), [`TimeSpan`](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan), [`GameSpeed`](./../GameSpeed.md) ) | Updates this map section and all of the objects on it | 
| void | Validate (  ) | This method is called when this object is loaded from disk.  When called on a map section, each of its `TinyLife.Objects.MapObject` instances is validated. | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | Size | The constant size of each map section.  This value is set to 8. | 


