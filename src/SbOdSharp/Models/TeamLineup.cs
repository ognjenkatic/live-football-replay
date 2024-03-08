using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record TeamLineup(
        [property: JsonPropertyName("team_id")] int TeamId,
        [property: JsonPropertyName("team_name")] string TeamName,
        [property: JsonPropertyName("lineup")] List<Lineup> Lineup
    );
}
