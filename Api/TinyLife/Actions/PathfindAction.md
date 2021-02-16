# [PathfindAction](./PathfindAction.md)

Namespace: [TinyLife]() > [Actions]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./PathfindAction.md)

## Summary
A pathfinding action is an action that first finds a path and then allows that path to be traversed.  The pathfinding is done using `MLEM.Pathfinding.AStar2`.

## Constructors

| Name | Summary | 
| --- | --- | 
| PathfindAction ( [`ActionType`](./ActionType.md), [`ActionInfo`](./ActionInfo.md) ) |  | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [Stack](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Stack-1)\<[Point](./PathfindAction.md)> | Path | The path that this action has found.  WHen `TinyLife.Actions.PathfindAction.OnPathReady` is called, this has a value. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Initialize (  ) |  | 
| [CompletionType](./PathfindAction.md) | IsCompleted (  ) |  | 
| void | OnCompleted ( [`CompletionType`](./PathfindAction.md) ) |  | 
| void | Update ( [`GameTime`](./PathfindAction.md), [`TimeSpan`](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan), [`GameSpeed`](./../GameSpeed.md) ) |  | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | Validate ( [`Person`](./../Objects/Person.md) ) |  | 


