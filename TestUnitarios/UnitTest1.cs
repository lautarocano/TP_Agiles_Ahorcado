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
            JuegoAhorcado game = new JuegoAhorcado("Adios");
            game.setName("Martin");
            Assert.AreEqual(game.arriesgarPalabra("Adios"), "Palabra correcta");
        }

        [TestMethod]
        public void ArriesgarEspacioBlanco()
        {
            JuegoAhorcado game = new JuegoAhorcado("Adios");
            game.setName("Martin");
            Assert.AreEqual(game.arriesgarLetra(' '), false);
        }

        [TestMethod]
        public void ArriesgarNumero()
        {
            JuegoAhorcado game = new JuegoAhorcado("Adios");
            game.setName("Martin");
            Assert.AreEqual(game.arriesgarLetra('3'), false);
        }

        [TestMethod]
        public void ArriesgarLetraValida()
        {
            JuegoAhorcado game = new JuegoAhorcado("Adios");
            game.setName("Martin");
            Assert.AreEqual(game.arriesgarLetra('d'), true);
        }


        [TestMethod]
        public void ValidarLetraIncorrecta()
        {
            JuegoAhorcado game = new JuegoAhorcado("Adios");
            game.setName("Martin");
            Assert.AreEqual(game.validarLetra('z'), "Letra incorrecta");
        }

        [TestMethod]
        public void ValidarLetraCorrecta()
        {
            JuegoAhorcado game = new JuegoAhorcado("Adios");
            game.setName("Martin");
            Assert.AreEqual(game.validarLetra('d'), "Acierto");
        }


        [TestMethod]
        public void ValidarLetraCorrectaNoCaseSensitive()
        {
            JuegoAhorcado game = new JuegoAhorcado("Adios");
            game.setName("Martin");
            Assert.AreEqual(game.validarLetra('D'), "Acierto");
        }


        [TestMethod]
        public void ValidarEstadoLetra()
        {
            JuegoAhorcado game = new JuegoAhorcado("Adios");
            game.setName("Martin");
            game.validarLetra('d');
            Assert.AreEqual(game.mostrarEstado(), "_d___");
        }


        [TestMethod]
        public void EstadoLetraDistintoLugar()
        {
            JuegoAhorcado game = new JuegoAhorcado("Adios");
            game.setName("Martin");
            game.validarLetra('d');
            Assert.AreNotEqual(game.mostrarEstado(), "__d__");
        }


        [TestMethod]
        public void UnIntentoMenos()
        {
            JuegoAhorcado game = new JuegoAhorcado("Adios");
            game.setName("Martin");
            game.validarLetra('e');
            Assert.AreEqual(game.intentosRestantes, 4);
        }
        

        [TestMethod]
        public void NoRestaIntento()
        {
            JuegoAhorcado game = new JuegoAhorcado("Adios");
            game.setName("Martin");
            game.validarLetra('d');
            Assert.AreEqual(game.intentosRestantes, 5);
        }
        







    }
}
