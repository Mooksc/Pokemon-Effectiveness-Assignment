using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace PokemonEffectiveness
{
    public static class PokeApiCalls
    {
        public static async Task<string> returnTypeByPokemonName(string pokemonName)
        {
            try
            {
                var response = await PokeApiGlobals.returnApiCall("pokemon/" + pokemonName.ToLower());
                return response["types"][0]["type"]["name"].ToObject<string>();
            } catch
            {
                Console.WriteLine(PokeApiGlobals.nameError);
                return PokeApiGlobals.nameError;
            }
            
        }

        public static async Task<JToken> returnDamageRelationsByTypeName(string type)
        {
            var response = await PokeApiGlobals.returnApiCall("type/" + type);
            return response["damage_relations"];
        }
    }
}
