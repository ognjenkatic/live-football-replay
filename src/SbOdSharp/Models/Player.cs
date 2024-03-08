using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Player(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("name")] string Name
    );
}
