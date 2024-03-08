using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Outcome(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("name")] string Name
    )
    {
        public static readonly Outcome Blocked = new(96, "Blocked");
        public static readonly Outcome Goal = new(97, "Goal");
        public static readonly Outcome OffT = new(98, "Off T");
        public static readonly Outcome Post = new(99, "Post");
        public static readonly Outcome Saved = new(100, "Saved");
        public static readonly Outcome Wayward = new(101, "Wayward");
        public static readonly Outcome SavedOffT = new(115, "Saved Off T");
        public static readonly Outcome SavedToPost = new(116, "SavedToPost");
        public static readonly Outcome Won = new(108, "Won");
        public static readonly Outcome Lost = new(109, "Lost");
        public static readonly Outcome SuccessToTeam = new(147, "Success To Team");
        public static readonly Outcome SuccessToOpposition = new(148, "Success To Opposition");

        // TODO: Check if pass outcome should be separate
        public static readonly Outcome Incomplete = new(9, "Incomplete");
        public static readonly Outcome InjuryClearance = new(74, "Injury Clearance");
        public static readonly Outcome Out = new(75, "Out");
        public static readonly Outcome PassOffside = new(76, "Pass Offside");
        public static readonly Outcome Unknown = new(77, "Unknown");

        // TODO: Check if substitution event should have separate
        public static readonly Outcome Injury = new(102, "Injury");
        public static readonly Outcome Tactical = new(103, "Tactical");
    }
}
