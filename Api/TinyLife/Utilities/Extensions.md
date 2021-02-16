# [Extensions](./Extensions.md)

Namespace: [TinyLife]() > [Utilities]()

Assembly: Tiny Life.dll

## Summary
A set of extensions for dealing with various things required by Tiny Life.

## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Button](./Extensions.md) | AddHoverAnimation ( [`Button`](./Extensions.md) ) | Adds a hover animation to the given `MLEM.Ui.Elements.Button`.  The hover animation will automatically start playing when the mouse enters the button. | 
| [CompletionType](./Extensions.md) | BothCompleted ( [`CompletionType`](./Extensions.md), [`Func`](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1)\<[`CompletionType`](./Extensions.md)> ) |  | 
| [CanExecuteResult](./Extensions.md) | BothValid ( [`CanExecuteResult`](./Extensions.md), [`Func`](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1)\<[`CanExecuteResult`](./Extensions.md)> ) |  | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | GetDecorativeRating ( [`Quality`](./../Skills/Quality.md) ) | Returns the decorative rating of an object with the given `TinyLife.Skills.Quality`.  The returned values are as follows:  `TinyLife.Skills.Quality.Terrible`: -2,  `TinyLife.Skills.Quality.Good`: 1,  `TinyLife.Skills.Quality.Great`: 1,  `TinyLife.Skills.Quality.Perfect`: 2,  `TinyLife.Skills.Quality.Masterpiece`: 3,  Else: 0. | 
| [GenealogyType](./../GenealogyType.md) | GetOpposite ( [`GenealogyType`](./../GenealogyType.md) ) | Returns the opposite of the given `TinyLife.GenealogyType`.  The "opposite" is the relationship that the other partner of this `TinyLife.GenealogyType` will have.  For example, the opposite of `TinyLife.GenealogyType.Parent` is `TinyLife.GenealogyType.Child` and vice versa. | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | GetPriceModifier ( [`Quality`](./../Skills/Quality.md) ) | Returns a multiplier that an object's price should be multiplied with based on the given `TinyLife.Skills.Quality`. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | IsVertical ( [`Direction2`](./Extensions.md) ) | Returns whether the passed direction is considered vertical.  A vertical direction is `MLEM.Misc.Direction2.Up` and `MLEM.Misc.Direction2.Down`. All other directions return false. | 
| [T](./Extensions.md) | JsonCopy ( [`T`](./Extensions.md) ) | Copies the given object using the `TinyLife.SaveHandler.Serializer`. | 
| [CompletionType](./Extensions.md) | OneCompleted ( [`CompletionType`](./Extensions.md), [`Func`](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1)\<[`CompletionType`](./Extensions.md)> ) |  | 
| [Direction2](./Extensions.md) | RotateBy ( [`Direction2`](./Extensions.md), [`Direction2`](./Extensions.md), [`Direction2`](./Extensions.md) ) | Rotates the given direction by a given reference direction. | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | ToLocalizedString ( [`Quality`](./../Skills/Quality.md) ) | Returns a localized string for the given `TinyLife.Skills.Quality`. | 
| [Vector2](./Extensions.md) | ToScreenPos ( [`Vector2`](./Extensions.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | Converts the given world-space position into a draw-space position | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | ToSellingPriceString ( [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single) ) | Returns a string of the structure "$0.##" that displays the given value as a price in dollars. | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | ToWallSide ( [`Direction2`](./Extensions.md) ) | Returns an integer that represents the given `MLEM.Misc.Direction2` as a side of a `TinyLife.World.Wall`.  Specifically, `MLEM.Misc.Direction2.Up` and `MLEM.Misc.Direction2.Left` return 0, any other directions return 1. | 
| [Pose](./Extensions.md) | ToWorking ( [`Pose`](./Extensions.md) ) |  | 
| [Vector2](./Extensions.md) | ToWorldPos ( [`Vector2`](./Extensions.md) ) | Converts the given draw-space position into a world-space position | 


