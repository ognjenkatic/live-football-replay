using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Type(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("name")] string Name
    )
    {
        public static readonly Type AerialLost = new(10, "Aerial Lost");
        public static readonly Type Tackle = new(11, "Tackle");
        public static readonly Type Won = new(4, "Won");
        public static readonly Type LostInPlay = new(13, "Lost In Play");
        public static readonly Type LostOut = new(14, "Lost Out");
        public static readonly Type Success = new(15, "Success");
        public static readonly Type SuccessInPlay = new(16, "Success In Play");
        public static readonly Type SuccessOut = new(17, "Success Out");
        public static readonly Type SixSeconds = new(19, "6 seconds");
        public static readonly Type BackpassPick = new(20, "Backpass Pick");
        public static readonly Type DangerousPlay = new(21, "Dangerous Play");
        public static readonly Type Dive = new(22, "Dive");
        public static readonly Type FoulOut = new(23, "Foul Out");
        public static readonly Type Handball = new(24, "Handball");

        // TODO: Check if goalkeeper type should be separate
        public static readonly Type Collected = new(25, "Collected");
        public static readonly Type GoalConceded = new(26, "Goal Conceded");
        public static readonly Type KeeperSweeper = new(27, "Keeper Sweeper");
        public static readonly Type PenaltyConceded = new(28, "Penalty Conceded");
        public static readonly Type PenaltySaved = new(29, "Penalty Saved");
        public static readonly Type Punch = new(30, "Punch");
        public static readonly Type PenaltySavedToPost = new(109, "Penalty Saved To Post");
        public static readonly Type Save = new(31, "Save");
        public static readonly Type SavedToPost = new(110, "Saved To Post");
        public static readonly Type ShotFaced = new(32, "Shot Faced");
        public static readonly Type ShotSaved = new(33, "Shot Saved");
        public static readonly Type ShotSavedOffT = new(113, "Shot Saved Off T");
        public static readonly Type ShotSavedToPost = new(114, "Shot Saved To Post");
        public static readonly Type Smother = new(34, "Smother");

        // TODO: Check if pass type should be separate
        public static readonly Type Corner = new(61, "Corner");
        public static readonly Type FreeKick = new(62, "Free Kick");
        public static readonly Type GoalKick = new(63, "Goal Kick");
        public static readonly Type Interception = new(64, "Interception");
        public static readonly Type KickOff = new(65, "Kick Off");
        public static readonly Type Recovery = new(66, "Recovery");
        public static readonly Type ThrowIn = new(67, "Throw-in");

        // TODO: Check if shot type should be separate
        public static readonly Type OpenPlay = new(87, "OpenPlay");
        public static readonly Type Penalty = new(88, "Penalty");
    }
}
