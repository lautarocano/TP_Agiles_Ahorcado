using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IngresarNombreVacio()
        {
            JuegoAhorcado game = new JuegoAhorcado();
            string nombre = "";
            Assert.AreNotEqual(game.setName(nombre),true);
        }

    }
}
