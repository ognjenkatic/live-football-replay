using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Lineup(
        [property: JsonPropertyName("player_id")] int PlayerId,
        [property: JsonPropertyName("player_name")] string PlayerName,
        [property: JsonPropertyName("player_nickname")] string PlayerNickname,
        [property: JsonPropertyName("jersey_number")] int JerseyNumber,
        [property: JsonPropertyName("country")] Country? Country,
        [property: JsonPropertyName("cards")] List<Card> Cards,
        [property: JsonPropertyName("positions")] List<PlayerPosition> Positions
    );
}
