using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Stadium(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("name")] string Name,
        [property: JsonPropertyName("country")] Country Country
    );
}
