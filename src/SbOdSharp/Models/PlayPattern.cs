using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record PlayPattern(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("name")] string Name
    )
    {
        public static readonly PlayPattern RegularPlay = new(1, "Regular Play");
        public static readonly PlayPattern FromCorner = new(2, "From Corner");
        public static readonly PlayPattern FromFreeKick = new(3, "From Free Kick");
        public static readonly PlayPattern FromThrowIn = new(4, "From Throw In");
        public static readonly PlayPattern Other = new(5, "Other");
        public static readonly PlayPattern FromCounter = new(6, "From Counter");
        public static readonly PlayPattern FromGoalKick = new(7, "From Goal Kick");
        public static readonly PlayPattern FromKeeper = new(8, "From Keeper");
        public static readonly PlayPattern FromKickOff = new(9, "From Kick Off");
    }
}
