using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record FoulCommitted(
        [property: JsonPropertyName("advantage")] bool? Advantage,
        [property: JsonPropertyName("counterpress")] bool? Counterpress,
        [property: JsonPropertyName("offensive")] bool? Offensive,
        [property: JsonPropertyName("penalty")] bool? Penalty,
        [property: JsonPropertyName("type")] Type? Type,
        [property: JsonPropertyName("card")] EventCard? Card
    );
}
