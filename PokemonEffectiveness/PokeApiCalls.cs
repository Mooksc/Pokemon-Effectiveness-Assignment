using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace PokemonEffectiveness
{
    public static class PokeApiCalls
    {
        public static async Task<string> returnTypeByPokemonName(string pokemonName)
        {
            var response = await PokeApiGlobals.returnApiCall("pokemon/" + pokemonName);
            return response["types"][0]["type"]["name"].ToObject<string>();
        }
    }
}
