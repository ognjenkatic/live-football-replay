using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record EventCard(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("name")] string Name
    )
    {
        public static readonly EventCard YellowCard = new(65, "Yellow Card");
        public static readonly EventCard SecondYellow = new(66, "Second Yellow");
        public static readonly EventCard RedCard = new(67, "Red Card");
    }
}
