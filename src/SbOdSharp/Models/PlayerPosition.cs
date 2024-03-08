using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record PlayerPosition(
        [property: JsonPropertyName("position_id")] int PositionId,
        [property: JsonPropertyName("position")] string Position,
        [property: JsonPropertyName("from")] string From,
        [property: JsonPropertyName("to")] string To,
        [property: JsonPropertyName("from_period")] int FromPeriod,
        [property: JsonPropertyName("to_period")] int? ToPeriod,
        [property: JsonPropertyName("start_reason")] string StartReason,
        [property: JsonPropertyName("end_reason")] string EndReason
    );
}
