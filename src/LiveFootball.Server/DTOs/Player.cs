using System.Text.Json.Serialization;

namespace LiveFootball.Server.DTOs
{
    public class Player
    {
        [JsonPropertyName("idPlayer")]
        public required string IdPlayer { get; set; }

        [JsonPropertyName("idTeam")]
        public required string IdTeam { get; set; }

        [JsonPropertyName("idTeam2")]
        public required string IdTeam2 { get; set; }

        [JsonPropertyName("idSoccerXML")]
        public required string IdSoccerXML { get; set; }

        [JsonPropertyName("idAPIfootball")]
        public required string IdAPIfootball { get; set; }

        [JsonPropertyName("strNationality")]
        public required string StrNationality { get; set; }

        [JsonPropertyName("strPlayer")]
        public required string StrPlayer { get; set; }

        [JsonPropertyName("strPlayerAlternate")]
        public required string StrPlayerAlternate { get; set; }

        [JsonPropertyName("strTeam")]
        public required string StrTeam { get; set; }

        [JsonPropertyName("strTeam2")]
        public required string StrTeam2 { get; set; }

        [JsonPropertyName("strSport")]
        public required string StrSport { get; set; }

        [JsonPropertyName("intSoccerXMLTeamID")]
        public required string IntSoccerXMLTeamID { get; set; }

        [JsonPropertyName("dateBorn")]
        public required string DateBorn { get; set; }

        [JsonPropertyName("strNumber")]
        public required string StrNumber { get; set; }

        [JsonPropertyName("dateSigned")]
        public required string DateSigned { get; set; }

        [JsonPropertyName("strSigning")]
        public required string StrSigning { get; set; }

        [JsonPropertyName("strWage")]
        public required string StrWage { get; set; }

        [JsonPropertyName("strOutfitter")]
        public required string StrOutfitter { get; set; }

        [JsonPropertyName("strKit")]
        public required string StrKit { get; set; }

        [JsonPropertyName("strAgent")]
        public required string StrAgent { get; set; }

        [JsonPropertyName("strBirthLocation")]
        public required string StrBirthLocation { get; set; }

        [JsonPropertyName("strGender")]
        public required string StrGender { get; set; }

        [JsonPropertyName("strSide")]
        public required string StrSide { get; set; }

        [JsonPropertyName("strPosition")]
        public required string StrPosition { get; set; }

        [JsonPropertyName("strFacebook")]
        public required string StrFacebook { get; set; }

        [JsonPropertyName("strWebsite")]
        public required string StrWebsite { get; set; }

        [JsonPropertyName("strTwitter")]
        public required string StrTwitter { get; set; }

        [JsonPropertyName("strInstagram")]
        public required string StrInstagram { get; set; }

        [JsonPropertyName("strYoutube")]
        public required string StrYoutube { get; set; }

        [JsonPropertyName("strHeight")]
        public required string StrHeight { get; set; }

        [JsonPropertyName("strWeight")]
        public required string StrWeight { get; set; }

        [JsonPropertyName("intLoved")]
        public required string IntLoved { get; set; }

        [JsonPropertyName("strThumb")]
        public required string StrThumb { get; set; }

        [JsonPropertyName("strCutout")]
        public required string StrCutout { get; set; }

        [JsonPropertyName("strRender")]
        public required string StrRender { get; set; }

        [JsonPropertyName("strCreativeCommons")]
        public required string StrCreativeCommons { get; set; }

        [JsonPropertyName("strLocked")]
        public required string StrLocked { get; set; }
    }

    public class SportsDbFindPlayerResponse
    {
        [JsonPropertyName("player")]
        public required List<Player> Players { get; set; }
    }
}