# [Clothes](./Clothes.md)

Namespace: [TinyLife]() > [Objects]()

Assembly: Tiny Life.dll

Implements [IPricedObject](./../World/IPricedObject.md)

## Summary
A set of information and a registry for clothing items (and hair) that a `TinyLife.Objects.Person` can wear.  Custom clothes can be registered using `TinyLife.Objects.Clothes.Register(TinyLife.Objects.Clothes)`.

## Constructors

| Name | Summary | 
| --- | --- | 
| Clothes ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String), [`ClothesLayer`](./ClothesLayer.md), [`TextureRegion`](./Clothes.md), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`TextureRegion`](./Clothes.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean), [`ColorScheme`](./Clothes.md)[] ) |  | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [ColorScheme](./Clothes.md)[] | Colors | The set of `TinyLife.Utilities.ColorScheme`s that this clothes item can have its colors selected from.  The color scheme at index i will be mapped to the `TinyLife.Objects.Clothes.TextureRegions` entry at index i. | 
| [TextureRegion](./Clothes.md) | Icon | The character creator icon for this object, which represents the category / theme / mod that it comes from.  If this value is nonnull, the icon will be displayed in the corner of the character creator button for this object. | 
| [ClothesLayer](./ClothesLayer.md) | Layer | The `TinyLife.Objects.ClothesLayer` that this clothes item should render on | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | Name | The name of this clothes item.  Since this is used for the `TinyLife.Objects.Clothes.Types` registry, the name must be unique across mods. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | NonBuyable | This value determines whether this clothes item can be bought in the character creator.  If this value is false, the only way for this clothes item to be visible in the character creator is by adding it to the `TinyLife.World.Household.ClothesStorage`. | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | Price | The price of this piece of clothing.  Use `TinyLife.Objects.Clothes.GetPrice` to retrieve this value for consistency. | 
| [TextureRegion](./Clothes.md)[] | TextureRegions | The `MLEM.Textures.TextureRegion` that this clothes item uses in the world.  The texture region specified in the constructor only needs to cover the top left animation frame of the `TinyLife.Objects.Person`, any remaining frames will automatically be gathered.  Multiple layers will be gathered if `TinyLife.Objects.Clothes.Colors` has multiple entries. Each new layer will be gathered to the right of the passed region's area. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | GetPrice (  ) |  | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [ClothesLayer](./Clothes.md)[] | Layers | A set of all valid `TinyLife.Objects.ClothesLayer` values | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | ReferencePrice | The reference price for a piece of clothing.  When clothes items are randomly chosen for a new `TinyLife.Objects.Person`, the items chosen will be guaranteed to have a price equal to or below this value. | 
| [IDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2)\<[String](https://docs.microsoft.com/en-us/dotnet/api/System.String), [Clothes](./Clothes.md)> | Types | A registry that contains all `TinyLife.Objects.Clothes` in the game and all mods | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Register ( [`Clothes`](./Clothes.md) ) | Register the given clothes instance to the `TinyLife.Objects.Clothes.Types` registry | 


