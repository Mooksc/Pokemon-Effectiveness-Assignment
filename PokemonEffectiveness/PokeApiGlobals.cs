using System.Net.Http;

namespace PokemonEffectiveness
{
    public static class PokeApiGlobals
    {
        public static readonly HttpClient httpClient = new HttpClient();
        public static string PokeApiURL = "https://pokeapi.co/api/v2/";
    }
}
