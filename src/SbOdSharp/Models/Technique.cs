using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Technique(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("name")] string Name
    )
    {
        public static readonly Technique Diving = new(45, "Diving");
        public static readonly Technique Standing = new(46, "Standing");

        // TODO: Check if pass technique should be saparate
        public static readonly Technique Inswinging = new(104, "Inswinging");
        public static readonly Technique Outswinging = new(105, "Outswinging");
        public static readonly Technique Straight = new(107, "Straight");
        public static readonly Technique ThroughBall = new(108, "Through Ball");

        // TODO: Check if shot technique should be saparate
        public static readonly Technique Backheel = new(89, "Backheel");
        public static readonly Technique DivingHeader = new(90, "Diving Header");
        public static readonly Technique HalfVolley = new(91, "Half Volley");
        public static readonly Technique Lob = new(92, "Lob");
        public static readonly Technique Normal = new(93, "Normal");
        public static readonly Technique OverheadKick = new(94, "Overhead Kick");
        public static readonly Technique Volley = new(95, "Volley");
    }
}
