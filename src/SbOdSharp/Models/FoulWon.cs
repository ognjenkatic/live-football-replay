using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record FoulWon(
        [property: JsonPropertyName("advantage")] bool? Advantage,
        [property: JsonPropertyName("defensive")] bool? Defensive
    );
}
