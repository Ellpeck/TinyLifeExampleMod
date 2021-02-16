# [Wall](./Wall.md)

Namespace: [TinyLife]() > [World]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./Wall.md), [IPricedObject](./IPricedObject.md)

## Summary
A wall is an element of a `TinyLife.World.Map` that stops traversal and that has a `TinyLife.World.Wallpaper` and optionally an `TinyLife.World.Wall.Opening` attached to it.

## Constructors

| Name | Summary | 
| --- | --- | 
| Wall ( [`Point`](./Wall.md)[] ) | Creates a new wall at the given position, with the implicitly given verticality | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Point](./Wall.md)[] | Positions | The two positions that this wall is placed in.  The two positions refer to the tile coordinate of the tile on the front face of the wall, and the tile coordinate of the tile on the back face of the wall. | 
| [Wallpaper](./Wall.md)[] | Wallpapers | The two wallpapers attached to this `TinyLife.World.Wall`, on either one of its sides | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [Opening](./Opening.md) | Opening | The `TinyLife.World.Wall.Opening` attached to this wall, or null if there is none.  Use `TinyLife.World.Wall.SetOpening(TinyLife.World.Map,TinyLife.World.Opening)` to set this value. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | Vertical | Stores whether this wall is vertical. A vertical wall is one where the `TinyLife.World.Wall.Positions` have the same y, but different x coordinates. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Draw ( [`Map`](./Map.md), [`GameTime`](./Wall.md), [`SpriteBatch`](./Wall.md), [`Vector2`](./Wall.md) ) | Draws this wall in the world, along with its `TinyLife.World.Wall.Wallpapers` and `TinyLife.World.Wall.Opening` | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | GetDepth ( [`Map`](./Map.md), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single) ) | Returns the depth that should be used for a wall placed at this wall's positions.  This method is used for rendering `TinyLife.World.Wallpaper` and `TinyLife.World.Wall.Opening`. | 
| [WallMode](./WallMode.md) | GetDisplayMode (  ) | Returns the `TinyLife.World.WallMode` that this wall should be rendered with.  If the `TinyLife.World.Wall.Opening` is nonnull, its `TinyLife.World.OpeningType.WallMode` is returned. | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | GetIndexForCamera (  ) | Returns the side of the wall that should be rendered.  For `TinyLife.World.Wall.Vertical` walls, the position with the highest X value is returned.  For non-`TinyLife.World.Wall.Vertical` walls, the position with the highest Y value is returned. | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | GetPrice (  ) |  | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | IsDown (  ) | Returns whether this wall should be rendered with a lower height than its actual height.  If this value returns true, `TinyLife.World.Wall.Draw(TinyLife.World.Map,Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Vector2)` only draws the first 5 or so pixels of the wall to allow for a simple view of what is behind the wall.  This value is based on the lot visibility, the `TinyLife.Options.WallMode` and more. | 
| void | SetOpening ( [`Map`](./Map.md), [`Opening`](./Opening.md) ) | Changes the `TinyLife.World.Wall.Opening` in this wall to the specified one | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | Validate (  ) | This method is called when this object is loaded from disk. | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [WallMode](./Wall.md)[] | DisplayModes | All defined values of the `TinyLife.World.WallMode` enumeration | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | Price | The price of building a single wall element | 


