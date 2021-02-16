# [IUpdatingObject](./IUpdatingObject.md)

Namespace: [TinyLife]() > [Objects]()

Assembly: Tiny Life.dll

## Summary
This is an interface that can be added to `TinyLife.Objects.MapObject` classes to make them automatically update each update frame.  This is used by things like `TinyLife.Objects.Person`, which needs to update for movement etc.

## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Update ( [`GameTime`](./IUpdatingObject.md), [`TimeSpan`](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan), [`GameSpeed`](./../GameSpeed.md) ) | The update method, which is called every update frame by the underlying `TinyLife.World.Map` | 


