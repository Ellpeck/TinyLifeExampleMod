# [UnderlyingAction](./UnderlyingAction.md)

Namespace: [TinyLife]() > [Actions]()

Assembly: Tiny Life.dll

## Summary
An UnderlyingAction is a class that can instantiate a single `TinyLife.Actions.UnderlyingAction.Action` that will be executed as part of the action it is used in.  Note that, when using this class, `TinyLife.Actions.UnderlyingAction.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)` and `TinyLife.Actions.UnderlyingAction.Validate(TinyLife.Objects.Person)` have to be called in the appropriate places.

## Constructors

| Name | Summary | 
| --- | --- | 
| UnderlyingAction (  ) |  | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [Action](./Action.md) | Action | The underlying action.  This should be initialized using `TinyLife.Actions.UnderlyingAction.Initialize(TinyLife.Actions.ActionType,TinyLife.Actions.ActionInfo)`. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Initialize ( [`ActionType`](./ActionType.md), [`ActionInfo`](./ActionInfo.md) ) | Initializes the underlying action of this action | 
| void | Update ( [`GameTime`](./UnderlyingAction.md), [`TimeSpan`](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan), [`GameSpeed`](./../GameSpeed.md) ) | Updates the `TinyLife.Actions.UnderlyingAction.Action`, if it exists.  This action should be called in `TinyLife.Actions.Action.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)`. | 
| void | Validate ( [`Person`](./../Objects/Person.md) ) | Validates this action container and its `TinyLife.Actions.UnderlyingAction.Action`.  This method should be called in `TinyLife.Actions.Action.Validate(TinyLife.Objects.Person)`. | 


