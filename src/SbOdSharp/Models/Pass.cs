using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Pass(
        [property: JsonPropertyName("recipient")] Recipient? Recipient,
        [property: JsonPropertyName("length")] double Length,
        [property: JsonPropertyName("angle")] double Angle,
        [property: JsonPropertyName("height")] Height Height,
        [property: JsonPropertyName("end_location")] List<double> EndLocation,
        [property: JsonPropertyName("body_part")] BodyPart? BodyPart,
        [property: JsonPropertyName("type")] Type? Type,
        [property: JsonPropertyName("outcome")] Outcome? Outcome,
        [property: JsonPropertyName("assisted_shot_id")] string? AssistedShotId,
        [property: JsonPropertyName("shot_assist")] bool? ShotAssist,
        [property: JsonPropertyName("through_ball")] bool? ThroughBall,
        [property: JsonPropertyName("technique")] Technique? Technique,
        [property: JsonPropertyName("cross")] bool? Cross,
        [property: JsonPropertyName("switch")] bool? Switch,
        [property: JsonPropertyName("goal_assist")] bool? GoalAssist,
        [property: JsonPropertyName("aerial_won")] bool? AerialWon,
        [property: JsonPropertyName("backheel")] bool? Backheel,
        [property: JsonPropertyName("deflected")] bool? Deflected
    );
}
