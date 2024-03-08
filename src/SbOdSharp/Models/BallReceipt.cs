using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record BallReceipt([property: JsonPropertyName("outcome")] Outcome Outcome);
}
