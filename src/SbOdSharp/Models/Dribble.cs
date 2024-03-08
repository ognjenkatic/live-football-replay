using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Dribble(
        [property: JsonPropertyName("outcome")] Outcome Outcome,
        [property: JsonPropertyName("nutmeg")] bool? Nutmeg,
        [property: JsonPropertyName("overrun")] bool? Overrun
    );
}
