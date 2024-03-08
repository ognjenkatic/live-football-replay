using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record BadBehaviour([property: JsonPropertyName("card")] EventCard EventCard);
}
