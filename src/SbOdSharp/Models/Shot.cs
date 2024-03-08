using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Shot(
        [property: JsonPropertyName("statsbomb_xg")] double StatsbombXg,
        [property: JsonPropertyName("end_location")] List<double> EndLocation,
        [property: JsonPropertyName("key_pass_id")] string? KeyPassId,
        [property: JsonPropertyName("body_part")] BodyPart BodyPart,
        [property: JsonPropertyName("technique")] Technique Technique,
        [property: JsonPropertyName("type")] Type Type,
        [property: JsonPropertyName("outcome")] Outcome Outcome,
        [property: JsonPropertyName("first_time")] bool? FirstTime,
        [property: JsonPropertyName("one_on_one")] bool? OneOnOne
    )
    {
        [JsonPropertyName("freeze_frame")]
        public List<FreezeFrame> FreezeFrame { get; set; } = [];
    }
}
