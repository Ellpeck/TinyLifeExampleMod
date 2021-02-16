# [GameImpl](./GameImpl.md)

Namespace: [TinyLife]()

Assembly: Tiny Life.dll

Implements [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable)

## Summary
The main class for Tiny Life, which houses a set of important game-wide properties.

## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan) | CurrentTime | The current in-game total time since the start of the game. | 
| [Person](./Objects/Person.md) | FollowingPerson | The `TinyLife.Objects.Person` that the camera is currently locked onto | 


## Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [Camera](./GameImpl.md) | Camera | The game's in-world camera, created in `TinyLife.GameImpl.LoadContent` | 
| [Household](./World/Household.md) | CurrentHousehold | The household that is currently being played, or <code>null</code> if in the main menu, editing a lot or on the map select screen | 
| [Lot](./World/Lot.md) | CurrentLot | The lot that is currently being played on or edited, or <code>null</code> if in the main menu or on the map select screen | 
| [Tool](./Tools/Tool.md) | CurrentTool | The `TinyLife.Tools.Tool` that is currently selected. Should always be set to either `TinyLife.Tools.Tool.PlayModeTool` or any of `TinyLife.Tools.Tool.BuildTools`. | 
| [GraphicsMetrics](./GameImpl.md) | GraphicsMetrics | The game's graphics metrics, gathered at the end of every `TinyLife.GameImpl.DoDraw(Microsoft.Xna.Framework.GameTime)` call | 
| [AudioListener](./GameImpl.md) | Listener | The game's `Microsoft.Xna.Framework.Audio.AudioListener` that is automatically moved to the `TinyLife.GameImpl.Camera`'s position | 
| [Map](./World/Map.md) | Map | The map that the game is currently on, or <code>null</code> if in the main menu | 
| [GameMode](./GameImpl.md) | Mode | The `TinyLife.GameImpl.GameMode` that is currently active | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | Money | The money that the `TinyLife.GameImpl.CurrentHousehold` has, or `System.Single.MaxValue` if there is no active household | 
| [String](https://docs.microsoft.com/en-us/dotnet/api/System.String) | SaveName | The name of the save file that is currently being played, or <code>null</code> if in the main menu | 
| [GameSpeed](./GameSpeed.md) | Speed | The current `TinyLife.GameSpeed`.  Note that, if the current speed is `TinyLife.GameSpeed.VeryFast` and the game `TinyLife.GameImpl.CanBeExtremelyFast`, `TinyLife.GameSpeed.ExtremelyFast` is returned. | 
| [DayOfWeek](https://docs.microsoft.com/en-us/dotnet/api/System.DayOfWeek) | Weekday | The current in-game weekday, based on `TinyLife.GameImpl.CurrentTime` | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | CanBeExtremelyFast (  ) | Returns whether the game allows changing the speed to `TinyLife.GameSpeed.ExtremelyFast` at the current time.  If this returns true, and `TinyLife.GameImpl.Speed` is set to `TinyLife.GameSpeed.VeryFast`, the `TinyLife.GameSpeed.ExtremelyFast` speed is automatically engaged. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | CanSaveOrSwitchModes (  ) | Returns whether the game can currently save or if `TinyLife.GameImpl.SwitchGameMode(TinyLife.GameImpl.GameMode)` is allowed to be used right now.  The return value is influenced by `TinyLife.Tools.Tool.CanSaveOrSwitchModes` and `TinyLife.World.Lot.AreRequirementsMet`. | 
| [Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean) | IsMouseOnUi (  ) | Returns true if the mouse is currently on top of any ui element in the `MLEM.Ui.UiSystem` | 
| void | SwitchGameMode ( [`GameMode`](./GameImpl.md) ) |  | 


## Static Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| [GameImpl](./GameImpl.md) | Instance | The game's singleton instance | 


