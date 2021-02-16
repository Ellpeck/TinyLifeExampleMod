# [ColorScheme](./ColorScheme.md)

Namespace: [TinyLife]() > [Utilities]()

Assembly: Tiny Life.dll

Implements [IReadOnlyCollection](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1)\<[Color](./ColorScheme.md)>, [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[Color](./ColorScheme.md)>, [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable)

## Summary
A color scheme is a list of `Microsoft.Xna.Framework.Color` instances with which an object can be colored.  By default, a set of color schemes exist (defined in this class), but new ones can be created easily using `TinyLife.Utilities.ColorScheme.Create(System.Object[])`.

## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | Count | Stores the amount of `Microsoft.Xna.Framework.Color` instances that are part of this color scheme | 
| [Color](./ColorScheme.md) | Item | Returns the `Microsoft.Xna.Framework.Color` at the given index in this color scheme | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1)\<[Color](./ColorScheme.md)> | GetEnumerator (  ) |  | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [ColorScheme](./ColorScheme.md) | Bricks |  | 
| [ColorScheme](./ColorScheme.md) | Ceramics |  | 
| [ColorScheme](./ColorScheme.md) | Eyes |  | 
| [ColorScheme](./ColorScheme.md) | Flannel |  | 
| [ColorScheme](./ColorScheme.md) | Grays |  | 
| [ColorScheme](./ColorScheme.md) | Hair |  | 
| [ColorScheme](./ColorScheme.md) | Knit1 |  | 
| [ColorScheme](./ColorScheme.md) | Knit2 |  | 
| [ColorScheme](./ColorScheme.md) | Modern |  | 
| [ColorScheme](./ColorScheme.md) | Pastel |  | 
| [ColorScheme](./ColorScheme.md) | Plants |  | 
| [ColorScheme](./ColorScheme.md) | SimpleWood |  | 
| [ColorScheme](./ColorScheme.md) | Skin |  | 
| [ColorScheme](./ColorScheme.md) | WarmDark |  | 
| [ColorScheme](./ColorScheme.md) | White |  | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [ColorScheme](./ColorScheme.md) | Create ( [`Object`](https://docs.microsoft.com/en-us/dotnet/api/System.Object)[] ) | Create a new color scheme from the given colors.  The colors passed can be of type `Microsoft.Xna.Framework.Color`, `System.Int32` or `System.UInt32`. | 
| [ColorScheme](./ColorScheme.md) | Load ( [`TextureRegion`](./ColorScheme.md) ) | Loads a color scheme from the given texture region.  Each pixel on the texture region is evaluated and any pixels with an alpha value greater than zero are added to the color scheme. | 


