# [Tool](./Tool.md)

Namespace: [TinyLife]() > [Tools]()

Assembly: Tiny Life.dll

## Summary
A tool is a type of game mode that is currently active.  Tools are split up into the `TinyLife.Tools.Tool.PlayModeTool` and `TinyLife.Tools.Tool.BuildTools`, the latter of which holds all tools that can be found in the build menu.

## Constructors

| Name | Summary | 
| --- | --- | 
| Tool ( [`TextureRegion`](./Tool.md), [`Boolean`](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) ) | Creates a new tool with the given settings | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | DisplayAsTab | Whether or not this tool should be displayed as a tab (like the `TinyLife.Tools.Tool.RemoveTool`) or a button in the build menu | 
| [TextureRegion](./Tool.md) | Texture | The texture region that should be used to display this tool in the build menu | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | CanSaveOrSwitchModes (  ) | Whether or not the game `TinyLife.GameImpl.CanSaveOrSwitchModes` currently, while this tool is selected | 
| void | Closed (  ) | Called when this build tool is closed.  By default, this method removes its elements from the ui. | 
| void | Draw ( [`GameTime`](./Tool.md), [`SpriteBatch`](./Tool.md) ) | This method is called every draw frame for the `TinyLife.GameImpl.CurrentTool`.  Note that this method is only called if the mouse is not hovering over any ui elements. | 
| [Nullable](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[WallDisplay](./../WallDisplay.md)> | ForceWallsUp (  ) | Returns whether the `TinyLife.WallDisplay` should be forcibly changed by this tool.  If it shouldn't be changed, null should be returned. Otherwise, the required `TinyLife.WallDisplay` should be returned. | 
| [CursorType](./../Uis/CursorType.md) | GetMouseCursor (  ) | Returns the `TinyLife.Uis.CursorType` that this tool should currently display.  By default, `TinyLife.Uis.CursorType.Default` is returned. | 
| void | Opened (  ) | Called when this build tool is opened.  By default, this method initializes several settings and calls `TinyLife.Tools.Tool.InitBuildModeUi(MLEM.Ui.Elements.Panel,MLEM.Ui.Elements.Panel)`. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | ShouldHighlightSelectedObject (  ) | Whether or not the `TinyLife.Tools.Tool.SelectedObject` should currently have a white highlight around it.  This method defaults to return true if `TinyLife.GameImpl.IsMouseOnUi` is false. | 
| void | Update ( [`GameTime`](./Tool.md) ) | This method is called every update frame for the `TinyLife.GameImpl.CurrentTool`. | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1)\<[Tool](./Tool.md)> | BuildTools | A set of `TinyLife.Tools.Tool` instances that can be activated using the build mode menu.  All tools in this list are automatically added to the menu. | 
| [MoveTool](./MoveTool.md) | MoveTool | The `TinyLife.Tools.Tool.MoveTool` singleton | 
| [PlayModeTool](./PlayModeTool.md) | PlayModeTool | The `TinyLife.Tools.Tool.PlayModeTool` singleton, which is activated when build mode is inactive. | 
| [RemoveTool](./RemoveTool.md) | RemoveTool | The `TinyLife.Tools.Tool.RemoveTool` singleton, which is activated using the Remove tab in the build menu or by holding the control key. | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Button](./Tool.md) | BuildModeButton ( [`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String), [`GenericCallback`](./Tool.md), [`DrawCallback`](./Tool.md), [`Single`](https://docs.microsoft.com/en-us/dotnet/api/System.Single), [`TextureRegion`](./Tool.md), [`LnCategory`](./../LnCategory.md), [`IEnumerable`](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1)\<[`String`](https://docs.microsoft.com/en-us/dotnet/api/System.String)> ) |  | 
| [Group](./Tool.md) | ColorSelection ( [`ColorScheme`](./../Utilities/ColorScheme.md), [`Action`](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1)\<[`Int32`](https://docs.microsoft.com/en-us/dotnet/api/System.Int32)> ) | Creates a new `MLEM.Ui.Elements.Group` that resembles a set of color selection buttons.  This is used by `TinyLife.Uis.CharacterCreator`, as well as tools like the `TinyLife.Tools.FurnitureTool`. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | IsOnLot ( [`Point`](./Tool.md) ) | Returns whether or not the passed position is on the currently edited lot (`TinyLife.GameImpl.CurrentLot`) | 


