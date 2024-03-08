using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Interception([property: JsonPropertyName("outcome")] Outcome Outcome);
}
