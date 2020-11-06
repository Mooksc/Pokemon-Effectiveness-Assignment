using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace PokemonEffectiveness.Test
{
    [TestClass]
    public class PokeApiCallsTest
    {
        [DataTestMethod]
        [DataRow("charmander")]
        [DataRow("koffing")]
        [DataRow("steelix")]
        public async Task Test_returnType_returnTypeByPokemonName(string value)
        {
            var val = await PokemonEffectiveness.PokeApiCalls.returnTypeByPokemonName(value);
            Assert.IsInstanceOfType(val, typeof(string), "Error - Expected String, got " + val.GetType());
        }

        [TestMethod]
        [DataRow("fire")]
        [DataRow("poison")]
        [DataRow("psychic")]
        public async Task Test_returnType_returnDamageRelationsByTypeName(string value)
        {
            var val = await PokemonEffectiveness.PokeApiCalls.returnDamageRelationsByTypeName(value);
            Assert.IsInstanceOfType(val, typeof(JToken), "Error - Expected JToken, got " + val.GetType());
        }
    }
}
