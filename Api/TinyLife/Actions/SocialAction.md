# [SocialAction](./SocialAction.md)

Namespace: [TinyLife]() > [Actions]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./SocialAction.md)

## Summary
A social action is an action that involves two `TinyLife.Objects.Person` instances.  Before a social action "actually" starts, both parties have to have the action as their current action.  For this to happen, the person that initiates the action follows the `TinyLife.Actions.SocialAction.Partner` until they reach them (or give up).

## Constructors

| Name | Summary | 
| --- | --- | 
| SocialAction ( [`ActionType`](./ActionType.md), [`ActionInfo`](./ActionInfo.md) ) |  | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan) | ConversationTime | The amount of time that the actual conversation has been going on for.  This is the total amount of time (`TinyLife.Actions.Action.ElapsedTime`) minus the amount of time it took for the `TinyLife.Actions.SocialAction.IsMain``TinyLife.Objects.Person` to reach the `TinyLife.Actions.SocialAction.Partner`. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | IsMain | Whether or not this is the action that started the social interaction  The `TinyLife.Actions.SocialAction.PartnerAction` will always have the inverse value of this value. | 
| [Person](./../Objects/Person.md) | Partner | The `TinyLife.Objects.Person` that we're interacting with | 
| [SocialAction](./SocialAction.md) | PartnerAction | The `TinyLife.Actions.SocialAction` that the `TinyLife.Actions.SocialAction.Partner` of this action instantiated as part of the interaction | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | CanCancel ( [`Action`](./Action.md) ) |  | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | CanMultitask ( [`Action`](./Action.md) ) |  | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | GetDisplayName (  ) |  | 
| void | Initialize (  ) |  | 
| void | InvokeForBoth ( [`Action`](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2)\<[`Person`](./../Objects/Person.md), [`Person`](./../Objects/Person.md)> ) | Invokes the given action for both the `TinyLife.Objects.Person` and the `TinyLife.Actions.SocialAction.Partner`, passing both of them in the following way:  <code>  action(Person, Partner);  action(Partner, Person);  </code> | 
| [CompletionType](./SocialAction.md) | IsCompleted (  ) |  | 
| void | OnCompleted ( [`CompletionType`](./SocialAction.md) ) |  | 
| void | Update ( [`GameTime`](./SocialAction.md), [`TimeSpan`](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan), [`GameSpeed`](./../GameSpeed.md) ) |  | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | Validate ( [`Person`](./../Objects/Person.md) ) |  | 


