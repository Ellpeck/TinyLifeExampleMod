# [TinyLifeApi](./README.md)

## Namespaces

### TinyLife

- [`GameImpl`](./TinyLife/GameImpl.md)
	- The main class for Tiny Life, which houses a set of important game-wide properties.
- [`Localization`](./TinyLife/Localization.md)
	- A class that houses the currently loaded language as well as allows for switching the currently selected language
- [`Need`](./TinyLife/Need.md)
	- A need is a desire that a `TinyLife.Objects.Person` can have to a given extent, defined by `TinyLife.Need.Value`.  Each need is instantiated through its associated `TinyLife.NeedType`.
- [`NeedType`](./TinyLife/NeedType.md)
	- A need is a desire that a `TinyLife.Objects.Person` can have to a given extent.  To register a custom need type, use `TinyLife.NeedType.Register(TinyLife.NeedType)`.
- [`Options`](./TinyLife/Options.md)
	- The game's options, which are displayed in the `TinyLife.Uis.Menus.InitializeOptions(MLEM.Ui.UiSystem,System.Boolean,System.Boolean)` menu and saved to disk
- [`PerSaveOptions`](./TinyLife/PerSaveOptions.md)
	- The game's per-save options, which are displayed in the `TinyLife.Uis.Menus.InitializeOptions(MLEM.Ui.UiSystem,System.Boolean,System.Boolean)` menu and saved to disk.  Note that `TinyLife.PerSaveOptions.Instance` is null if there is no `TinyLife.GameImpl.Map` loaded.
- [`PersonalityType`](./TinyLife/PersonalityType.md)
	- A personality type is a trait that a `TinyLife.Objects.Person` can have.  Each personality type is meant to influence the person's behavior and abilities slightly in a certain way.
- [`Relationship`](./TinyLife/Relationship.md)
	- A relationship is a connection between two `TinyLife.Objects.Person` objects.  It should be noted that a relationship is not always the same between a person and the linked `TinyLife.Relationship.OtherPerson`.  What this means is that A can have a good relationship to B, but B can have a less good relationship to A.
### World

- [`Door`](./TinyLife/World/Door.md)
- [`ExportedHousehold`](./TinyLife/World/ExportedHousehold.md)
	- This class represents an exported version of a `TinyLife.World.Household`, storing all of the `TinyLife.World.Map`-independent data.
- [`ExportedLot`](./TinyLife/World/ExportedLot.md)
	- An exported lot is all of the relevant data of a `TinyLife.World.Lot` that should be exported to a file when clicking the "Export" button in the build menu.  To create an exported lot from a lot, use `TinyLife.World.Lot.Export`.
- [`Household`](./TinyLife/World/Household.md)
	- A household is a set of `TinyLife.Objects.Person` instances that live together on the same `TinyLife.World.Household.Lot`
- [`IPricedObject`](./TinyLife/World/IPricedObject.md)
	- A priced object is an object that has a floating point price value attached to it.  In the world of Tiny Life, prices are written as "tiny bucks", but they don't necessarily resemble the prices of the American dollar.
- [`Lot`](./TinyLife/World/Lot.md)
	- A lot is a designated area in the world (created using the `TinyLife.Tools.LotTool`).  In the way it works, it acts similarly to a small `TinyLife.World.Map`, allowing the retrieval of various object types only in its designated area.  A lot has a `TinyLife.World.LotType`, which determines what things can be done on the lot.
- [`LotType`](./TinyLife/World/LotType.md)
	- A lot type is data for a `TinyLife.World.Lot` that determines the required furniture on the lot as well as whether the lot is residential or not.  Additionally, custom lot types can define different reasons and interactions for `TinyLife.Objects.Person` objects to visit lots of the type.
- [`Map`](./TinyLife/World/Map.md)
	- A map holds all of the data about a city, like its tiles, its objects and its roads.  A map is split into `TinyLife.World.MapSection` objects which allows faster retrieval of objects in an area.
