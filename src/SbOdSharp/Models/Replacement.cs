using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Replacement(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("name")] string Name
    );
}
