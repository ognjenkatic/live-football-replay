using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record FreezeFrame(
        [property: JsonPropertyName("location")] List<double> Location,
        [property: JsonPropertyName("player")] Player Player,
        [property: JsonPropertyName("position")] Position Position,
        [property: JsonPropertyName("teammate")] bool Teammate
    );
}