- [`MapSection`](./TinyLife/World/MapSection.md)
	- A map section is a small area in a `TinyLife.World.MapSection.Map` that actually contains the area's objects.  A map section is always `TinyLife.World.MapSection.Size`x`TinyLife.World.MapSection.Size` tiles large.
- [`Opening`](./TinyLife/World/Opening.md)
	- An opening is some sort of extrusion in a `TinyLife.World.Wall`, like a window or a door.  Openings are created from their underlying `TinyLife.World.OpeningType`.
- [`OpeningType`](./TinyLife/World/OpeningType.md)
	- An opening is some sort of extrusion in a `TinyLife.World.Wall`, like a window or a door.  An opening type stores data that can be used to construct a `TinyLife.World.Opening` instance.
- [`Roof`](./TinyLife/World/Roof.md)
	- A roof is an object on a `TinyLife.World.Map` that is on a higher level and cannot be interacted with by people
- [`Room`](./TinyLife/World/Room.md)
	- A room is an area on a `TinyLife.World.Room.Map` that is surrounded by `TinyLife.World.Wall` objects
- [`Tile`](./TinyLife/World/Tile.md)
	- A tile is an object on a `TinyLife.World.Map` that represents the covering of the ground (or the ground itself)
- [`Wall`](./TinyLife/World/Wall.md)
	- A wall is an element of a `TinyLife.World.Map` that stops traversal and that has a `TinyLife.World.Wallpaper` and optionally an `TinyLife.World.Wall.Opening` attached to it.
- [`Wallpaper`](./TinyLife/World/Wallpaper.md)
	- A wallpaper is a single-instanced object that can be attached to a `TinyLife.World.Wall`, which makes the wall render a different texture.  To register custom wallpapers, use `TinyLife.World.Wallpaper.Register(System.String,System.Int32,MLEM.Textures.UniformTextureAtlas,Microsoft.Xna.Framework.Point,TinyLife.Utilities.ColorScheme,MLEM.Textures.TextureRegion)`. Note that registered wallpapers need to use a texture generated by `TinyLife.Utilities.TextureHandler.ApplyWallpaperMasks(Microsoft.Xna.Framework.Graphics.Texture2D,System.Int32,System.Int32,System.Action{MLEM.Textures.UniformTextureAtlas})`.
### Utilities

- [`ColorScheme`](./TinyLife/Utilities/ColorScheme.md)
	- A color scheme is a list of `Microsoft.Xna.Framework.Color` instances with which an object can be colored.  By default, a set of color schemes exist (defined in this class), but new ones can be created easily using `TinyLife.Utilities.ColorScheme.Create(System.Object[])`.
- [`Extensions`](./TinyLife/Utilities/Extensions.md)
	- A set of extensions for dealing with various things required by Tiny Life.
- [`StaticJsonConverter`](./TinyLife/Utilities/StaticJsonConverter-1.md)\<[`T`](./README.md)>
	- A `Newtonsoft.Json.JsonConverter`1` that doesn't actually serialize the object, but instead serializes the name given to it by the underlying `System.Collections.Generic.Dictionary`2`.
- [`TextureHandler`](./TinyLife/Utilities/TextureHandler.md)
	- The texture handler stores data for the game's textures, including all of the game's internal textures and various utility methods.  It also stores the game's `MLEM.Data.RuntimeTexturePacker` which is used to pack all textures into a big texture for performance.
### Uis

- [`CharacterCreator`](./TinyLife/Uis/CharacterCreator.md)
	- The character creator is displayed when a person (or household) is being edited in terms of their `TinyLife.Objects.Clothes` and `TinyLife.PersonalityType`s.
- [`Cursor`](./TinyLife/Uis/Cursor.md)
	- The Cursor class contains ways to change the `Microsoft.Xna.Framework.Input.MouseCursor` visuals to different `TinyLife.Uis.CursorType` values
