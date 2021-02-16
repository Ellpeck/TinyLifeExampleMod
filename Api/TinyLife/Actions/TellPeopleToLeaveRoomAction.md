# [TellPeopleToLeaveRoomAction](./TellPeopleToLeaveRoomAction.md)

Namespace: [TinyLife]() > [Actions]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./TellPeopleToLeaveRoomAction.md)


## Constructors

| Name | Summary | 
| --- | --- | 
| TellPeopleToLeaveRoomAction ( [`ActionType`](./ActionType.md), [`ActionInfo`](./ActionInfo.md) ) |  | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1)\<[Guid](https://docs.microsoft.com/en-us/dotnet/api/System.Guid)> | ExcludedPeople | A list of `System.Guid` ids of `TinyLife.Objects.Person` objects that should not be asked to leave the room | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Initialize (  ) |  | 
| [CompletionType](./TellPeopleToLeaveRoomAction.md) | IsCompleted (  ) |  | 
| void | OnCompleted ( [`CompletionType`](./TellPeopleToLeaveRoomAction.md) ) |  | 


