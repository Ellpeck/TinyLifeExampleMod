# [Notifications](./Notifications.md)

Namespace: [TinyLife]() > [Uis]()

Assembly: Tiny Life.dll

## Summary
This class holds information about the current and past notifications that are displayed in the top center of the screen.  To create custom notifications, use `TinyLife.Uis.Notifications.Add(TinyLife.Objects.MapObject,System.String)` or `TinyLife.Uis.Notifications.Add(MLEM.Textures.TextureRegion,System.String)`.

## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Add ( [`MapObject`](./../Objects/MapObject.md), [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String) ) | Adds a new notification related to the given map object.  The passed object is also the one that will be displayed in the notification. | 
| void | Add ( [`TextureRegion`](./Notifications.md), [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String) ) | Adds a new notification related to nothing.  The passed icon is displayed instead of an object. | 


