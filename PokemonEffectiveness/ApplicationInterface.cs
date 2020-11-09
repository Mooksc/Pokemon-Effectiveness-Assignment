using System;
using Newtonsoft.Json.Linq;

namespace PokemonEffectiveness
{
    class ApplicationInterface
    {
        public static void titleInterface()
        {
            Console.Write("--------------------------------------------" + "\n Pokemon Type Effectiveness Calculator\n" + "--------------------------------------------");
            Console.Write("\nEnter the name of a Pokemon to discover is strengths and weaknesses!\n");
        }

        public static string userQueryPrompt()
        {
            Console.Write("Pokemon: ");
            return Console.ReadLine();
        }

        public static void exitInfo()
        {
            Console.Write("Type 'EXIT' or 'QUIT' and press enter to close application");
        }

        public static void exitMessaging()
        {
            Console.Write("Closing Application... Gotta Catch em' All!");
        }

        public static void presentResponse(string pokemonName, string pokemonType, JToken damage_relations)
        {
            Console.WriteLine("\nPokemon: " + pokemonName);
            Console.WriteLine("Type: " + pokemonType + "\n");
            try
            {
                foreach (var key in JObject.FromObject(damage_relations))
                {
                    Console.WriteLine("\n" + key.Key + " :" + "\n");
                    foreach (var v in key.Value)
                    {
                        Console.WriteLine(v["name"]);
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }
    }
}
