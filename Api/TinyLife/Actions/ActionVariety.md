# [ActionVariety](./ActionVariety.md)

Namespace: [TinyLife]() > [Actions]()

Assembly: Tiny Life.dll

## Summary
An action variety is a modification to a `TinyLife.Actions.ActionType` that represents a slightly changed version of the generic action type.  Action varieties are used, for example, by `TinyLife.Actions.ActionType.PrepareFood` to determine the kind of food that should be prepared.

## Constructors

| Name | Summary | 
| --- | --- | 
| ActionVariety ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String) ) | Creates a new action variety with the given name | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [CanExecuteDelegate](./ActionVariety.md) | CanExecute | A function that returns whether or not this action variety can currently be chosen.  This is an extension of `TinyLife.Actions.ActionType.TypeSettings.CanExecute` | 
| [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1)\<[String](https://docs.microsoft.com/en-us/dotnet/api/System.String)> | Description | A function that is called to describe this action variety in more detail.  This is used in the menu that pops up when the underlying `TinyLife.Actions.ActionType` is picked. | 
| [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1)\<[String](https://docs.microsoft.com/en-us/dotnet/api/System.String)> | DisplayName | A function that is called to describe this action variety.  This is used in the menu that pops up when the underlying `TinyLife.Actions.ActionType` is picked. | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | Name | The name of this action variety | 
| [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2)\<[Person](./../Objects/Person.md), [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)> | PassivePriority | A function that returns the passive priority of this action variety.  This is an extension of `TinyLife.Actions.ActionType.AiSettings.PassivePriority` | 


