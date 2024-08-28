using System.Text.Json.Serialization;

namespace LiveFootball.Server.DTOs
{
    public class SportsDbTeamResponse
    {
        [JsonPropertyName("teams")]
        public List<Team> Teams { get; set; } = new();
    }

    public class Team
    {
        [JsonPropertyName("idTeam")]
        public required string IdTeam { get; set; }

        [JsonPropertyName("idSoccerXML")]
        public required string IdSoccerXML { get; set; }

        [JsonPropertyName("idAPIfootball")]
        public required string IdAPIfootball { get; set; }

        [JsonPropertyName("intLoved")]
        public required string IntLoved { get; set; }

        [JsonPropertyName("strTeam")]
        public required string StrTeam { get; set; }

        [JsonPropertyName("strTeamShort")]
        public required string StrTeamShort { get; set; }

        [JsonPropertyName("strAlternate")]
        public required string StrAlternate { get; set; }

        [JsonPropertyName("intFormedYear")]
        public required string IntFormedYear { get; set; }

        [JsonPropertyName("strSport")]
        public required string StrSport { get; set; }

        [JsonPropertyName("strLeague")]
        public required string StrLeague { get; set; }

        [JsonPropertyName("idLeague")]
        public required string IdLeague { get; set; }

        [JsonPropertyName("strLeague2")]
        public required string StrLeague2 { get; set; }

        [JsonPropertyName("idLeague2")]
        public required string IdLeague2 { get; set; }

        [JsonPropertyName("strLeague3")]
        public required string StrLeague3 { get; set; }

        [JsonPropertyName("idLeague3")]
        public required string IdLeague3 { get; set; }

        [JsonPropertyName("strLeague4")]
        public required string StrLeague4 { get; set; }

        [JsonPropertyName("idLeague4")]
        public required string IdLeague4 { get; set; }

        [JsonPropertyName("strLeague5")]
        public required string StrLeague5 { get; set; }

        [JsonPropertyName("idLeague5")]
        public required string IdLeague5 { get; set; }

        [JsonPropertyName("strLeague6")]
        public required string StrLeague6 { get; set; }

        [JsonPropertyName("strLeague7")]
        public required string StrLeague7 { get; set; }

        [JsonPropertyName("strStadium")]
        public required string StrStadium { get; set; }

        [JsonPropertyName("strKeywords")]
        public required string StrKeywords { get; set; }

        [JsonPropertyName("strRSS")]
        public required string StrRSS { get; set; }

        [JsonPropertyName("strStadiumThumb")]
        public required string StrStadiumThumb { get; set; }

        [JsonPropertyName("strStadiumDescription")]
        public required string StrStadiumDescription { get; set; }

        [JsonPropertyName("strStadiumLocation")]
        public required string StrStadiumLocation { get; set; }

        [JsonPropertyName("intStadiumCapacity")]
        public required string IntStadiumCapacity { get; set; }

        [JsonPropertyName("strWebsite")]
        public required string StrWebsite { get; set; }

        [JsonPropertyName("strFacebook")]
        public required string StrFacebook { get; set; }

        [JsonPropertyName("strTwitter")]
        public required string StrTwitter { get; set; }

        [JsonPropertyName("strInstagram")]
        public string StrInstagram { get; set; }

        [JsonPropertyName("strDescriptionEN")]
        public string StrDescriptionEN { get; set; }

        [JsonPropertyName("strDescriptionDE")]
        public string StrDescriptionDE { get; set; }

        [JsonPropertyName("strDescriptionFR")]
        public string StrDescriptionFR { get; set; }

        [JsonPropertyName("strDescriptionIT")]
        public string StrDescriptionIT { get; set; }

        [JsonPropertyName("strDescriptionJP")]
        public string StrDescriptionJP { get; set; }

        [JsonPropertyName("strDescriptionRU")]
        public string StrDescriptionRU { get; set; }

        [JsonPropertyName("strDescriptionES")]
        public string StrDescriptionES { get; set; }

        [JsonPropertyName("strDescriptionPT")]
        public string StrDescriptionPT { get; set; }

        [JsonPropertyName("strDescriptionNO")]
        public string StrDescriptionNO { get; set; }

        [JsonPropertyName("strKitColour1")]
        public string StrKitColour1 { get; set; }

        [JsonPropertyName("strKitColour2")]
        public string StrKitColour2 { get; set; }

        [JsonPropertyName("strKitColour3")]
        public string StrKitColour3 { get; set; }

        [JsonPropertyName("strGender")]
        public string StrGender { get; set; }

        [JsonPropertyName("strCountry")]
        public string StrCountry { get; set; }

        [JsonPropertyName("strTeamBadge")]
        public string StrTeamBadge { get; set; }

        [JsonPropertyName("strTeamJersey")]
        public string StrTeamJersey { get; set; }

        [JsonPropertyName("strTeamLogo")]
        public string StrTeamLogo { get; set; }

        [JsonPropertyName("strTeamFanart1")]
        public string StrTeamFanart1 { get; set; }

        [JsonPropertyName("strTeamFanart2")]
        public string StrTeamFanart2 { get; set; }

        [JsonPropertyName("strTeamFanart3")]
        public string StrTeamFanart3 { get; set; }

        [JsonPropertyName("strTeamFanart4")]
        public string StrTeamFanart4 { get; set; }

        [JsonPropertyName("strTeamBanner")]
        public string StrTeamBanner { get; set; }

        [JsonPropertyName("strYoutube")]
        public string StrYoutube { get; set; }

        [JsonPropertyName("strLocked")]
        public string StrLocked { get; set; }
    }
}