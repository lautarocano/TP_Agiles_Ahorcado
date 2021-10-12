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

        public JuegoAhorcado(string palabraAsignada)
        {
            this.palabraSecreta = palabraAsignada.ToLower();
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
            else if(palabra.ToLower() == this.palabraSecreta){
                return "Palabra correcta";

            }
            else
            {
                return "Palabra incorrecta";
            }
        }


        public bool arriesgarLetra(char letra)
        {
            if (char.IsLetter(letra))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string validarLetra(char letra)
        {
            if (arriesgarLetra(letra))
            {
                if (palabraSecreta.Contains(char.ToLower(letra)))
                {
                    return "Acierto";
                }
                else
                {
                    return "Letra incorrecta";
                }
        }
            else
            {
                return "Letra invalida";
            }
        }

    }
}
