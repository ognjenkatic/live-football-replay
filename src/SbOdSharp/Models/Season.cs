using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Season(
        [property: JsonPropertyName("season_id")] int SeasonId,
        [property: JsonPropertyName("season_name")] string SeasonName
    );
}
