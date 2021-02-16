# [Household](./Household.md)

Namespace: [TinyLife]() > [World]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./Household.md)

## Summary
A household is a set of `TinyLife.Objects.Person` instances that live together on the same `TinyLife.World.Household.Lot`

## Constructors

| Name | Summary | 
| --- | --- | 
| Household ( [`Map`](./Map.md), [`Lot`](./Lot.md) ) | Creates a new household on the given map and lot | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [HashSet](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1)\<[WornClothes](./../Objects/WornClothes.md)> | ClothesStorage | This household's clothing storage, which is a set of `TinyLife.Objects.WornClothes` that are not currently being worn by any members, but that are owned by this household | 
| [HashSet](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1)\<[Furniture](./../Objects/Furniture.md)> | FurnitureStorage | This household's furniture storage, which is a set of `TinyLife.Objects.Furniture` items that are not placed, but owned by this household | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | IsCurrent | A property that indicates whether or not this household is the same as `TinyLife.GameImpl.CurrentHousehold` | 
| [Lot](./Lot.md) | Lot | The `TinyLife.World.Household.Lot` that this household lives on.  For exported households, this might be null. | 
| [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[Person](./../Objects/Person.md)> | Members | The `TinyLife.Objects.Person` instances that are members of this household | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | Money | The money that this household has, rounded by two digits after the decimal point | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | Name | The name of this household.  The name of a household is the `TinyLife.Objects.Person.LastName` that most people in this household have. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Add ( [`Person`](./../Objects/Person.md) ) | Adds the given person to this household | 
| [ExportedHousehold](./ExportedHousehold.md) | Export (  ) | Exports this household's data into an `TinyLife.World.ExportedHousehold`, which can be saved to disk independently of the `TinyLife.World.Map` that this household is on. | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | GetAverageFriendshipTo ( [`Person`](./../Objects/Person.md) ) | Returns the average friendship level that the given `TinyLife.Objects.Person` has with members of this lot.  This method returns an averaged value of the `TinyLife.Relationship.FriendLevel` that this person has towards each member of this lot. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | HasMember ( [`Person`](./../Objects/Person.md) ) | Returns whether the given person is a part of this household | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | HasMember ( [`Guid`](https://docs.microsoft.com/en-us/dotnet/api/System.Guid) ) | Returns whether the given person `TinyLife.Objects.MapObject.Id` is a part of this household | 
| void | Import ( [`ExportedHousehold`](./ExportedHousehold.md) ) | Imports the given `TinyLife.World.ExportedHousehold` into this household.  Note that existing `TinyLife.World.Household.Members` are not removed or replaced beforehand. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | IsLotVisible ( [`Lot`](./Lot.md) ) | Returns whether the given lot is considered visible to this household  Note that passing this household's `TinyLife.World.Household.Lot` will always cause this method to return true. | 
| void | MarkLotNonVisible ( [`Lot`](./Lot.md) ) | Marks a lot non-visible if it's currently visible. | 
| void | MarkLotVisible ( [`Lot`](./Lot.md) ) | Marks the given lot as visible for members of this household.  `TinyLife.Objects.Person.VisitLot(TinyLife.World.Lot)` should be used in favor of this method in most cases.  By default, visibility lasts for 30 seconds of real time. | 
| void | Remove ( [`Person`](./../Objects/Person.md) ) | Removes the given person from this household, if they're part of it | 
| void | Update ( [`GameTime`](./Household.md), [`TimeSpan`](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan), [`GameSpeed`](./../GameSpeed.md) ) | Updates this household, ticking down the lot visibility times | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | Validate ( [`Map`](./Map.md) ) |  | 


