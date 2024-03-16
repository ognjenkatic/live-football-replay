using System.Text.Json.Serialization;

namespace LiveFootball.Server.DTOs
{
    public class Player
    {
        [JsonPropertyName("idPlayer")]
        public string IdPlayer { get; set; }

        [JsonPropertyName("idTeam")]
        public string IdTeam { get; set; }

        [JsonPropertyName("idTeam2")]
        public string IdTeam2 { get; set; }

        [JsonPropertyName("idSoccerXML")]
        public string IdSoccerXML { get; set; }

        [JsonPropertyName("idAPIfootball")]
        public string IdAPIfootball { get; set; }

        [JsonPropertyName("strNationality")]
        public string StrNationality { get; set; }

        [JsonPropertyName("strPlayer")]
        public string StrPlayer { get; set; }

        [JsonPropertyName("strPlayerAlternate")]
        public string StrPlayerAlternate { get; set; }

        [JsonPropertyName("strTeam")]
        public string StrTeam { get; set; }

        [JsonPropertyName("strTeam2")]
        public string StrTeam2 { get; set; }

        [JsonPropertyName("strSport")]
        public string StrSport { get; set; }

        [JsonPropertyName("intSoccerXMLTeamID")]
        public string IntSoccerXMLTeamID { get; set; }

        [JsonPropertyName("dateBorn")]
        public string DateBorn { get; set; }

        [JsonPropertyName("strNumber")]
        public string StrNumber { get; set; }

        [JsonPropertyName("dateSigned")]
        public string DateSigned { get; set; }

        [JsonPropertyName("strSigning")]
        public string StrSigning { get; set; }

        [JsonPropertyName("strWage")]
        public string StrWage { get; set; }

        [JsonPropertyName("strOutfitter")]
        public string StrOutfitter { get; set; }

        [JsonPropertyName("strKit")]
        public string StrKit { get; set; }

        [JsonPropertyName("strAgent")]
        public string StrAgent { get; set; }

        [JsonPropertyName("strBirthLocation")]
        public string StrBirthLocation { get; set; }

        [JsonPropertyName("strGender")]
        public string StrGender { get; set; }

        [JsonPropertyName("strSide")]
        public string StrSide { get; set; }

        [JsonPropertyName("strPosition")]
        public string StrPosition { get; set; }

        [JsonPropertyName("strFacebook")]
        public string StrFacebook { get; set; }

        [JsonPropertyName("strWebsite")]
        public string StrWebsite { get; set; }

        [JsonPropertyName("strTwitter")]
        public string StrTwitter { get; set; }

        [JsonPropertyName("strInstagram")]
        public string StrInstagram { get; set; }

        [JsonPropertyName("strYoutube")]
        public string StrYoutube { get; set; }

        [JsonPropertyName("strHeight")]
        public string StrHeight { get; set; }

        [JsonPropertyName("strWeight")]
        public string StrWeight { get; set; }

        [JsonPropertyName("intLoved")]
        public string IntLoved { get; set; }

        [JsonPropertyName("strThumb")]
        public string StrThumb { get; set; }

        [JsonPropertyName("strCutout")]
        public string StrCutout { get; set; }

        [JsonPropertyName("strRender")]
        public string StrRender { get; set; }

        [JsonPropertyName("strCreativeCommons")]
        public string StrCreativeCommons { get; set; }

        [JsonPropertyName("strLocked")]
        public string StrLocked { get; set; }
    }

    public class SportsDbFindPlayerResponse
    {
        [JsonPropertyName("player")]
        public List<Player> Players { get; set; }
    }
}
