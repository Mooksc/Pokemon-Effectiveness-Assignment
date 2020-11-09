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
        [DataRow("Koffing")]
        [DataRow("STEELIX")]
        public async Task Test_returnType_returnTypeByPokemonName(string value)
        {
            var val = await PokemonEffectiveness.PokeApiCalls.returnTypeByPokemonName(value);
            Assert.IsInstanceOfType(val, typeof(string), "Error - Expected String, got " + val.GetType());
        }

        [DataTestMethod]
        [DataRow("this_is_invalid")]
        [DataRow("ccharmander")]
        [DataRow("1234567890-=")]
        public async Task NegativeTest_returnValue_returnTypeByPokemonName(string value)
        {
            var val = await PokemonEffectiveness.PokeApiCalls.returnTypeByPokemonName(value);
            Assert.AreEqual(val, PokeApiGlobals.nameError);
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
