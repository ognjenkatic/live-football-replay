using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Substitution(
        [property: JsonPropertyName("outcome")] Outcome? Outcome,
        [property: JsonPropertyName("replacement")] Replacement Replacement
    );
}
