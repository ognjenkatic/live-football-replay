using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record EventLineup(
        [property: JsonPropertyName("player")] Player Player,
        [property: JsonPropertyName("position")] Position Position,
        [property: JsonPropertyName("jersey_number")] int JerseyNumber
    );
}
