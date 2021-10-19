using System;
using System.Linq;

namespace Clases
{
    public class JuegoAhorcado
    {

        public string nombreJugador;
        private string palabraSecreta;
        private string estadoPalabra;
        char[] palabraAux;
        char[] estadoAux;
        public JuegoAhorcado()
        {
            this.palabraSecreta = "hola";
            this.estadoPalabra = "____";
            this.palabraAux = palabraSecreta.ToCharArray();
            this.estadoAux = estadoPalabra.ToCharArray();
        }

        public JuegoAhorcado(string palabraAsignada)
        {
            this.palabraSecreta = palabraAsignada.ToLower();
            this.estadoPalabra = "";
            for (int j = 0; j < palabraAsignada.Length; j++)
            {
                this.estadoPalabra += "_";
            }
            this.palabraAux = palabraSecreta.ToCharArray();
            this.estadoAux = estadoPalabra.ToCharArray();
        }


        public string setName(string nombre)
        {
            if (nombre == "" || nombre.Length > 20 || !nombre.All(char.IsLetterOrDigit))
            {
                return "Nombre invalido";
            }
            else
            {
                this.nombreJugador = nombre;
                return "Nombre valido";
            }
        }

        public string arriesgarPalabra(string palabra)
        {
            if (string.IsNullOrWhiteSpace(palabra))
            {
                return "Palabra invalida";
            }
            else if (palabra.ToLower() == this.palabraSecreta)
            {
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
                    int cont = 0;
                    foreach (char c in palabraSecreta)
                    {
                        if (c == letra)
                        {
                            estadoAux[cont] = letra;
                        }
                        cont++;
                    }
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

        public string mostrarEstado()
        {
            string estadoreturn = new string(estadoAux);
            return estadoreturn;

        }
    }
}
