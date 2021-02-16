# [Events](./Events.md)

Namespace: [TinyLife]() > [Mods]()

Assembly: Tiny Life.dll

## Summary
A set of events that can be subscribed to by mods to allow for special handling of certain situations.  To have more events added to this list if they're required by your mods, please reach out to Ellpeck.  Note that, for events that use an `TinyLife.Mods.EventPhase`, the subscriber needs to make sure that the code only runs for one of the phases, and not both, by checking the current phase.

## Static Events

| Type | Name | Summary | 
| --- | --- | --- | 
| [DrawEvent](./Events.md)\<[MapObject](./../Objects/MapObject.md)> | MapObjectDraw | An event that is invoked when a `TinyLife.Objects.MapObject` is being drawn (in `TinyLife.World.Map.Draw(Microsoft.Xna.Framework.GameTime,Microsoft.Xna.Framework.Graphics.SpriteBatch,System.Boolean)`) | 
| [UpdateEvent](./Events.md)\<[MapObject](./../Objects/MapObject.md)> | MapObjectUpdate | An event that is invoked when a `TinyLife.Objects.MapObject` is updated (in `TinyLife.World.MapSection.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)`) | 
| [UpdateEvent](./Events.md)\<[Map](./../World/Map.md)> | MapUpdate | An event that is invoked when a `TinyLife.World.Map` is updated (in `TinyLife.World.Map.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)`) | 


