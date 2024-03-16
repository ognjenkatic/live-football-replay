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
        public string IdTeam { get; set; }

        [JsonPropertyName("idSoccerXML")]
        public string IdSoccerXML { get; set; }

        [JsonPropertyName("idAPIfootball")]
        public string IdAPIfootball { get; set; }

        [JsonPropertyName("intLoved")]
        public string IntLoved { get; set; }

        [JsonPropertyName("strTeam")]
        public string StrTeam { get; set; }

        [JsonPropertyName("strTeamShort")]
        public string StrTeamShort { get; set; }

        [JsonPropertyName("strAlternate")]
        public string StrAlternate { get; set; }

        [JsonPropertyName("intFormedYear")]
        public string IntFormedYear { get; set; }

        [JsonPropertyName("strSport")]
        public string StrSport { get; set; }

        [JsonPropertyName("strLeague")]
        public string StrLeague { get; set; }

        [JsonPropertyName("idLeague")]
        public string IdLeague { get; set; }

        [JsonPropertyName("strLeague2")]
        public string StrLeague2 { get; set; }

        [JsonPropertyName("idLeague2")]
        public string IdLeague2 { get; set; }

        [JsonPropertyName("strLeague3")]
        public string StrLeague3 { get; set; }

        [JsonPropertyName("idLeague3")]
        public string IdLeague3 { get; set; }

        [JsonPropertyName("strLeague4")]
        public string StrLeague4 { get; set; }

        [JsonPropertyName("idLeague4")]
        public string IdLeague4 { get; set; }

        [JsonPropertyName("strLeague5")]
        public string StrLeague5 { get; set; }

        [JsonPropertyName("idLeague5")]
        public string IdLeague5 { get; set; }

        [JsonPropertyName("strLeague6")]
        public string StrLeague6 { get; set; }

        [JsonPropertyName("strLeague7")]
        public string StrLeague7 { get; set; }

        [JsonPropertyName("strStadium")]
        public string StrStadium { get; set; }

        [JsonPropertyName("strKeywords")]
        public string StrKeywords { get; set; }

        [JsonPropertyName("strRSS")]
        public string StrRSS { get; set; }

        [JsonPropertyName("strStadiumThumb")]
        public string StrStadiumThumb { get; set; }

        [JsonPropertyName("strStadiumDescription")]
        public string StrStadiumDescription { get; set; }

        [JsonPropertyName("strStadiumLocation")]
        public string StrStadiumLocation { get; set; }

        [JsonPropertyName("intStadiumCapacity")]
        public string IntStadiumCapacity { get; set; }

        [JsonPropertyName("strWebsite")]
        public string StrWebsite { get; set; }

        [JsonPropertyName("strFacebook")]
        public string StrFacebook { get; set; }

        [JsonPropertyName("strTwitter")]
        public string StrTwitter { get; set; }

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
