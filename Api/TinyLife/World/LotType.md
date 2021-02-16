# [LotType](./LotType.md)

Namespace: [TinyLife]() > [World]()

Assembly: Tiny Life.dll

## Summary
A lot type is data for a `TinyLife.World.Lot` that determines the required furniture on the lot as well as whether the lot is residential or not.  Additionally, custom lot types can define different reasons and interactions for `TinyLife.Objects.Person` objects to visit lots of the type.

## Constructors

| Name | Summary | 
| --- | --- | 
| LotType ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean), [`Func`](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3)\<[`Lot`](./Lot.md), [`Person`](./../Objects/Person.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)>, [`ValueTuple`](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple-2)[]\<[`FurnitureType`](./../Objects/FurnitureType.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)> ) |  | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3)\<[Lot](./Lot.md), [Person](./../Objects/Person.md), [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)> | GetVisitPriority | A function that returns, for a `TinyLife.World.Lot` with this lot type, and a `TinyLife.Objects.Person` trying ot visit the lot, how likely it is for the lot to be chosen.  The higher the return value is, the more likely it is for this lot to be chosen.  For reference, the "Park" lot type always returns 200. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | IsResidential | Whether this lot is residential.  A residential lot is one that `TinyLife.World.Household`s can move into. | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | Name | The name of this lot type | 
| [ValueTuple](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple-2)[]\<[FurnitureType](./../Objects/FurnitureType.md), [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)> | RequiredFurniture | A set of furniture that is required on the lot.  Each entry determines the `TinyLife.Objects.FurnitureType` required, as well as the amount of that item that is required on the lot. | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [IDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2)\<[String](https://docs.microsoft.com/en-us/dotnet/api/System.String), [LotType](./LotType.md)> | Types | A registry for all `TinyLife.World.LotType` objects that the game and mods define | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Register ( [`LotType`](./LotType.md) ) | Registers a new lot type to the `TinyLife.World.LotType.Types` registry | 


