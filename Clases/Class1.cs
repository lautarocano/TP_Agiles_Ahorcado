using System;

namespace Clases
{
    public class JuegoAhorcado
    {

        public string nombreJugador;
        public bool setName(string nombre)
        {
            if (nombre == "")
            {
                return false;
            }
            else { 
                this.nombreJugador = nombre;
                return true;
            }
        }

    }
}
