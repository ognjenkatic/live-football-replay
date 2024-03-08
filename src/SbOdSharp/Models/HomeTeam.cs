using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record HomeTeam(
        [property: JsonPropertyName("home_team_id")] int HomeTeamId,
        [property: JsonPropertyName("home_team_name")] string HomeTeamName,
        [property: JsonPropertyName("home_team_gender")] string HomeTeamGender,
        [property: JsonPropertyName("home_team_group")] string HomeTeamGroup,
        [property: JsonPropertyName("country")] Country Country
    )
    {
        [JsonPropertyName("managers")]
        public List<Manager> Managers { get; set; } = [];
    }
}
