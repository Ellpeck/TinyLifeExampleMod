# [Car](./Car.md)

Namespace: [TinyLife]() > [Objects]()

Assembly: Tiny Life.dll

Implements [IGenericDataHolder](./Car.md), [IUpdatingObject](./IUpdatingObject.md)


## Constructors

| Name | Summary | 
| --- | --- | 
| Car ( [`Guid`](https://docs.microsoft.com/en-us/dotnet/api/System.Guid), [`Map`](./../World/Map.md), [`Vector2`](./Car.md) ) |  | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Guid](https://docs.microsoft.com/en-us/dotnet/api/System.Guid) | Driver | The id of the person driving the car | 
| [Direction2](./Car.md) | Rotation | The rotation that this car has | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Draw ( [`GameTime`](./Car.md), [`SpriteBatch`](./Car.md), [`Vector2`](./Car.md), [`Nullable`](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[`Color`](./Car.md)> ) |  | 
| void | Update ( [`GameTime`](./Car.md), [`TimeSpan`](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan), [`GameSpeed`](./../GameSpeed.md) ) |  | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | Validate (  ) |  | 


