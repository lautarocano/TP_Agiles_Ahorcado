using System;
using System.Linq;

namespace Clases
{
    public class JuegoAhorcado
    {

        public string nombreJugador;
        private string palabraSecreta;
        public JuegoAhorcado()
        {
            this.palabraSecreta = "hola";
        }

        

        public string setName(string nombre)
        {
            if (nombre == "" || nombre.Length > 20  || !nombre.All(char.IsLetterOrDigit))
            {
                return "Nombre invalido";
            }
            else { 
                this.nombreJugador = nombre;
                return "Nombre valido";
            }
        }

        public string arriesgarPalabra(string palabra)
        {
            if(string.IsNullOrWhiteSpace(palabra))
            {
                return "Palabra invalida";
            }
            else if(palabra == this.palabraSecreta){
                return "Palabra correcta";

            }
            else
            {
                return "Palabra incorrecta";
            }

        }

    }
}
