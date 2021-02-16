# [MultiAction](./MultiAction.md)

Namespace: [TinyLife]() > [Actions]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./MultiAction.md)

## Summary
A multi action is an action that can have different actions executed before and/or after itself.  This is quite useful if an action requires a `TinyLife.Objects.Person` to go somewhere to pick up an item etc.

## Constructors

| Name | Summary | 
| --- | --- | 
| MultiAction ( [`ActionType`](./ActionType.md), [`ActionInfo`](./ActionInfo.md) ) |  | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [Queue](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Queue-1)\<[Action](./Action.md)> | FirstActions | The actions that should be executed beore this action | 
| [TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan) | MainElapsedTime | The amount of time that has elapsed of this action, excluding the time that `TinyLife.Actions.MultiAction.FirstActions` took. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | CanCancel ( [`Action`](./Action.md) ) |  | 
| void | Initialize (  ) |  | 
| [CompletionType](./MultiAction.md) | IsCompleted (  ) |  | 
| void | OnCompleted ( [`CompletionType`](./MultiAction.md) ) |  | 
| void | Update ( [`GameTime`](./MultiAction.md), [`TimeSpan`](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan), [`GameSpeed`](./../GameSpeed.md) ) |  | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | Validate ( [`Person`](./../Objects/Person.md) ) |  | 


