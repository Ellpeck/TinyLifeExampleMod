# [OpeningType](./OpeningType.md)

Namespace: [TinyLife]() > [World]()

Assembly: Tiny Life.dll

## Summary
An opening is some sort of extrusion in a `TinyLife.World.Wall`, like a window or a door.  An opening type stores data that can be used to construct a `TinyLife.World.Opening` instance.

## Constructors

| Name | Summary | 
| --- | --- | 
| OpeningType ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String), [`TextureRegion`](./OpeningType.md), [`WallMode`](./WallMode.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32), [`Func`](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4)\<[`OpeningType`](./OpeningType.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32), [`Wall`](./Wall.md), [`Opening`](./Opening.md)>, [`ColorScheme`](./../Utilities/ColorScheme.md), [`TextureRegion`](./OpeningType.md) ) | Creates a new opening type with the given settings | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [ColorScheme](./../Utilities/ColorScheme.md) | ColorScheme | The color scheme that opening instances can have when created from this type | 
| [TextureRegion](./OpeningType.md) | Icon | The build mode icon for this object, which represents the category / theme / mod that it comes from.  If this value is nonnull, the icon will be displayed in the corner of the build mode button for this object. | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | Name | The name of this opening type | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | Price | The price of this opening | 
| [WallMode](./WallMode.md) | WallMode | The `TinyLife.World.OpeningType.WallMode` that `TinyLife.World.Wall` instances with this opening in it should use for rendering | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Opening](./Opening.md) | Construct ( [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32), [`Wall`](./Wall.md) ) | Constructs a new `TinyLife.World.Opening` instance from this opening type | 
| void | Draw ( [`GameTime`](./OpeningType.md), [`SpriteBatch`](./OpeningType.md), [`Vector2`](./OpeningType.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) ) | Draws this opening in a wall | 
| void | DrawUi ( [`Element`](./OpeningType.md), [`SpriteBatch`](./OpeningType.md), [`GameTime`](./OpeningType.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single) ) | Draws this opening in ui space rather than world space | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [IDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2)\<[String](https://docs.microsoft.com/en-us/dotnet/api/System.String), [OpeningType](./OpeningType.md)> | Types | A registry for all `TinyLife.World.OpeningType` instances from the game and mods.  Use `TinyLife.World.OpeningType.Register(TinyLife.World.OpeningType)` to register custom opening types. | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Register ( [`OpeningType`](./OpeningType.md) ) | Registers the given `TinyLife.World.OpeningType` to the `TinyLife.World.OpeningType.Types` registry | 


