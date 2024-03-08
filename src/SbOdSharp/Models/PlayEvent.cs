using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record PlayEvent(
        [property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("index")] int Index,
        [property: JsonPropertyName("period")] int Period,
        [property: JsonPropertyName("timestamp")] TimeOnly Timestamp,
        [property: JsonPropertyName("minute")] int Minute,
        [property: JsonPropertyName("second")] int Second,
        [property: JsonPropertyName("type")] PlayEventType Type,
        [property: JsonPropertyName("possession")] int Possession,
        [property: JsonPropertyName("possession_team")] PossessionTeam PossessionTeam,
        [property: JsonPropertyName("play_pattern")] PlayPattern PlayPattern,
        [property: JsonPropertyName("team")] Team Team,
        [property: JsonPropertyName("duration")] double? Duration,
        [property: JsonPropertyName("tactics")] Tactics? Tactics,
        [property: JsonPropertyName("player")] Player? Player,
        [property: JsonPropertyName("position")] Position? Position,
        [property: JsonPropertyName("pass")] Pass? Pass,
        [property: JsonPropertyName("under_pressure")] bool? UnderPressure,
        [property: JsonPropertyName("carry")] Carry? Carry,
        [property: JsonPropertyName("ball_receipt")] BallReceipt? BallReceipt,
        [property: JsonPropertyName("dribble")] Dribble? Dribble,
        [property: JsonPropertyName("shot")] Shot? Shot,
        [property: JsonPropertyName("goalkeeper")] Goalkeeper? Goalkeeper,
        [property: JsonPropertyName("counterpress")] bool? Counterpress,
        [property: JsonPropertyName("duel")] Duel? Duel,
        [property: JsonPropertyName("ball_recovery")] BallRecovery? BallRecovery,
        [property: JsonPropertyName("interception")] Interception? Interception,
        [property: JsonPropertyName("block")] Block? Block,
        [property: JsonPropertyName("substitution")] Substitution? Substitution,
        [property: JsonPropertyName("foul_committed")] FoulCommitted? FoulCommitted,
        [property: JsonPropertyName("foul_won")] FoulWon? FoulWon,
        [property: JsonPropertyName("injury_stoppage")] InjuryStoppage? InjuryStoppage,
        [property: JsonPropertyName("bad_behaviour")] BadBehaviour? BadBehaviour
    )
    {
        [JsonPropertyName("related_events")]
        public List<string> RelatedEvents { get; set; } = [];

        [JsonPropertyName("location")]
        public List<double> Location { get; set; } = [];
    }
}
