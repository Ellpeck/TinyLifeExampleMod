# [Options](./Options.md)

Namespace: [TinyLife]()

Assembly: Tiny Life.dll

## Summary
The game's options, which are displayed in the `TinyLife.Uis.Menus.InitializeOptions(MLEM.Ui.UiSystem,System.Boolean,System.Boolean)` menu and saved to disk

## Constructors

| Name | Summary | 
| --- | --- | 
| Options (  ) |  | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32) | AutoSaveIntervalSeconds | The auto-save interval in seconds.  Note that this value should be set to 30, 60, 180, 300 or 600, as otherwise, the options menu will display it incorrectly. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | Fullscreen | Whether the game is currently in fullscreen mode | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | Language | The currently selected language's language code.  Determines the language used by `TinyLife.Localization`. | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | SoundVolume | The current sound volume as a percentage, ranging from 0 to 1 | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | UiScale | A modifier that is applied to the game's `MLEM.Ui.UiSystem`'s `MLEM.Ui.UiSystem.GlobalScale` | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | VSync | Whether vertical synchronization is currently turned on | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [WallDisplay](./WallDisplay.md) | WallMode | The currently selected `TinyLife.Options.WallMode`.  Note that this value does not always return the wall mode that has been selected by the user:  If `TinyLife.GameImpl.Mode` is `TinyLife.GameImpl.GameMode.SelectHousehold`, `TinyLife.WallDisplay.Roofs` is returned.  If the `TinyLife.GameImpl.CurrentTool` overrides `TinyLife.Tools.Tool.ForceWallsUp`, that value is returned. | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Apply (  ) | Applies the currently selected options of this instance to the game | 
| void | Save (  ) | Saves the options to the default options file path | 


## Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [GameSpeed](./Options.md)[] | GameSpeeds | An array of all defined `TinyLife.GameSpeed` values | 
| [WallDisplay](./Options.md)[] | WallDisplays | An array of all defined `TinyLife.WallDisplay` values | 


## Static Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [Options](./Options.md) | Instance | The static singleton instance of `TinyLife.Options` | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Load (  ) | Loads the options from the default options file path and stores them in `TinyLife.Options.Instance`.  If there are no options in the default options file, a new instance is created. | 


