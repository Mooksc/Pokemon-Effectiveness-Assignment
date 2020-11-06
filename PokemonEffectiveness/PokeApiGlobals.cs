using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace PokemonEffectiveness
{
    public static class PokeApiGlobals
    {
        public static readonly HttpClient httpClient = new HttpClient();
        public static string PokeApiURL = "https://pokeapi.co/api/v2/";
    }
}
