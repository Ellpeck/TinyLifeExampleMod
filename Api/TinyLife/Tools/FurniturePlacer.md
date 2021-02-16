# [FurniturePlacer](./FurniturePlacer.md)

Namespace: [TinyLife]() > [Tools]()

Assembly: Tiny Life.dll

## Summary
A helper class that represents a tool part which allows the placement and movement of furniture objects.  This class is used by `TinyLife.Tools.FurnitureTool` and `TinyLife.Tools.MoveTool`.

## Constructors

| Name | Summary | 
| --- | --- | 
| FurniturePlacer ( [`Action`](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1)\<[`Furniture`](./../Objects/Furniture.md)> ) | Creates a new furniture placer with the given settings | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)[] | SelectedColors | The color indices that are currently selected for the `TinyLife.Tools.FurniturePlacer.SelectedFurniture` | 
| [FurnitureType](./../Objects/FurnitureType.md) | SelectedFurniture | The `TinyLife.Objects.FurnitureType` that is currently selected for placement | 
| [Furniture](./../Objects/Furniture.md) | SelectedPreview | An instance of the `TinyLife.Tools.FurniturePlacer.SelectedFurniture` | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Draw ( [`GameTime`](./FurniturePlacer.md), [`SpriteBatch`](./FurniturePlacer.md) ) | Draws the `TinyLife.Tools.FurniturePlacer.SelectedPreview` of this furniture placer | 
| [Nullable](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[WallDisplay](./../WallDisplay.md)> | ForceWallsUp (  ) |  | 
| [CursorType](./../Uis/CursorType.md) | GetMouseCursor (  ) |  | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | HighlightSelectedObject (  ) |  | 
| void | SelectFurniture ( [`FurnitureType`](./../Objects/FurnitureType.md), [`Furniture`](./../Objects/Furniture.md), [`Action`](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1)\<[`Furniture`](./../Objects/Furniture.md)>, [`Direction2`](./FurniturePlacer.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)[], [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | Selects the given `TinyLife.Objects.FurnitureType`.  If `` is enabled, the `` is the exact furniture instance that will be placed. If it is false, a new instance of the given `` will be created upon placement. | 
| void | Update (  ) | Updates this furniture placer.  This should be called in `TinyLife.Tools.Tool.Update(Microsoft.Xna.Framework.GameTime)` each frame. | 


