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
            Assert.AreEqual(game.setName(nombre),"Nombre invalido");
        }

        [TestMethod]
        public void IngresarNombreLargo()
        {
            JuegoAhorcado game = new JuegoAhorcado();
            string nombre = "Guidolautarojuanmartin";
            Assert.AreEqual(game.setName(nombre), "Nombre invalido");
        }

        [TestMethod]
        public void IngresarNombreConEspacios()
        {
            JuegoAhorcado game = new JuegoAhorcado();
            string nombre = "Tigre Bengala";
            Assert.AreEqual(game.setName(nombre), "Nombre invalido");
        }

        [TestMethod]
        public void IngresarNombreConCaracEspeciales()
        {
            JuegoAhorcado game = new JuegoAhorcado();
            string nombre = "Martin!!#$%&";
            Assert.AreEqual(game.setName(nombre), "Nombre invalido");
        }

        [TestMethod]
        public void ArriesgarPalabraVacio()
        {
            JuegoAhorcado game = new JuegoAhorcado();
            game.setName("Martin");
            Assert.AreEqual(game.arriesgarPalabra(""), "Palabra invalida");

        }

        [TestMethod]
        public void ArriesgarPalabraIncorrecta()
        {
            JuegoAhorcado game = new JuegoAhorcado();
            game.setName("Martin");
            Assert.AreEqual(game.arriesgarPalabra("derrota"), "Palabra incorrecta");

        }

        [TestMethod]
        public void ArriesgarPalabraCorrecta()
        {
            JuegoAhorcado game = new JuegoAhorcado();
            game.setName("Martin");
            Assert.AreEqual(game.arriesgarPalabra("hola"), "Palabra correcta");

        }


    }
}
