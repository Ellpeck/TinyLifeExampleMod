# [Tile](./Tile.md)

Namespace: [TinyLife]() > [World]()

Assembly: Tiny Life.dll

Implements [IPricedObject](./IPricedObject.md)

## Summary
A tile is an object on a `TinyLife.World.Map` that represents the covering of the ground (or the ground itself)

## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | BaseName | The name of this type of tile. Whereas `TinyLife.World.Tile.Name` has the index of its `TinyLife.World.Tile.color` appended to it, this one is just the type's name. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | CanBuy | A field that indicates whether this tile can be bought without the "ShowNonBuyable" cheat enabled | 
| [ColorScheme](./../Utilities/ColorScheme.md) | ColorScheme | The color scheme that this tile can have | 
| [TextureRegion](./Tile.md) | Icon | The build mode icon for this object, which represents the category / theme / mod that it comes from.  If this value is nonnull, the icon will be displayed in the corner of the build mode button for this object. | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | Name | The name of this specific tile. This is comprised of the `TinyLife.World.Tile.BaseName` with the `TinyLife.World.Tile.color`'s index attached to it. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | Natural | A field that indicates whether this tile is considered natural.  A natural tile is a tile that objects with the `TinyLife.Objects.ObjectCategory.NaturalGroundRequired` category can be placed on. | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | PathCostModifier | A field that indicates the "cost" for pathfinding of this tile.  The default modifier is 1, and it should not be set to a value lower than that. | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | Price | The price of this tile | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Draw ( [`SpriteBatch`](./Tile.md), [`Vector2`](./Tile.md), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single) ) | Draws this tile at the given position in the world | 
| void | DrawUi ( [`Element`](./Tile.md), [`SpriteBatch`](./Tile.md), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single) ) | Draws this tile on the given ui element, in ui space | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | GetPrice (  ) |  | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | Height | The height of each tile, in pixels | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | ReferencePrice | The reference price for tiles.  Since Grass is replaced by Concrete in a newly created room, the two tiles have to cost the same. This is that price.  This value is set to 5. | 
| [IDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2)\<[String](https://docs.microsoft.com/en-us/dotnet/api/System.String), [Tile](./Tile.md)[]> | Tiles | A registry of all tiles that exist in the game and its mods | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | Width | The width of each tile, in pixels | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Register ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32), [`TextureRegion`](./Tile.md), [`ColorScheme`](./../Utilities/ColorScheme.md), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean), [`TextureRegion`](./Tile.md) ) | Registers a new tile with the given settings | 


