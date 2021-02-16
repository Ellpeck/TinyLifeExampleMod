# [Localization](./Localization.md)

Namespace: [TinyLife]()

Assembly: Tiny Life.dll

## Summary
A class that houses the currently loaded language as well as allows for switching the currently selected language

## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Dictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2)\<[String](https://docs.microsoft.com/en-us/dotnet/api/System.String), [String](https://docs.microsoft.com/en-us/dotnet/api/System.String)> | LanguageNames | A list of the full names of all of the languages that the game supports | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | Get ( [`LnCategory`](./LnCategory.md), [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String) ) | Gets a localized string in the given category with the given key.  If the localization is not found, the key, surrounded by question marks, is returned instead. | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | Get ( [`LnCategory`](./LnCategory.md), [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String), [`Object`](https://docs.microsoft.com/en-us/dotnet/api/System.Object)[] ) | Gets a localized string in the given category with the given key.  If the localization is not found, the key, surrounded by question marks, is returned instead. | 
| void | SetLanguage ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String) ) | Switches the current language to the language given.  Note that, for most ui elements to update, they have to be re-created. | 


