using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;

namespace RiotAPIdemo
{
    public class SummonerV4
    {
        public static readonly string ApiKey2 = "RGAPI-b7c38ffa-68f1-47f1-90ab-8558259cc098";
        public static Uri APIBaseAddress = new Uri("https://na1.api.riotgames.com/lol/summoner/v4/summoners");
        public static Uri APIBaseAddress2 = new Uri("https://na1.api.riotgames.com/lol/champion-mastery/v4/champion-masteries");
        public string ApiKey;
        public HttpClient Client { get; set; }

        public SummonerV4(string ApiKey)
        {
            this.ApiKey = ApiKey;
            Client = new HttpClient
            {
                BaseAddress = APIBaseAddress2
            };

        }

        public ChampionMastery GetChampionMastery(string encryptedSummonerID, long championId)
        {
            var uriBuilder = new UriBuilder($"{APIBaseAddress2}/by-summoner/{encryptedSummonerID}/by-champion/{championId}");
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["api_key"] = ApiKey;
            uriBuilder.Query = query.ToString();
            string requestUri = uriBuilder.ToString();
            //Result call is a blocking call
            var response = Client.GetAsync(requestUri).Result;
            if (response.IsSuccessStatusCode == false)
            {
                throw new Exception($"Request is bad, yo. Response: {response}");
            }

            string jsonResponse = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<ChampionMastery>(jsonResponse);

        }

        public Summoner GetSummonerByName(string summonerName)
        {
            var uriBuilder = new UriBuilder($"{APIBaseAddress}/by-name/{summonerName}");
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["api_key"] = ApiKey;
            uriBuilder.Query = query.ToString();
            string requestUri = uriBuilder.ToString();
            //Result call is a blocking call
            var response = Client.GetAsync(requestUri).Result;
            if (response.IsSuccessStatusCode == false)
            {
                throw new Exception($"Request is bad, yo. Response: {response.StatusCode}");
            }

            string jsonResponse = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<Summoner>(jsonResponse);
        }

    }
}
