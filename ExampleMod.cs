using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using ExtremelySimpleLogger;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MLEM.Data;
using MLEM.Data.Content;
using MLEM.Textures;
using MLEM.Ui;
using MLEM.Ui.Elements;
using TinyLife;
using TinyLife.Actions;
using TinyLife.Emotions;
using TinyLife.Mods;
using TinyLife.Objects;
using TinyLife.Utilities;
using TinyLife.World;
using Action = TinyLife.Actions.Action;

namespace ExampleMod;

public class ExampleMod : Mod {

    // the logger that we can use to log info about this mod
    public static Logger Logger { get; private set; }
    public static ExampleOptions Options { get; private set; }

    public static EmotionModifier GrassSittingModifier { get; private set; }

    // visual data about this mod
    public override string Name => "Example Mod";
    public override string Description => "This is the example mod for Tiny Life!";
    public override TextureRegion Icon => this.uiTextures[new Point(0, 0)];
    public override string IssueTrackerUrl => "https://github.com/Ellpeck/TinyLifeExampleMod/issues";
    public override string TestedVersionRange => "[0.43.0,0.43.10]";

    private Dictionary<Point, TextureRegion> customTops;
    private Dictionary<Point, TextureRegion> customHairs;
    private Dictionary<Point, TextureRegion> customBottoms;
    private Dictionary<Point, TextureRegion> uiTextures;
    private Dictionary<Point, TextureRegion> wallpaperTextures;
    private Dictionary<Point, TextureRegion> tileTextures;

    public override void Initialize(Logger logger, RawContentManager content, RuntimeTexturePacker texturePacker, ModInfo info) {
        ExampleMod.Logger = logger;
        ExampleMod.Options = info.LoadOptions(() => new ExampleOptions());

        // loads a texture atlas with the given amount of separate texture regions in the x and y axes
        // we submit it to the texture packer to increase rendering performance. The callback is invoked once packing is completed
        // additionally, we pad all texture regions by 1 pixel, so that rounding errors during rendering don't cause visual artifacts
        texturePacker.Add(new UniformTextureAtlas(content.Load<Texture2D>("CustomTops"), 4, 11), r => this.customTops = r, 1, true);
        texturePacker.Add(new UniformTextureAtlas(content.Load<Texture2D>("CustomHairs"), 4, 5), r => this.customHairs = r, 1, true);
        texturePacker.Add(new UniformTextureAtlas(content.Load<Texture2D>("CustomBottomsShoes"), 8, 6), r => this.customBottoms = r, 1, true);
        texturePacker.Add(new UniformTextureAtlas(content.Load<Texture2D>("UiTextures"), 8, 8), r => this.uiTextures = r, 1, true);
        texturePacker.Add(new UniformTextureAtlas(content.Load<Texture2D>("Tiles"), 4, 2), r => this.tileTextures = r, 1, true);
        // wallpaper textures require special treatment to work with openings, the x and y values are passed to the UniformTextureAtlas constructor
        WallMode.ApplyMasks(content.Load<Texture2D>("Wallpapers"), 4, 5, texturePacker, r => this.wallpaperTextures = r);
    }

