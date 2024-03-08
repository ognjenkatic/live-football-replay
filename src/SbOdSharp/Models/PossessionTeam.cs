using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record PossessionTeam(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("name")] string Name
    );
}
