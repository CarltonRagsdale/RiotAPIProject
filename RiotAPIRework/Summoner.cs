using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace RiotAPIdemo
{
    public class Summoner
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("accountId")]
        public string AccountID { get; set; }

        [JsonProperty("puuid")]
        public string Puuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("revisionDate")]
        public long RevisionDate { get; set; }

        [JsonProperty("profileIconId")]
        public int ProfileIconID { get; set; }

        [JsonProperty("summonerLevel")]
        public long SummonerLevel { get; set; }
    }

    public class ChampionMastery
    {
        [JsonProperty("chestGranted")]
        public Boolean ChestGranted { get; set; }

        [JsonProperty("championLevel")]
        public int ChampionLevel { get; set; }

        [JsonProperty("championPoints")]
        public int ChampionPoints { get; set; }

        [JsonProperty("championId")]
        public long ChampionId { get; set; }

        [JsonProperty("championPointsUntilNextLevel")]
        public long ChampionPointsUntilNextLevel { get; set; }

        [JsonProperty("lastPlayTime")]
        public long LastPlayTime { get; set; }

        [JsonProperty("tokensEarned")]
        public int TokensEarned { get; set; }

        [JsonProperty("championPointsSinceLastLevel")]
        public long ChampionPointsSinceLastLevel { get; set; }

        [JsonProperty("summonerId")]
        public string SummonerId { get; set; }
    }
}
