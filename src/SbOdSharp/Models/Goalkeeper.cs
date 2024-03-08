using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Goalkeeper(
        [property: JsonPropertyName("position")] Position? Position,
        [property: JsonPropertyName("type")] Type Type,
        [property: JsonPropertyName("outcome")] Outcome? Outcome,
        [property: JsonPropertyName("technique")] Technique? Technique,
        [property: JsonPropertyName("body_part")] BodyPart? BodyPart
    )
    {
        [JsonPropertyName("end_location")]
        public List<double> EndLocation { get; set; } = [];
    }
}
