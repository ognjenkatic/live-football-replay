using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record BallRecovery(
        [property: JsonPropertyName("recovery_failure")] bool? RecoveryFailure,
        [property: JsonPropertyName("offensive")] bool? Offensive
    );
}
