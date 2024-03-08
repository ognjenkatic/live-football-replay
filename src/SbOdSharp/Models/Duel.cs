using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Duel(
        [property: JsonPropertyName("type")] Type Type,
        [property: JsonPropertyName("outcome")] Outcome? Outcome
    );
}
