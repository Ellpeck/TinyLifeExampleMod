# [Need](./Need.md)

Namespace: [TinyLife]()

Assembly: Tiny Life.dll

## Summary
A need is a desire that a `TinyLife.Objects.Person` can have to a given extent, defined by `TinyLife.Need.Value`.  Each need is instantiated through its associated `TinyLife.NeedType`.

## Constructors

| Name | Summary | 
| --- | --- | 
| Need ( [`NeedType`](./NeedType.md) ) | Instantiate a new need from the given `TinyLife.NeedType` | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [NeedType](./NeedType.md) | Type | The `TinyLife.NeedType` that this need instance originates from | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | Percentage | The `TinyLife.Need.Value` divided by `TinyLife.Need.Max`, yielding a floating point number between 0 and 1, representing the percentage fullness of this need | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | Value | The current value of this need.  Automatically gets clamped to a number between 0 and `TinyLife.Need.Max`. | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | Max | The maximum value that the `TinyLife.Need.Value` can have | 


