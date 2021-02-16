# [ExportedLot](./ExportedLot.md)

Namespace: [TinyLife]() > [World]()

Assembly: Tiny Life.dll

Implements [IPricedObject](./IPricedObject.md)

## Summary
An exported lot is all of the relevant data of a `TinyLife.World.Lot` that should be exported to a file when clicking the "Export" button in the build menu.  To create an exported lot from a lot, use `TinyLife.World.Lot.Export`.

## Constructors

| Name | Summary | 
| --- | --- | 
| ExportedLot (  ) |  | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Rectangle](./ExportedLot.md) | Area | The area that this lot covers in the world | 
| [List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1)\<[Furniture](./../Objects/Furniture.md)> | Furniture | The `TinyLife.World.ExportedLot.Furniture` that is present on this lot | 
| [List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1)\<[Roof](./Roof.md)> | Roofs | The roofs that are present on this lot | 
| [Tile](./ExportedLot.md)[] | Tiles | The ground tiles of this lot | 
| [LotType](./LotType.md) | Type | This lot's `TinyLife.World.LotType` | 
| [List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1)\<[Wall](./Wall.md)> | Walls | The walls that are present on this lot | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [RectangleF](./ExportedLot.md) | GetCoveredArea (  ) | Returns a `MLEM.Misc.RectangleF` that represents the area that this lot actually covers.  The area covered by this lot is always bounded by its `TinyLife.World.ExportedLot.Area`, but will be smaller if there are fewer objects on the lot. | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | GetPrice (  ) |  | 