- [`Notifications`](./TinyLife/Uis/Notifications.md)
	- This class holds information about the current and past notifications that are displayed in the top center of the screen.  To create custom notifications, use `TinyLife.Uis.Notifications.Add(TinyLife.Objects.MapObject,System.String)` or `TinyLife.Uis.Notifications.Add(MLEM.Textures.TextureRegion,System.String)`.
### Tools

- [`FurniturePlacer`](./TinyLife/Tools/FurniturePlacer.md)
	- A helper class that represents a tool part which allows the placement and movement of furniture objects.  This class is used by `TinyLife.Tools.FurnitureTool` and `TinyLife.Tools.MoveTool`.
- [`FurnitureTool`](./TinyLife/Tools/FurnitureTool.md)
- [`LotTool`](./TinyLife/Tools/LotTool.md)
- [`MoveLotTool`](./TinyLife/Tools/MoveLotTool.md)
- [`MoveTool`](./TinyLife/Tools/MoveTool.md)
- [`OpeningTool`](./TinyLife/Tools/OpeningTool.md)
- [`PlayModeTool`](./TinyLife/Tools/PlayModeTool.md)
- [`RemoveTool`](./TinyLife/Tools/RemoveTool.md)
- [`RoofTool`](./TinyLife/Tools/RoofTool.md)
- [`TileTool`](./TinyLife/Tools/TileTool.md)
- [`Tool`](./TinyLife/Tools/Tool.md)
	- A tool is a type of game mode that is currently active.  Tools are split up into the `TinyLife.Tools.Tool.PlayModeTool` and `TinyLife.Tools.Tool.BuildTools`, the latter of which holds all tools that can be found in the build menu.
- [`WallpaperTool`](./TinyLife/Tools/WallpaperTool.md)
- [`WallTool`](./TinyLife/Tools/WallTool.md)
### Skills

- [`FoodType`](./TinyLife/Skills/FoodType.md)
	- A food type is a type of dish that can be cooked using `TinyLife.Actions.ActionType.GetIngredients`.  Food types store information such as their name and texture, but also the cooking level that is required to make them.  Food types are registered using `TinyLife.Skills.FoodType.Register(TinyLife.Skills.FoodType)`.
- [`PaintingType`](./TinyLife/Skills/PaintingType.md)
	- This class represents a type of `TinyLife.Objects.Painting` that can be created using the `TinyLife.Skills.SkillType.Painting`.  Painting types are registered using `TinyLife.Skills.PaintingType.Register(TinyLife.Skills.PaintingType)`.
- [`Skill`](./TinyLife/Skills/Skill.md)
	- A skill is an ability that a `TinyLife.Objects.Person` can have which influences their behavior in some way.  Skill instances are created from their corresponding `TinyLife.Skills.SkillType`.
- [`SkillType`](./TinyLife/Skills/SkillType.md)
	- A skill is an ability that a `TinyLife.Objects.Person` can have which influences their behavior in some way.  The SkillType class contains underlying data for a `TinyLife.Skills.Skill` instance, like its name and maximum level.
### Objects

- [`AbstractSpot`](./TinyLife/Objects/AbstractSpot.md)
	- An `TinyLife.Objects.AbstractSpot` is a base class for `TinyLife.Objects.ObjectSpot` and `TinyLife.Objects.ActionSpot`.
- [`ActionSpot`](./TinyLife/Objects/ActionSpot.md)
	- An action spot is a `TinyLife.Objects.AbstractSpot` extension that is used by `TinyLife.Objects.Furniture` to declare a location that a `TinyLife.Objects.Person` can interact with the furniture at
- [`BreakableFurniture`](./TinyLife/Objects/BreakableFurniture.md)
	- Breakable furniture is `TinyLife.Objects.Furniture` that can be `TinyLife.Objects.BreakableFurniture.Broken` and then repaired.  An object of this class is automatically returned in `TinyLife.Objects.FurnitureType.Construct(System.Int32[],TinyLife.World.Map,Microsoft.Xna.Framework.Vector2,System.Nullable{System.Guid})` if no `TinyLife.Objects.FurnitureType.TypeSettings.ConstructedType` is set.
