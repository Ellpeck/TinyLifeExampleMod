using System;
using System.Collections.Generic;
using TinyLife;
using TinyLife.Actions;
using TinyLife.Emotions;
using TinyLife.Objects;
using Action = TinyLife.Actions.Action;

namespace ExampleMod;

// we use a multi action because we want to walk to the location, and then execute the main sitting part
// see CustomTable for information on how to store custom action-specific information to disk as well
public class ExampleModGrassSitAction : MultiAction {

    public ExampleModGrassSitAction(ActionType type, ActionInfo info) : base(type, info) {}

    protected override IEnumerable<Action> CreateFirstActions() {
        // we want to walk to the location clicked, so we use the current action info
        yield return ActionType.GoHere.Construct<Action>(this.Info);

        // if multiple things should be done before starting this action, they can all be returned here
    }

    protected override void AndThenInitialize() {
        // this is called when the main action starts (after going to the location, in our case)
        // but we don't need to do anything here for our action
    }

    protected override void AndThenUpdate(GameTime time, TimeSpan passedInGame, float speedMultiplier) {
        base.AndThenUpdate(time, passedInGame, speedMultiplier);
        // this method gets called every update frame while the action is active

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
