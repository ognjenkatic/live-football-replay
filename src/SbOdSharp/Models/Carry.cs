using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Carry([property: JsonPropertyName("end_location")] List<double> EndLocation);
}
