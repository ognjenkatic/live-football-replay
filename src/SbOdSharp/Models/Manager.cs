using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Manager(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("name")] string Name,
        [property: JsonPropertyName("nickname")] object Nickname,
        [property: JsonPropertyName("dob")] string Dob,
        [property: JsonPropertyName("country")] Country Country
    );
}
