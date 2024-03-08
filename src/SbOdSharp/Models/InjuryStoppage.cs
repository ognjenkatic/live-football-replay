using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record InjuryStoppage([property: JsonPropertyName("in_chain")] bool InChain);
}