- [`Car`](./TinyLife/Objects/Car.md)
- [`Clothes`](./TinyLife/Objects/Clothes.md)
	- A set of information and a registry for clothing items (and hair) that a `TinyLife.Objects.Person` can wear.  Custom clothes can be registered using `TinyLife.Objects.Clothes.Register(TinyLife.Objects.Clothes)`.
- [`CornerFurniture`](./TinyLife/Objects/CornerFurniture.md)
	- Corner furniture is furniture like `TinyLife.Objects.FurnitureType.SimpleCounter` and `TinyLife.Objects.FurnitureType.Hedge` that automatically connect to their neighbors
- [`Fence`](./TinyLife/Objects/Fence.md)
	- A fence is a furniture used by things like `TinyLife.Objects.FurnitureType.CountryFence` that auto-connects similarly to `TinyLife.Objects.CornerFurniture`, but by actually adding additional connection textures onto the regular object textures
- [`Food`](./TinyLife/Objects/Food.md)
- [`FoodTypedItem`](./TinyLife/Objects/FoodTypedItem.md)
- [`Furniture`](./TinyLife/Objects/Furniture.md)
	- A furniture is an instance of a `TinyLife.Objects.FurnitureType` which is placed in the world, or in a `TinyLife.Objects.Person`'s hand.  To register a custom furniture, use `TinyLife.Objects.FurnitureType.Register(TinyLife.Objects.FurnitureType.TypeSettings)`.
- [`FurnitureType`](./TinyLife/Objects/FurnitureType.md)
	- A furniture type is basically a blueprint for `TinyLife.Objects.Furniture` objects.  Each furniture type can create a furniture instance and the type's data will be transferred to the instance.  Furniture types are automatically listed in the `TinyLife.Tools.FurnitureTool` if registered using `TinyLife.Objects.FurnitureType.Register(TinyLife.Objects.FurnitureType.TypeSettings)`.
- [`Gravestone`](./TinyLife/Objects/Gravestone.md)
- [`IUpdatingObject`](./TinyLife/Objects/IUpdatingObject.md)
	- This is an interface that can be added to `TinyLife.Objects.MapObject` classes to make them automatically update each update frame.  This is used by things like `TinyLife.Objects.Person`, which needs to update for movement etc.
- [`MapObject`](./TinyLife/Objects/MapObject.md)
	- An instance of this class represents an object that can be, or is, part of a `TinyLife.Objects.MapObject.Map`.  If this object's `TinyLife.Objects.MapObject.Position` is set to -1, -1, that is usually an indicator that the object is currently not in the world.
- [`ObjectSpot`](./TinyLife/Objects/ObjectSpot.md)
	- An object spot is a `TinyLife.Objects.AbstractSpot` extension that is used by `TinyLife.Objects.Furniture` to declare a location that another `TinyLife.Objects.Furniture` object can be slotted into.  This behavior is used for things like plates on counters, flower pots on bedside tables etc.
- [`Painting`](./TinyLife/Objects/Painting.md)
- [`Particle`](./TinyLife/Objects/Particle.md)
	- A particle is a `MLEM.Animations.SpriteAnimation` that can be moved and displayed in world space.  A particle is simply a `TinyLife.Objects.MapObject` that does not collide or interact directly with the world, but has all of the same properties.  A new particle can be added for display using `TinyLife.Objects.Particle.Spawn(TinyLife.Objects.Particle)`.
- [`Person`](./TinyLife/Objects/Person.md)
	- A person is a `TinyLife.Objects.MapObject` placed on a `TinyLife.World.Map` that represents a person.  It stores its actions, clothes, data and movement.
