using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Tactics(
        [property: JsonPropertyName("formation")] int Formation,
        [property: JsonPropertyName("lineup")] List<EventLineup> EventLineup
    );
}
