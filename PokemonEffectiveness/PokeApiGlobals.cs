using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace PokemonEffectiveness
{
    public static class PokeApiGlobals
    {
        public static readonly HttpClient httpClient = new HttpClient();
        public static string PokeApiURL = "https://pokeapi.co/api/v2/";

        public static async Task<JObject> returnApiCall(string query)
        {
            var result = await httpClient.GetAsync(PokeApiURL + query);
            string content = await result.Content.ReadAsStringAsync();
            JObject joResponse = JObject.Parse(content);
            return joResponse;
        }
    }
}
