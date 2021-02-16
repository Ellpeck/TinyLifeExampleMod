# [StaticJsonConverter](./StaticJsonConverter-1.md)\<[T](./StaticJsonConverter-1.md)>

Namespace: [TinyLife]() > [Utilities]()

Assembly: Tiny Life.dll

## Summary
A `Newtonsoft.Json.JsonConverter`1` that doesn't actually serialize the object, but instead serializes the name given to it by the underlying `System.Collections.Generic.Dictionary`2`.

## Constructors

| Name | Summary | 
| --- | --- | 
| StaticJsonConverter ( [`Dictionary`](./StaticJsonConverter-1.md)\<[`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String), [`T`](./StaticJsonConverter-1.md)> ) |  | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [T](./StaticJsonConverter-1.md) | ReadJson ( [`JsonReader`](./StaticJsonConverter-1.md), [`Type`](https://docs.microsoft.com/en-us/dotnet/api/System.Type), [`T`](./StaticJsonConverter-1.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean), [`JsonSerializer`](./StaticJsonConverter-1.md) ) |  | 
| void | WriteJson ( [`JsonWriter`](./StaticJsonConverter-1.md), [`T`](./StaticJsonConverter-1.md), [`JsonSerializer`](./StaticJsonConverter-1.md) ) |  | 


