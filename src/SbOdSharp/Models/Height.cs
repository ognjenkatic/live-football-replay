using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Height(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("name")] string Name
    )
    {
        public static readonly Height GroundPass = new(1, "Ground Pass");
        public static readonly Height LowPass = new(2, "Low Pass");
        public static readonly Height HighPass = new(3, "High Pass");
    }
}
