# [IPricedObject](./IPricedObject.md)

Namespace: [TinyLife]() > [World]()

Assembly: Tiny Life.dll

## Summary
A priced object is an object that has a floating point price value attached to it.  In the world of Tiny Life, prices are written as "tiny bucks", but they don't necessarily resemble the prices of the American dollar.

## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | GetPrice (  ) | Returns the price that this object can be bought or sold for.  Note that, like in the case of the `TinyLife.Objects.Painting`, the returned price isn't necessarily the full price that the object can be sold for. Instead, the price returned here should be the price that this object has when bought or sold from the `TinyLife.Tools.FurnitureTool` or similar. | 


