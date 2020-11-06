using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace PokemonEffectiveness.Test
{
    [TestClass]
    public class PokeApiGlobalsTest
    {
        [DataTestMethod]
        [DataRow("type/")]
        [DataRow("pokemon/")]
        public async Task Test_returnType_returnApiCall(string value)
        {
            var val = await PokemonEffectiveness.PokeApiGlobals.returnApiCall(value);
            Assert.IsInstanceOfType(val, typeof(JObject), "Error - Expected JObject, got " + val.GetType());
        }
    }
}
