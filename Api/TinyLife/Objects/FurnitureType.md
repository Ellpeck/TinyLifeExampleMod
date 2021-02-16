# [FurnitureType](./FurnitureType.md)

Namespace: [TinyLife]() > [Objects]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./FurnitureType.md), [IPricedObject](./../World/IPricedObject.md)

## Summary
A furniture type is basically a blueprint for `TinyLife.Objects.Furniture` objects.  Each furniture type can create a furniture instance and the type's data will be transferred to the instance.  Furniture types are automatically listed in the `TinyLife.Tools.FurnitureTool` if registered using `TinyLife.Objects.FurnitureType.Register(TinyLife.Objects.FurnitureType.TypeSettings)`.

## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Dictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2)\<[Direction2](./FurnitureType.md), [TextureRegion](./FurnitureType.md)[]> | Textures | The textures that this furniture type has.  Each texture is automatically loaded based on the registered `MLEM.Data.DataTextureAtlas` instances.  If a furniture type has multiple `TinyLife.Objects.FurnitureType.TypeSettings.ColorMap` entries (or multiple `TinyLife.Objects.FurnitureType.TypeSettings.ColorSchemes`), additional texture regions will automatically be created to the right of the original texture region. | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [TextureRegion](./FurnitureType.md) | ReferenceTexture | A reference texture that is used for visual size calculations. Always returns the first available texture of `TinyLife.Objects.FurnitureType.TypeSettings.DefaultRotation` in `TinyLife.Objects.FurnitureType.Textures` | 
| [ICollection](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1)\<[Direction2](./FurnitureType.md)> | Rotations | The valid rotations that this furniture has, which are automatically determined based on the available `TinyLife.Objects.FurnitureType.Textures` | 
| [TypeSettings](./FurnitureType.md) | Settings | This furniture type's settings | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | AreWallsInTheWay ( [`Map`](./../World/Map.md), [`Vector2`](./FurnitureType.md), [`Direction2`](./FurnitureType.md) ) | Returns whether or not there would be walls in the way if this furniture type was placed at the given position with the given rotation | 
| [Furniture](./Furniture.md) | Construct ( [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)[], [`Map`](./../World/Map.md), [`Vector2`](./FurnitureType.md), [`Nullable`](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[`Guid`](https://docs.microsoft.com/en-us/dotnet/api/System.Guid)> ) | Constructs a new `TinyLife.Objects.Furniture` object from this furniture type | 
| void | DrawLayers ( [`Map`](./../World/Map.md), [`Vector2`](./FurnitureType.md), [`SpriteBatch`](./FurnitureType.md), [`Vector2`](./FurnitureType.md), [`Direction2`](./FurnitureType.md), [`TextureRegion`](./FurnitureType.md)[], [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)[], [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean), [`Furniture`](./Furniture.md), [`ObjectSpot`](./ObjectSpot.md), [`Nullable`](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[`Color`](./FurnitureType.md)>, [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | Draws the furniture type with the given data | 
| [Direction2](./FurnitureType.md) | GetBestRotation ( [`Direction2`](./FurnitureType.md) ) | Returns a `MLEM.Misc.Direction2` that is closest to ``, but that this object is allowed to have.  The return value is guaranteed to be contained in `TinyLife.Objects.FurnitureType.Rotations` and have the same verticality as ``, or be the same value. | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | GetColumns ( [`Direction2`](./FurnitureType.md) ) | Returns the amount of columns that this furniture should be drawn in, based on the given rotation. | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | GetPrice (  ) |  | 
| [Point](./FurnitureType.md) | GetSize ( [`Direction2`](./FurnitureType.md) ) | Returns the `TinyLife.Objects.FurnitureType.TypeSettings.Size` of this furniture type, modified based on the given rotation. | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[Wall](./../World/Wall.md)> | GetWallsInTheWay ( [`Map`](./../World/Map.md), [`Vector2`](./FurnitureType.md), [`Direction2`](./FurnitureType.md) ) | Returns a set of walls that would be in the way if this furniture type was placed at the given position with the given rotation | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | HasCategory ( [`ObjectCategory`](./ObjectCategory.md) ) | Returns whether this type's `TinyLife.Objects.FurnitureType.Settings` have any of the supplied `TinyLife.Objects.ObjectCategory` values | 
| void | SlotIntoActionSpot ( [`Vector2`](./FurnitureType.md), [`Direction2`](./FurnitureType.md), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32), out [`Vector2`](./FurnitureType.md), out [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single) ) | A helper method that modifies `` and `` so that they can be used for depth calculations that will make an object look as if it was slotted into the given action spot | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [FurnitureType](./FurnitureType.md) | Book |  | 
| [FurnitureType](./FurnitureType.md) | CountryFence |  | 
| [FurnitureType](./FurnitureType.md) | CustomPainting |  | 
| [FurnitureType](./FurnitureType.md) | EmptyPlate |  | 
| [FurnitureType](./FurnitureType.md) | FoodPlate |  | 
| [FurnitureType](./FurnitureType.md) | GrassPatch |  | 
| [FurnitureType](./FurnitureType.md) | Gravestone |  | 
| [FurnitureType](./FurnitureType.md) | Hedge |  | 
| [FurnitureType](./FurnitureType.md) | LongDinnerTable |  | 
| [FurnitureType](./FurnitureType.md) | Mailbox |  | 
| [FurnitureType](./FurnitureType.md) | MapleTree |  | 
| [FurnitureType](./FurnitureType.md) | ModernBed |  | 
| [FurnitureType](./FurnitureType.md) | ModernComputer |  | 
| [FurnitureType](./FurnitureType.md) | ModernFridge |  | 
| [FurnitureType](./FurnitureType.md) | ModernSingleBed |  | 
| [FurnitureType](./FurnitureType.md) | ModernSink |  | 
| [FurnitureType](./FurnitureType.md) | ModernStove |  | 
| [FurnitureType](./FurnitureType.md) | ModernTv |  | 
| [FurnitureType](./FurnitureType.md) | PaintBrush |  | 
| [FurnitureType](./FurnitureType.md) | Pot |  | 
| [FurnitureType](./FurnitureType.md) | PotPlant |  | 
| [FurnitureType](./FurnitureType.md) | PreparedFood |  | 
| [FurnitureType](./FurnitureType.md) | Puddle |  | 
| [FurnitureType](./FurnitureType.md) | SimpleBench |  | 
| [FurnitureType](./FurnitureType.md) | SimpleBookshelf |  | 
| [FurnitureType](./FurnitureType.md) | SimpleChair |  | 
| [FurnitureType](./FurnitureType.md) | SimpleCounter |  | 
| [FurnitureType](./FurnitureType.md) | SimpleDesk |  | 
| [FurnitureType](./FurnitureType.md) | SimpleDrawer |  | 
| [FurnitureType](./FurnitureType.md) | SimpleEasel |  | 
| [FurnitureType](./FurnitureType.md) | SimpleShower |  | 
| [FurnitureType](./FurnitureType.md) | SimpleToilet |  | 
| [FurnitureType](./FurnitureType.md) | SmallBush |  | 
| [FurnitureType](./FurnitureType.md) | SmallMirror |  | 
| [FurnitureType](./FurnitureType.md) | SmallPlant |  | 
| [FurnitureType](./FurnitureType.md) | Spanner |  | 
| [FurnitureType](./FurnitureType.md) | Sponge |  | 
| [FurnitureType](./FurnitureType.md) | SquareDinnerTable |  | 
| [IDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2)\<[String](https://docs.microsoft.com/en-us/dotnet/api/System.String), [FurnitureType](./FurnitureType.md)> | Types | A list of all available furniture types. Register furniture types using `TinyLife.Objects.FurnitureType.Register(TinyLife.Objects.FurnitureType.TypeSettings)`. | 
| [FurnitureType](./FurnitureType.md) | UnpreparedFood |  | 
| [FurnitureType](./FurnitureType.md) | YarnBox |  | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | DrawColumns ( [`Map`](./../World/Map.md), [`Vector2`](./FurnitureType.md), [`Direction2`](./FurnitureType.md), [`SpriteBatch`](./FurnitureType.md), [`Vector2`](./FurnitureType.md), [`TextureRegion`](./FurnitureType.md), [`Color`](./FurnitureType.md), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Point`](./FurnitureType.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean), [`Furniture`](./Furniture.md), [`ObjectSpot`](./ObjectSpot.md), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | Draws the given texture region in columns, which allows for depth calculation in isometric view to be possible.  Bigger objects, including all furniture, are drawn in this matter. | 
| [Rectangle](./FurnitureType.md) | GetCoveredTiles ( [`Vector2`](./FurnitureType.md), [`Point`](./FurnitureType.md) ) | Returns a rectangle that contains all of the tiles which intersect with the furniture when placed at the given position, with the given size. | 
| [TextureRegion](./FurnitureType.md) | GetTexture ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String) ) | Returns a `MLEM.Textures.TextureRegion` with the given name, based on all of the textures in the base game and all `TinyLife.Mods.Mod.GetCustomFurnitureTextures` textures. | 
| [Dictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2)\<[Direction2](./FurnitureType.md), [TextureRegion](./FurnitureType.md)[]> | GetTextures ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) ) | Create a dictionary of textures for all `MLEM.Misc.Direction2Helper.Adjacent` directions that have a texture registered for them.  Textures are gathered using `TinyLife.Mods.Mod.GetCustomFurnitureTextures`, and textures need to be suffixed with the direction's string to be recognized.  This method is used for furniture of all kinds. | 
| [FurnitureType](./FurnitureType.md) | Register ( [`TypeSettings`](./FurnitureType.md) ) |  | 
| void | SlotIntoObjectSpot ( [`Furniture`](./Furniture.md), [`ObjectSpot`](./ObjectSpot.md), [`Point`](./FurnitureType.md), out [`Vector2`](./FurnitureType.md), out [`Point`](./FurnitureType.md) ) | A helper method that modifies `` and `` to make an object look like it is slotted into the given `TinyLife.Objects.ObjectSpot` | 


