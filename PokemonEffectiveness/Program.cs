namespace PokemonEffectiveness
{
    class Program
    {
        static void Main(string[] args)
        {
            // Present title interface
            ApplicationInterface.titleInterface();

            // Store user query as variable
            string query = ApplicationInterface.userQueryPrompt();

            // Pass user query to returnTypeByPokemonName method
            string pokemonType = PokeApiCalls.returnTypeByPokemonName(query).GetAwaiter().GetResult();

            // Pass returnTypeByPokemonName return value to returnDamageRelationsByTypeName
            var damage_relations = PokeApiCalls.returnDamageRelationsByTypeName(pokemonType).GetAwaiter().GetResult();

            // Present query, pokemon type and damage_relation response to console
            ApplicationInterface.presentResponse(query, pokemonType, damage_relations);
        }
    }
}
