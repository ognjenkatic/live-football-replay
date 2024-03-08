using System.Text;
using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record CompetitionStage(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("name")] string Name
    )
    {
        public static readonly CompetitionStage RegularSeason = new(1, "Regular Season");
        public static readonly CompetitionStage PlayInRound = new(2, "Play-In Round");
        public static readonly CompetitionStage EuropaLeaguePlayOffsSemiFinals =
            new(6, "Europa League Play-offs  Semi-finals");
        public static readonly CompetitionStage MlsCupConferenceSemiFinals =
            new(8, "MLS Cup  Conference Semi-finals");
        public static readonly CompetitionStage ThirdQualifyingRound =
            new(9, "3rd Qualifying Round");
        public static readonly CompetitionStage GroupStage = new(10, "Group Stage");
        public static readonly CompetitionStage QuarterFinals = new(11, "Quarter-finals");
        public static readonly CompetitionStage EuropaLeaguePlayOffsFinals =
            new(12, "Europa League Play-offs  Finals");
        public static readonly CompetitionStage SixteenthFinals = new(13, "16th Finals");
        public static readonly CompetitionStage PromotionPlayOffsFinal =
            new(14, "Promotion Play-offs  Final");
        public static readonly CompetitionStage SemiFinals = new(15, "Semi-finals");
        public static readonly CompetitionStage PromotionPlayOffsSemiFinals =
            new(18, "Promotion Play-offs  Semi-finals");
        public static readonly CompetitionStage PreliminaryRound = new(19, "Preliminary Round");
        public static readonly CompetitionStage SecondRound = new(20, "2nd Round");
        public static readonly CompetitionStage EuropaLeaguePlayOffsQuarterFinals =
            new(21, "Europa League Play-offs Quarter-finals");
        public static readonly CompetitionStage SecondQualifyingRound =
            new(22, "2nd Qualifying Round");
        public static readonly CompetitionStage MlsCupConferenceFinals =
            new(23, "MLS Cup  Conference Finals");
        public static readonly CompetitionStage PromotionPlayOffsFirstRound =
            new(24, "Promotion Play-offs  1st Round");
        public static readonly CompetitionStage ThirdPlaceFinal = new(25, "3rd Place Final");
        public static readonly CompetitionStage Final = new(26, "Final");
        public static readonly CompetitionStage PromotionPlayOffsSecondRound =
            new(27, "Promotion Play-offs  2nd Round");
        public static readonly CompetitionStage PlayOffs = new(28, "Play-offs");
        public static readonly CompetitionStage FirstQualifyingRound =
            new(29, "1st Qualifying Round");
        public static readonly CompetitionStage PreliminaryRoundSemiFinals =
            new(31, "Preliminary Round  Semi-finals");
        public static readonly CompetitionStage EightFinals = new(33, "8th Finals");
        public static readonly CompetitionStage FirstPhase = new(34, "1st Phase");
        public static readonly CompetitionStage PreliminaryRoundFinal =
            new(35, "Preliminary Round  Final");
    }
}
