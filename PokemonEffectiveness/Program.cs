﻿using System.Linq;

namespace PokemonEffectiveness
{
    class Program
    {
        static void Main(string[] args)
        {
            // Present title interface
            ApplicationInterface.titleInterface();

            while (PokeApiGlobals.keepAlive)
            {
                ApplicationInterface.exitInfo();

                // Store user query as variable
                string query = ApplicationInterface.userQueryPrompt();

                // Check user query for an exit prompt
                if (PokeApiGlobals.exitTerms.Any(query.ToUpper().Contains))
                {
                    ApplicationInterface.exitMessaging();
                    PokeApiGlobals.keepAlive = false;
                } else
                {
                    // Pass user query to returnTypeByPokemonName method
                    string pokemonType = PokeApiCalls.returnTypeByPokemonName(query).GetAwaiter().GetResult();

                    if (pokemonType != PokeApiGlobals.nameError)
                    {
                        // Pass returnTypeByPokemonName return value to returnDamageRelationsByTypeName
                        var damage_relations = PokeApiCalls.returnDamageRelationsByTypeName(pokemonType).GetAwaiter().GetResult();

                        // Present query, pokemon type and damage_relation response to console
                        ApplicationInterface.presentResponse(query, pokemonType, damage_relations);
                    }
                }
            } 
        }
    }
}
