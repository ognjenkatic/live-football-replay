using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Block([property: JsonPropertyName("deflection")] bool? Deflection);
}
