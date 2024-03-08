using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Referee(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("name")] string Name,
        [property: JsonPropertyName("country")] Country Country
    );
}
