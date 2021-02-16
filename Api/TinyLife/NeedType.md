# [NeedType](./NeedType.md)

Namespace: [TinyLife]()

Assembly: Tiny Life.dll

## Summary
A need is a desire that a `TinyLife.Objects.Person` can have to a given extent.  To register a custom need type, use `TinyLife.NeedType.Register(TinyLife.NeedType)`.

## Constructors

| Name | Summary | 
| --- | --- | 
| NeedType ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Func`](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2)\<[`Person`](./Objects/Person.md), [`ActionType`](./Actions/ActionType.md)>, [`Func`](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2)\<[`Person`](./Objects/Person.md), [`TimeSpan`](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan)>, [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single) ) | Instantiates a new need type with the given settings | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | Name | The name of this need.  Used for `TinyLife.Localization` purposes and saving to disk. | 
| [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2)\<[Person](./Objects/Person.md), [ActionType](./Actions/ActionType.md)> | NeedLowAction | The `TinyLife.Actions.ActionType` that is constructed and executed when this need type's `TinyLife.Need.Value` is very low | 
| [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2)\<[Person](./Objects/Person.md), [TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan)> | NeedLowTime | The amount of in-game time that needs to pass until `TinyLife.NeedType.NeedLowAction` is constructed and enqueued | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | PassiveReduction | The amount that a need instance's `TinyLife.Need.Value` is reduced by automatically every update frame | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | SolveImportance | The priority for solving this need over other needs, where higher numbers represent a more urgent need.  This value defaults to 0, meaning it has no special importance. | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [NeedType](./NeedType.md) | Energy |  | 
| [NeedType](./NeedType.md) | Entertainment |  | 
| [NeedType](./NeedType.md) | Hunger |  | 
| [NeedType](./NeedType.md) | Hygiene |  | 
| [NeedType](./NeedType.md) | Social |  | 
| [NeedType](./NeedType.md) | Toilet |  | 
| [IList](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1)\<[NeedType](./NeedType.md)> | Types | A list of all of the need types that are currently registered.  Register custom need types using `TinyLife.NeedType.Register(TinyLife.NeedType)`. | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [NeedType](./NeedType.md) | Register ( [`NeedType`](./NeedType.md) ) | Register the `TinyLife.NeedType` specified to the `TinyLife.NeedType.Types` dictionary | 


