# [ActionInfo](./ActionInfo.md)

Namespace: [TinyLife]() > [Actions]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./ActionInfo.md)

## Summary
An action info is a set of information that is required to execute an action

## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Vector2](./ActionInfo.md) | ActionLocation | The location that this action should be executed in.  Note that this is mostly only relevant if there is no `TinyLife.Actions.ActionInfo.ActionObject`. | 
| [Guid](https://docs.microsoft.com/en-us/dotnet/api/System.Guid) | ActionObject | The `System.Guid` of the object that this action is related to. Can be `System.Guid.Empty`, which indicates that there is no action object.  To retrieve the actual object, use `TinyLife.Actions.ActionInfo.GetActionObject``1`. | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [ActionSpot](./../Objects/ActionSpot.md) | ActionSpot | The `TinyLife.Actions.ActionInfo.ActionSpot` that this action is related to. Can be null, even if the `TinyLife.Actions.ActionInfo.ActionObject` exists. | 
| [Map](./../World/Map.md) | Map | The `TinyLife.Actions.ActionInfo.Map` that the action is executed on | 
| [Person](./../Objects/Person.md) | Person | The `TinyLife.Actions.ActionInfo.Person` that is currently executing the action | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | AddAuxiliaryObject ( [`MapObject`](./../Objects/MapObject.md) ) | Adds an additional object that, along with the `TinyLife.Actions.ActionInfo.ActionObject`, is involved in this action.  Adding an auxiliary object causes `TinyLife.Actions.ActionInfo.GetInvolvedObjects``1(TinyLife.Objects.ObjectCategory)` to consider it, as well as `TinyLife.Objects.MapObject.ActionUpdate(TinyLife.Actions.Action,Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed,System.Boolean)` to be called for it. | 
| [T](./ActionInfo.md) | GetActionObject (  ) | Returns the object that this action is related to, or null if there is none or the object isn't of the given type. | 
| [T](./ActionInfo.md) | GetInvolvedObject ( [`ObjectCategory`](./../Objects/ObjectCategory.md) ) | A helper method that returns the first available entry from `TinyLife.Actions.ActionInfo.GetInvolvedObjects``1(TinyLife.Objects.ObjectCategory)` or null if there is none | 
| [IEnumerable](./ActionInfo.md)\<[T](./ActionInfo.md)> | GetInvolvedObjects ( [`ObjectCategory`](./../Objects/ObjectCategory.md) ) | Returns a set of objects of the given type `type` that match the given ``.  The objects considered are the `TinyLife.Actions.ActionInfo.ActionObject`, the `TinyLife.Actions.ActionInfo.Person`'s `TinyLife.Objects.Person.GetHeldObject``1` and the auxiliary objects added using `TinyLife.Actions.ActionInfo.AddAuxiliaryObject(TinyLife.Objects.MapObject)`. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | OccupyFreeActionSpot ( [`ObjectCategory`](./../Objects/ObjectCategory.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean), [`Nullable`](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[`Direction2`](./ActionInfo.md)> ) | This is a shorthand method for `TinyLife.Objects.Furniture.GetFreeActionSpot(TinyLife.Objects.Person,TinyLife.Objects.ObjectCategory)` and `TinyLife.Objects.Person.OccupyActionSpot(TinyLife.Objects.Furniture,TinyLife.Objects.ActionSpot,System.Boolean,System.Nullable{MLEM.Misc.Direction2})`.  Note that this method needs to be called every update frame for the person to keep occupying the action spot. | 
| [ActionInfo](./ActionInfo.md) | ToFreeActionSpot ( [`ObjectCategory`](./../Objects/ObjectCategory.md) ) | This is a shorthand method for `TinyLife.Objects.Furniture.GetFreeActionSpotInfo(TinyLife.Objects.Person,TinyLife.Objects.ObjectCategory)` that is applied to our action object (`TinyLife.Actions.ActionInfo.GetActionObject``1`). | 
| void | Validate ( [`Person`](./../Objects/Person.md) ) | Validates this action info.  This method should only be called when this action info is read from disk. | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [ActionInfo](./ActionInfo.md) | FromLocation ( [`Person`](./../Objects/Person.md), [`Vector2`](./ActionInfo.md) ) | Returns a new `TinyLife.Actions.ActionInfo` based on the given location (and no objects) | 
| [ActionInfo](./ActionInfo.md) | FromObjectGeneric ( [`Person`](./../Objects/Person.md), [`MapObject`](./../Objects/MapObject.md) ) | Returns a new `TinyLife.Actions.ActionInfo` basd on the given object, but no object spot | 


