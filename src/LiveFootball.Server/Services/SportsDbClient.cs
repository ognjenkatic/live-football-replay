using LiveFootball.Server.DTOs;
using System.Text.Json;
using System.Web;
using System.Collections.Generic;

namespace LiveFootball.Server.Services
{
    public class SportsDbClient(HttpClient client)
    {
        private readonly HttpClient client = client;
        private static Dictionary<string, Player?> playerCache = new Dictionary<string, Player?>();
        private static Dictionary<string, Team?> teamCache = new Dictionary<string, Team?>();

        public async Task<Player?> FindPlayer(string name)
        {
            if (!playerCache.ContainsKey(name))
            {
                var response = await client.GetAsync($"api/v1/json/3/searchplayers.php?p={HttpUtility.UrlEncode(name)}");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    playerCache[name] = JsonSerializer.Deserialize<SportsDbFindPlayerResponse>(content)?.Players?.FirstOrDefault();
                }
                else
                {
                    playerCache[name] = default;
                }
            }

            return playerCache[name];
        }

        public async Task<Team?> FindTeam(string name)
        {
            if (!teamCache.ContainsKey(name))
            {
                var response = await client.GetAsync($"api/v1/json/3/searchteams.php?t={HttpUtility.UrlEncode(name)}");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    teamCache[name] = JsonSerializer.Deserialize<SportsDbTeamResponse>(content)?.Teams?.FirstOrDefault();
                }
                else
                {
                    teamCache[name] = default;
                }
            }

            return teamCache[name];
        }
    }
}