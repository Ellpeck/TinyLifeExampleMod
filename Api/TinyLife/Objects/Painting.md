# [Painting](./Painting.md)

Namespace: [TinyLife]() > [Objects]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./Painting.md), [IPricedObject](./../World/IPricedObject.md)


## Constructors

| Name | Summary | 
| --- | --- | 
| Painting ( [`Guid`](https://docs.microsoft.com/en-us/dotnet/api/System.Guid), [`FurnitureType`](./FurnitureType.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)[], [`Map`](./../World/Map.md), [`Vector2`](./Painting.md) ) |  | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Guid](https://docs.microsoft.com/en-us/dotnet/api/System.Guid) | Creator | The `System.Guid` of the `TinyLife.Objects.Person` that created, and is painting this painting.  This value defaults to `System.Guid.Empty`, meaning no creator. | 
| [PaintingType](./../Skills/PaintingType.md) | PaintingType | The type of painting that this object displays | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | Progress | The progress that has been done on this painting by the `TinyLife.Objects.Painting.Creator` so far.  This value defaults to 1, which is 100%. | 
| [Quality](./../Skills/Quality.md) | Quality | The `TinyLife.Objects.Painting.Quality` that this painting has.  This value default to `TinyLife.Skills.Quality.Average`, but may be different if there is a `TinyLife.Objects.Painting.Creator`. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Draw ( [`GameTime`](./Painting.md), [`SpriteBatch`](./Painting.md), [`Vector2`](./Painting.md), [`Vector2`](./Painting.md), [`Nullable`](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[`Color`](./Painting.md)>, [`Direction2`](./Painting.md), [`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)[], [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean), [`Furniture`](./Furniture.md), [`ObjectSpot`](./ObjectSpot.md), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) |  | 
| [Tooltip](./Painting.md) | GetHoverInfo (  ) |  | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | Validate (  ) |  | 


