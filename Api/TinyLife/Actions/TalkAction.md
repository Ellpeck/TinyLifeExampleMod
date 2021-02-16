# [TalkAction](./TalkAction.md)

Namespace: [TinyLife]() > [Actions]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./TalkAction.md)

## Summary
TalkAction is a generic social action with a set of pre-defined parameters.  Things like `TinyLife.PersonalityType` and `TinyLife.Skills.SkillType.Charisma` automatically influence this interaction's `TinyLife.Actions.TalkAction.TalkSettings.FriendshipGain` and `TinyLife.Actions.TalkAction.TalkSettings.GoBadlyChance`.  `TinyLife.Actions.TalkAction.Create(System.String,System.Func{TinyLife.Objects.Person,System.Int32},TinyLife.Actions.TalkAction.TalkSettings)` should be used to create a talk action.

## Constructors

| Name | Summary | 
| --- | --- | 
| TalkAction ( [`ActionType`](./ActionType.md), [`ActionInfo`](./ActionInfo.md) ) |  | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | OnCompleted ( [`CompletionType`](./TalkAction.md) ) |  | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [TypeSettings](./TalkAction.md) | Create ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String), [`Func`](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2)\<[`Person`](./../Objects/Person.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)>, [`TalkSettings`](./TalkAction.md) ) |  | 