- [`PersonAi`](./TinyLife/Objects/PersonAi.md)
	- This class holds the artificial intelligence implementation for a `TinyLife.Objects.Person`.  The AI automatically selects actions based on their `TinyLife.Actions.ActionType.AiSettings`.
- [`ScreenObject`](./TinyLife/Objects/ScreenObject.md)
- [`WornClothes`](./TinyLife/Objects/WornClothes.md)
	- WornClothes is a wrapper around `TinyLife.Objects.Clothes` that additionally stores the colors and whether or not the clothes are from the `TinyLife.World.Household.ClothesStorage` or not
### Mods

- [`Events`](./TinyLife/Mods/Events.md)
	- A set of events that can be subscribed to by mods to allow for special handling of certain situations.  To have more events added to this list if they're required by your mods, please reach out to Ellpeck.  Note that, for events that use an `TinyLife.Mods.EventPhase`, the subscriber needs to make sure that the code only runs for one of the phases, and not both, by checking the current phase.
- [`Mod`](./TinyLife/Mods/Mod.md)
	- The base class for all Tiny Life mods.  For an example mod, see <see href="https://github.com/Ellpeck/TinyLifeExampleMod" />.  Mods are uniquely identified by their ID. The id is the name of the class that extends `TinyLife.Mods.Mod`.
- [`ModInfo`](./TinyLife/Mods/ModInfo.md)
	- A mod info is a set of properties that every `TinyLife.Mods.ModInfo.Mod` instance is assigned
- [`ModLoader`](./TinyLife/Mods/ModLoader.md)
	- The mod loader loads `TinyLife.Mods.Mod` instances from the `TinyLife.Mods.ModLoader.GetModsFolder`.
### Goals

- [`Job`](./TinyLife/Goals/Job.md)
	- A job is a kind of work that a `TinyLife.Goals.Job.Person` can have.  The person's current job is accessible using `TinyLife.Objects.Person.Job`.  A job instance is constructed from its underlying `TinyLife.Goals.JobType`.
- [`JobType`](./TinyLife/Goals/JobType.md)
	- A job type is a singleton containing various kinds of data for a `TinyLife.Goals.Job` instance.  New jobs can be registered using `TinyLife.Goals.JobType.Register(TinyLife.Goals.JobType)`.
### Emotions

- [`EmotionModifier`](./TinyLife/Emotions/EmotionModifier.md)
	- An emotion modifier stores information about a `TinyLife.Objects.Person`'s current or past actions or events that influenced their `TinyLife.Objects.Person.Emotion` in some way.  Each emotion modifier contributes to the person's emotion, and the emotion modifier with the highest combined `TinyLife.Emotions.EmotionModifier.Instance.Amount` determines the person's `TinyLife.Objects.Person.Emotion`.  Emotion modifiers can be applied automatically using `TinyLife.Emotions.EmotionModifier.Condition` or manually using `TinyLife.Objects.Person.AddEmotion(TinyLife.Emotions.EmotionModifier,System.Int32,System.TimeSpan)`.
- [`EmotionType`](./TinyLife/Emotions/EmotionType.md)
	- An emotion type is a type of feeling that a `TinyLife.Objects.Person` can have.  The emotion that a person has results from that person's applied `TinyLife.Emotions.EmotionModifier``TinyLife.Emotions.EmotionModifier.Instance`s.
### Actions

- [`Action`](./TinyLife/Actions/Action.md)
	- An action is something that a `TinyLife.Objects.Person` does.  An action is always derived from an underlying `TinyLife.Actions.ActionType` that contains various action settings.  Actions can be queued up for a person (`TinyLife.Objects.Person.ActionQueue`) or currently active (`TinyLife.Objects.Person.CurrentActions`).  To create a more complex action, it is best to extend `TinyLife.Actions.MultiAction`.
- [`ActionInfo`](./TinyLife/Actions/ActionInfo.md)
	- An action info is a set of information that is required to execute an action
