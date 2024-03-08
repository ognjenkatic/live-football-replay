using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Card(
        [property: JsonPropertyName("time")] string Time,
        [property: JsonPropertyName("card_type")] string CardType,
        [property: JsonPropertyName("reason")] string Reason,
        [property: JsonPropertyName("period")] int Period
    );
}
