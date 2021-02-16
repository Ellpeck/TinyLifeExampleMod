# [ObjectSpot](./ObjectSpot.md)

Namespace: [TinyLife]() > [Objects]()

Assembly: Tiny Life.dll

## Summary
An object spot is a `TinyLife.Objects.AbstractSpot` extension that is used by `TinyLife.Objects.Furniture` to declare a location that another `TinyLife.Objects.Furniture` object can be slotted into.  This behavior is used for things like plates on counters, flower pots on bedside tables etc.

## Constructors

| Name | Summary | 
| --- | --- | 
| ObjectSpot ( [`Vector2`](./ObjectSpot.md), [`Predicate`](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1)\<[`FurnitureType`](./FurnitureType.md)>, [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Direction2`](./ObjectSpot.md)[] ) | Creates a new object spot with the given settings | 
| ObjectSpot ( [`Vector2`](./ObjectSpot.md), [`Vector2`](./ObjectSpot.md), [`Predicate`](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1)\<[`FurnitureType`](./FurnitureType.md)>, [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Direction2`](./ObjectSpot.md)[] ) | Creates a new object spot with the given settings | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Predicate](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1)\<[FurnitureType](./FurnitureType.md)> | IsFurnitureAllowed | A predicate that determines if the given `TinyLife.Objects.FurnitureType` is allowed to be put into this object spot | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [IEnumerable](./ObjectSpot.md)\<[T](./ObjectSpot.md)> | GetContents ( [`Furniture`](./Furniture.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | Returns the `TinyLife.Objects.Furniture` objects that are currently slotted into this spot | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [ObjectSpot](./ObjectSpot.md)[] | CounterSpots ( [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | A helper method to create a set of `TinyLife.Objects.ObjectSpot` instnaces for counters and stoves.  The resulting set contains a single object spot for `TinyLife.Objects.ObjectCategory.SmallObject` and `TinyLife.Objects.ObjectCategory.CounterObject` object, or `TinyLife.Objects.FurnitureType.PreparedFood` and `TinyLife.Objects.FurnitureType.Pot` if `` is true. | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[ObjectSpot](./ObjectSpot.md)> | TableSpots ( [`Point`](./ObjectSpot.md) ) | A helper method to create a set of `TinyLife.Objects.ObjectSpot` instances for a table of the given size.  The resulting set of object spots will have spots for `TinyLife.Objects.ObjectCategory.Chair` objects on each side as well as `TinyLife.Objects.ObjectCategory.SmallObject` objects on each tile position. | 


