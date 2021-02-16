# [Roof](./Roof.md)

Namespace: [TinyLife]() > [World]()

Assembly: Tiny Life.dll

Implements [IPricedObject](./IPricedObject.md)

## Summary
A roof is an object on a `TinyLife.World.Map` that is on a higher level and cannot be interacted with by people

## Constructors

| Name | Summary | 
| --- | --- | 
| Roof ( [`RoofType`](./RoofType.md), [`Rectangle`](./Roof.md), [`Direction2`](./Roof.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) ) | Creates a new roof with the given settings | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Rectangle](./Roof.md) | Area | The area that this roof covers | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | Color | The color index in in `TinyLife.Utilities.ColorScheme.WarmDark` that this roof uses for its top | 
| [RoofType](./RoofType.md) | Type | The `TinyLife.World.RoofType` that this roof has | 
| [Wallpaper](./Wallpaper.md) | Wallpaper | The `TinyLife.World.Roof.Wallpaper` that is applied to this roof.  This defaults to the Default wallpaper. | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [Direction2](./Roof.md) | Rotation | The rotation that this roof has.  This is only relevant for roofs that don't have the `TinyLife.World.RoofType.Flat` type. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | GetPrice (  ) |  | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Draw ( [`GameTime`](./Roof.md), [`SpriteBatch`](./Roof.md), [`Map`](./Map.md), [`RoofType`](./RoofType.md), [`Rectangle`](./Roof.md), [`Direction2`](./Roof.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32), [`Wallpaper`](./Wallpaper.md), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single) ) | Draws the given `TinyLife.World.Roof` in world space | 
| void | DrawUi ( [`SpriteBatch`](./Roof.md), [`Element`](./Roof.md), [`RoofType`](./RoofType.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single) ) | Draws a `TinyLife.World.Roof` in ui space, only drawing a 1x1 area of it | 
| void | GenerateRoof ( [`Room`](./Room.md) ) | Generates the roofing for the given `TinyLife.World.Room` and adds it to the map.  The generated roofing is split into as few separate parts as possible by ordering the tiles the room covers. | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | GetPriceByType ( [`RoofType`](./RoofType.md) ) | Returns the price of the given `TinyLife.World.RoofType` | 