    public override void AddGameContent(GameImpl game, ModInfo info) {
        // adding a custom furniture item
        FurnitureType.Register(new FurnitureType.TypeSettings("ExampleMod.CustomTable", new Point(1, 1), ObjectCategory.Table, 150, ColorScheme.SimpleWood) {
            // specify the type that should be constructed when this furniture type is placed
            // if this is not specified, the  Furniture class is used, which is used for furniture without special animations or data
            ConstructedType = typeof(ExampleTable),
            // specifying icons for custom clothes and furniture is optional, but using the mod's icon helps users recognize a mod's features
            Icon = this.Icon,
            // allow chairs and plates to be slotted into and onto the table
            ObjectSpots = ObjectSpot.TableSpots(new Point(1, 1)).ToArray()
        });

        // adding custom clothing
        var darkShirt = new Clothes("ExampleMod.DarkShirt", ClothesLayer.Shirt,
            // the top left in-world region
            // additional regions will be auto-gathered from the atlas according to the rules described in https://docs.tinylifegame.com/articles/creating_textures.html
            this.customTops, new Point(0, 0),
            // the price
            100,
            // the clothes item's use cases
            ClothesIntention.Everyday | ClothesIntention.Workout,
            // the clothes item's style preferences, which influence randomly generated tinies slightly
            // neutral style preferences have the same chance to be picked for all tinies, others have a 25% chance for mismatched preferences
            StylePreference.Neutral,
            // the clothes item's color scheme
            // if the item should have multiple layers, multiple color schemes can be supplied here (see docs above)
            ColorScheme.WarmDark
        ) {Icon = this.Icon};
        Clothes.Register(darkShirt);
        // adding some more custom clothing
        Clothes.Register(new Clothes("ExampleMod.PastelPants", ClothesLayer.Pants, this.customBottoms, new Point(4, 0), 100, ClothesIntention.Everyday, StylePreference.Neutral, ColorScheme.Pastel) {Icon = this.Icon});
        Clothes.Register(new Clothes("ExampleMod.PastelShoes", ClothesLayer.Shoes, this.customBottoms, new Point(0, 0), 100, ClothesIntention.Everyday, StylePreference.Neutral, ColorScheme.Pastel) {Icon = this.Icon});
        Clothes.Register(new Clothes("ExampleMod.WeirdHair", ClothesLayer.Hair, this.customHairs, new Point(0, 0), 0, ClothesIntention.None, StylePreference.Neutral, ColorScheme.Modern) {Icon = this.Icon});

        // adding an event subscription to people
        MapObject.OnEventsAttachable += o => {
            if (o is Person person) {
                // changing the walk speed to be doubled if a person is wearing our dark shirt
                person.OnGetWalkSpeed += (ref float s) => {
                    if (person.CurrentOutfit.Clothes.TryGetValue(ClothesLayer.Shirt, out var shirt) && shirt.Type == darkShirt)
                        s *= ExampleMod.Options.DarkShirtSpeedIncrease;
                };
            }
        };

        // adding a simple action: sitting down in the grass, which also gives us a nice emotion modifier
        ActionType.Register(new ActionType.TypeSettings("ExampleMod.SitOnGrass", ObjectCategory.Ground, typeof(ExampleGrassSitAction)) {
            // we set this action to be executable only on grass tiles, not on other ground
            CanExecute = (actionInfo, _) => {
                if (!actionInfo.GoalMap.IsInBounds(actionInfo.ActionLocation.ToPoint()))
                    return CanExecuteResult.Hidden;
                var tile = actionInfo.GoalMap.GetTile(actionInfo.ActionLocation.ToPoint(), (int) actionInfo.ActionFloor);
                // hidden means the action won't be displayed in the ring menu, Valid means the player (or AI) is able to enqueue and execute it
                return tile.Name.StartsWith("Grass") ? CanExecuteResult.Valid : CanExecuteResult.Hidden;
            },
            Ai = {
                // we allow the action to be done even if the solved needs aren't low enough on a person
                CanDoRandomly = true,
                // the solved needs indicate when the AI should mark this action as important, they don't actually have to match the action's behavior
                SolvedNeeds = [NeedType.Energy],
                // make people more likely to sit down in the grass if they're uncomfortable
                PassivePriority = p => p.Emotion == EmotionType.Uncomfortable ? 150 : 25
            },
            // since this action doesn't use objects (like chairs etc.), we set a texture to display instead
            Texture = this.uiTextures[new Point(1, 0)]
        });

        // we use this emotion modifier in SitDownOnGrassAction
        ExampleMod.GrassSittingModifier = EmotionModifier.Register(
            new EmotionModifier("ExampleMod.GrassSitting", this.uiTextures[new Point(1, 0)], EmotionType.Happy));

        // adding a custom wallpaper (we're using the top left texture region, which is why we pass 0, 0 as the texture coordinate)
        Wallpaper.Register("ExampleMod.CrossedWallpaper", 15, this.wallpaperTextures, new Point(0, 0), ColorScheme.Modern, this.Icon);

        // adding a custom tile
        Tile.Register("ExampleMod.CustomTile", 8, this.tileTextures, new Point(0, 0), ColorScheme.Bricks, icon: this.Icon);
    }

