using System;

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
    }
}
