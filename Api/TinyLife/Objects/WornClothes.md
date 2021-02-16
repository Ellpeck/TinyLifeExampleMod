# [WornClothes](./WornClothes.md)

Namespace: [TinyLife]() > [Objects]()

Assembly: Tiny Life.dll

## Summary
WornClothes is a wrapper around `TinyLife.Objects.Clothes` that additionally stores the colors and whether or not the clothes are from the `TinyLife.World.Household.ClothesStorage` or not

## Constructors

| Name | Summary | 
| --- | --- | 
| WornClothes ( [`Clothes`](./Clothes.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)[] ) | Creates a new worn `TinyLife.Objects.Clothes` instance with the given settings | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)[] | Colors | The colors of this `TinyLife.Objects.Clothes` instance.  Each index references the color of the underlying `TinyLife.Objects.WornClothes.Type`'s `TinyLife.Objects.Clothes.Colors`.  The actual color can be retrieved easily using `TinyLife.Objects.WornClothes.GetColor(System.Int32)`. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | FromStorage | This value is true if this clothes item is from the `TinyLife.World.Household.ClothesStorage` | 
| [Clothes](./Clothes.md) | Type | The `TinyLife.Objects.Clothes` type that these worn clothes reference | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Color](./WornClothes.md) | GetColor ( [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) ) | Returns the `Microsoft.Xna.Framework.Color` of the given layer | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | Validate (  ) | This method is called when this object is loaded from disk. | 