    public override IEnumerable<string> GetCustomFurnitureTextures(ModInfo info) {
        // tell the game about our custom furniture texture
        // this needs to be a path to a data texture atlas, relative to our "Content" directory
        // the texture atlas combines the png texture and the .atlas information
        // see https://mlem.ellpeck.de/api/MLEM.Data.DataTextureAtlas.html for more info
        yield return "CustomFurniture";
    }

    // this method can be overridden to populate the section in the mod tab of the game's options menu where this mod's options should be displayed
    // this mod uses the ModOptions class to manage its options, though that is optional
    // in general, options should be stored in the ModInfo.OptionsFile file that is given to the mod by the game
    public override void PopulateOptions(Group group, ModInfo info) {
        group.AddChild(new Paragraph(Anchor.AutoLeft, 1, _ => $"{Localization.Get(LnCategory.Ui, "ExampleMod.DarkShirtSpeedOption")}: {ExampleMod.Options.DarkShirtSpeedIncrease}"));
        group.AddChild(new Slider(Anchor.AutoLeft, new Vector2(1, 10), 5, 5) {
            CurrentValue = ExampleMod.Options.DarkShirtSpeedIncrease,
            OnValueChanged = (_, v) => ExampleMod.Options.DarkShirtSpeedIncrease = v
        });
        group.OnRemovedFromUi += _ => info.SaveOptions(ExampleMod.Options);
    }

}

// these options are saved and loaded in ExampleMod
public class ExampleOptions {

    public float DarkShirtSpeedIncrease = 2;

}

// we use a multi action because we want to walk to the location, and then execute the main sitting part
// see ExampleTable for information on how to store custom action-specific information to disk as well
public class ExampleGrassSitAction : MultiAction {

    public ExampleGrassSitAction(ActionType type, ActionInfo info) : base(type, info) {}

    protected override IEnumerable<Action> CreateFirstActions() {
        // we want to walk to the location clicked, so we use the current action info
        yield return ActionType.GoHere.Construct<Action>(this.Info);
    }

    protected override void AndThenUpdate(GameTime time, TimeSpan passedInGame, float speedMultiplier) {
        base.AndThenUpdate(time, passedInGame, speedMultiplier);
        // set our person to look like they're sitting on the ground
        this.Person.CurrentPose = Pose.SittingGround;

        // restore need and lower emotions
        this.Person.RestoreNeed(NeedType.Energy, 0.5F, this.Info, speedMultiplier);
        this.Person.LowerEmotion(EmotionType.Uncomfortable, 0.0001F, speedMultiplier);
    }

    protected override CompletionType AndThenIsCompleted() {
        // we want to complete our action once 10 minutes of sitting time have passed
        return this.CompleteIfTimeUp(TimeSpan.FromMinutes(10));
    }

    protected override void AndThenOnCompleted(CompletionType type) {
        base.AndThenOnCompleted(type);
        // this method is called when the action completes in any way, even if it fails
        if (type == CompletionType.Completed) {
            // once we're finished sitting, we want to get a nice emotion modifier for it
            this.Person.AddEmotion(ExampleMod.GrassSittingModifier, 2, TimeSpan.FromHours(1), this.Type);
        }
    }

}

// note that having a custom class for a furniture item like this is entirely optional
// but it allows for additional functionalities as displayed in this example
public class ExampleTable : Furniture {

    // anything whose base classes have the DataContract attribute automatically gets saved and loaded to and from disk
    // this means that you can add custom DataMember members to have them saved and loaded
    [DataMember]
    public float TestValue;

    public ExampleTable(Guid id, FurnitureType type, int[] colors, Map map, Vector2 pos, float floor) : base(id, type, colors, map, pos, floor) {
        this.TestValue = Furniture.Random.NextSingle();
    }

}
