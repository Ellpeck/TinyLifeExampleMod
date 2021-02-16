# [PerSaveOptions](./PerSaveOptions.md)

Namespace: [TinyLife]()

Assembly: Tiny Life.dll

## Summary
The game's per-save options, which are displayed in the `TinyLife.Uis.Menus.InitializeOptions(MLEM.Ui.UiSystem,System.Boolean,System.Boolean)` menu and saved to disk.  Note that `TinyLife.PerSaveOptions.Instance` is null if there is no `TinyLife.GameImpl.Map` loaded.

## Constructors

| Name | Summary | 
| --- | --- | 
| PerSaveOptions (  ) |  | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | DisableAiHousehold | Whether the AI of everyone in the `TinyLife.GameImpl.CurrentHousehold` should be disabled or not | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | DisableAiSelected | Whether the AI of the `TinyLife.Tools.PlayModeTool.SelectedPerson` should be disabled or not | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Save ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String) ) |  | 


## Static Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [PerSaveOptions](./PerSaveOptions.md) | Instance | The static singleton instance of `TinyLife.PerSaveOptions`.  Note that this value is null if there is no `TinyLife.GameImpl.Map` loaded. | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Load ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String) ) |  | 


