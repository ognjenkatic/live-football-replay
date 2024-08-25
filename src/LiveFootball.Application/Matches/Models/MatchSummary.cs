namespace LiveFootball.Application.Matches.Models
{
    public class MatchSummary
    {
        public required int MatchId { get; set; }
        public required string HomeTeam { get; set; }
        public required string AwayTeam { get; set; }
        public required int HomeGoals { get; set; }
        public required int AwayGoals { get; set; }
    }
}
