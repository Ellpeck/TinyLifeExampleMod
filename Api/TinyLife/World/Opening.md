# [Opening](./Opening.md)

Namespace: [TinyLife]() > [World]()

Assembly: Tiny Life.dll

Implements [IPricedObject](./IPricedObject.md)

## Summary
An opening is some sort of extrusion in a `TinyLife.World.Wall`, like a window or a door.  Openings are created from their underlying `TinyLife.World.OpeningType`.

## Constructors

| Name | Summary | 
| --- | --- | 
| Opening ( [`OpeningType`](./OpeningType.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) ) | Creates a new opening from the given opening type and color | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | Color | The index of the `TinyLife.World.OpeningType`'s `TinyLife.World.OpeningType.ColorScheme` that this opening instance has | 
| [OpeningType](./OpeningType.md) | Type | The `TinyLife.World.OpeningType` that this opening has | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | CanWalkThrough (  ) | Returns whether a `TinyLife.Objects.Person` is able to walk through a `TinyLife.World.Wall` that has this opening.  This returns true for `TinyLife.World.Door` and false for `TinyLife.World.Opening`. | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | GetPrice (  ) |  | 


