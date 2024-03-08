using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record Competition(
        [property: JsonPropertyName("competition_id")] int CompetitionId,
        [property: JsonPropertyName("country_name")] string CountryName,
        [property: JsonPropertyName("competition_name")] string CompetitionName,
        [property: JsonPropertyName("season_id")] int? SeasonId,
        [property: JsonPropertyName("season_name")] string? SeasonName
    )
    {
        public static readonly Competition OneBundesliga =
            new(9, "Germany", "1. Bundesliga", null, null);
        public static readonly Competition AfricanCupofNations =
            new(1267, "Africa", "African Cup of Nations", null, null);
        public static readonly Competition ChampionsLeague =
            new(16, "Europe", "Champions League", null, null);
        public static readonly Competition CopadelRey =
            new(87, "Spain", "Copa del Rey", null, null);
        public static readonly Competition FAWomensSuperLeague =
            new(37, "England", "FA Women's Super League", null, null);
        public static readonly Competition FIFAU20WorldCup =
            new(1470, "International", "FIFA U20 World Cup", null, null);
        public static readonly Competition FIFAWorldCup =
            new(43, "International", "FIFA World Cup", null, null);
        public static readonly Competition IndianSuperleague =
            new(1238, "India", "Indian Super league", null, null);
        public static readonly Competition LaLiga = new(11, "Spain", "La Liga", null, null);
        public static readonly Competition LigaProfesional =
            new(81, "Argentina", "Liga Profesional", null, null);
        public static readonly Competition Ligue1 = new(7, "France", "Ligue 1", null, null);
        public static readonly Competition MajorLeagueSoccer =
            new(44, "United States of America", "Major League Soccer", null, null);
        public static readonly Competition NorthAmericanLeague =
            new(116, "North and Central America", "North American League", null, null);
        public static readonly Competition NWSL =
            new(49, "United States of America", "NWSL", null, null);
        public static readonly Competition PremierLeague =
            new(2, "England", "Premier League", null, null);
        public static readonly Competition SerieA = new(12, "Italy", "Serie A", null, null);
        public static readonly Competition UEFAEuro = new(55, "Europe", "UEFA Euro", null, null);
        public static readonly Competition UEFAEuropaLeague =
            new(35, "Europe", "UEFA Europa League", null, null);
        public static readonly Competition UEFAWomensEuro =
            new(53, "Europe", "UEFA Women's Euro", null, null);
        public static readonly Competition WomensWorldCup =
            new(72, "International", "Women's World Cup", null, null);
    }
}
