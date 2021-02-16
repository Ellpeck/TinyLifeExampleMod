# [OutOfTownAction](./OutOfTownAction.md)

Namespace: [TinyLife]() > [Actions]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./OutOfTownAction.md)

## Summary
An out-of-town action is an action where the `TinyLife.Objects.Person` finds the closest exit road and then exits the city using that road.  Out-of-town actions are things like going to work, where the destination location isn't visible to the player.

## Constructors

| Name | Summary | 
| --- | --- | 
| OutOfTownAction ( [`ActionType`](./ActionType.md), [`ActionInfo`](./ActionInfo.md), [`NeedType`](./OutOfTownAction.md)[] ) | Creates a new out-of-town action with the given settings.  Note that, since some data is not saved to disk, all of the information should be provided by a subclass constructor. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | CausesExtremelyFastSpeed (  ) |  | 
| [Action](./Action.md) | GetNextAction ( [`CompletionType`](./OutOfTownAction.md) ) |  | 