- [`ActionType`](./TinyLife/Actions/ActionType.md)
	- Action types are blueprints for `TinyLife.Actions.Action` instances which can be registered using `TinyLife.Actions.ActionType.Register(TinyLife.Actions.ActionType.TypeSettings)`.  An action type contains information about its action and can create an instance using `TinyLife.Actions.ActionType.TypeSettings.Construct`.
- [`ActionVariety`](./TinyLife/Actions/ActionVariety.md)
	- An action variety is a modification to a `TinyLife.Actions.ActionType` that represents a slightly changed version of the generic action type.  Action varieties are used, for example, by `TinyLife.Actions.ActionType.PrepareFood` to determine the kind of food that should be prepared.
- [`ComputerAction`](./TinyLife/Actions/ComputerAction.md)
- [`DriveAction`](./TinyLife/Actions/DriveAction.md)
- [`Emote`](./TinyLife/Actions/Emote.md)
	- An emote is a graphic that can be displayed in a bubble over a `TinyLife.Objects.Person`, usually as part of a conversation.
- [`GetAndSitDownAction`](./TinyLife/Actions/GetAndSitDownAction.md)
- [`GoHereAction`](./TinyLife/Actions/GoHereAction.md)
- [`MultiAction`](./TinyLife/Actions/MultiAction.md)
	- A multi action is an action that can have different actions executed before and/or after itself.  This is quite useful if an action requires a `TinyLife.Objects.Person` to go somewhere to pick up an item etc.
- [`OutOfTownAction`](./TinyLife/Actions/OutOfTownAction.md)
	- An out-of-town action is an action where the `TinyLife.Objects.Person` finds the closest exit road and then exits the city using that road.  Out-of-town actions are things like going to work, where the destination location isn't visible to the player.
- [`PathfindAction`](./TinyLife/Actions/PathfindAction.md)
	- A pathfinding action is an action that first finds a path and then allows that path to be traversed.  The pathfinding is done using `MLEM.Pathfinding.AStar2`.
- [`SellAction`](./TinyLife/Actions/SellAction.md)
- [`SitAction`](./TinyLife/Actions/SitAction.md)
- [`SitAtDeskObjectAction`](./TinyLife/Actions/SitAtDeskObjectAction.md)
- [`SocialAction`](./TinyLife/Actions/SocialAction.md)
	- A social action is an action that involves two `TinyLife.Objects.Person` instances.  Before a social action "actually" starts, both parties have to have the action as their current action.  For this to happen, the person that initiates the action follows the `TinyLife.Actions.SocialAction.Partner` until they reach them (or give up).
- [`TalkAction`](./TinyLife/Actions/TalkAction.md)
	- TalkAction is a generic social action with a set of pre-defined parameters.  Things like `TinyLife.PersonalityType` and `TinyLife.Skills.SkillType.Charisma` automatically influence this interaction's `TinyLife.Actions.TalkAction.TalkSettings.FriendshipGain` and `TinyLife.Actions.TalkAction.TalkSettings.GoBadlyChance`.  `TinyLife.Actions.TalkAction.Create(System.String,System.Func{TinyLife.Objects.Person,System.Int32},TinyLife.Actions.TalkAction.TalkSettings)` should be used to create a talk action.
- [`TellPeopleToLeaveRoomAction`](./TinyLife/Actions/TellPeopleToLeaveRoomAction.md)
- [`UnderlyingAction`](./TinyLife/Actions/UnderlyingAction.md)
	- An UnderlyingAction is a class that can instantiate a single `TinyLife.Actions.UnderlyingAction.Action` that will be executed as part of the action it is used in.  Note that, when using this class, `TinyLife.Actions.UnderlyingAction.Update(Microsoft.Xna.Framework.GameTime,System.TimeSpan,TinyLife.GameSpeed)` and `TinyLife.Actions.UnderlyingAction.Validate(TinyLife.Objects.Person)` have to be called in the appropriate places.
- [`WalkAction`](./TinyLife/Actions/WalkAction.md)

