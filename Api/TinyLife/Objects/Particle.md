# [Particle](./Particle.md)

Namespace: [TinyLife]() > [Objects]()

Assembly: Tiny Life.dll

## Summary
A particle is a `MLEM.Animations.SpriteAnimation` that can be moved and displayed in world space.  A particle is simply a `TinyLife.Objects.MapObject` that does not collide or interact directly with the world, but has all of the same properties.  A new particle can be added for display using `TinyLife.Objects.Particle.Spawn(TinyLife.Objects.Particle)`.

## Constructors

| Name | Summary | 
| --- | --- | 
| Particle ( [`TextureRegion`](./Particle.md), [`TimeSpan`](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan), [`Vector2`](./Particle.md) ) | Creates a new particle with the given settings | 
| Particle ( [`SpriteAnimation`](./Particle.md), [`TimeSpan`](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan), [`Vector2`](./Particle.md) ) | Creates a new particle with the given settings | 


## Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| [Easing](./Particle.md) | Alpha | An `MLEM.Misc.Easings.Easing` that determines how this particle's alpha changes based on its `TinyLife.Objects.Particle.TimeToLive` and `TinyLife.Objects.Particle.TimeLived` | 
| [Vector2](./Particle.md) | DepthOffset | The amount of tiles that this particle's depth display calculation is offset by, from its `TinyLife.Objects.Particle.Position` | 
| [Nullable](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single)> | DepthOverride | An optional override for this particle's depth calculations.  If this value is set, it is used as the depth position of this particle, and `TinyLife.Objects.Particle.DepthOffset` is ignored. | 
| [Vector2](./Particle.md) | DrawOffset | The amount of tiles that this particle's display position is offset by, from its `TinyLife.Objects.Particle.Position` | 
| [Vector2](./Particle.md) | Friction | The friction that is applied to this particle's `TinyLife.Objects.Particle.Motion` every `TinyLife.Objects.Particle.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)` frame | 
| [Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single) | Gravity | The amount that this particle's `TinyLife.Objects.Particle.Motion` should be modified by each update frame.  This value only has an effect if `TinyLife.Objects.Particle.GroundLevel` is set. | 
| [Nullable](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1)\<[Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single)> | GroundLevel | An optional y value for the position that this particle should treat as the ground.  If this is set, this particle will have `TinyLife.Objects.Particle.Gravity`. | 
| [Vector2](./Particle.md) | Motion | The amount that this particle's `TinyLife.Objects.Particle.Position` is modified by each `TinyLife.Objects.Particle.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)` frame | 
| [Vector2](./Particle.md) | Position | The position in the world of this particle | 
| [Easing](./Particle.md) | Scale | An `MLEM.Misc.Easings.Easing` that determines how this particle's scale (display size) changes based on its `TinyLife.Objects.Particle.TimeToLive` and `TinyLife.Objects.Particle.TimeLived` | 
| [TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan) | TimeToLive | The amount of real time that this particle should stay alive for until it disappears | 


## Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Draw ( [`GameTime`](./Particle.md), [`SpriteBatch`](./Particle.md), [`Vector2`](./Particle.md) ) | Draws this particle on the current `TinyLife.Objects.Particle.Map`, at the current `TinyLife.Objects.Particle.Position`. | 
| void | Update ( [`GameTime`](./Particle.md), [`TimeSpan`](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan), [`GameSpeed`](./../GameSpeed.md) ) | The update method, which is called every update frame by the underlying `TinyLife.Objects.Particle.Map` | 


## Static Methods

| Return | Name | Summary | 
| --- | --- | --- | 
| void | Spawn ( [`Particle`](./Particle.md) ) | Adds a new particle to the map | 


