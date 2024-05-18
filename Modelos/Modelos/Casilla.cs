using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Casilla
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Tamaño { get; set; }
        public List<Mensaje> ListaMensajes { get; set; }

        public bool AgregarMensaje(Mensaje mensaje)
        {
            double capacidadConNuevoMensaje = CalcularEspacioTotal() + mensaje.Tamaño;

            if (capacidadConNuevoMensaje < Tamaño)
            {
                ListaMensajes.Add(mensaje);
                return true; 
            }
            else
            {
                return false;
            }
        }

        public double CalcularEspacioTotal()
        {
            double tamañoTotal = 0;

            foreach (Mensaje mensaje in ListaMensajes)
            {
                tamañoTotal = tamañoTotal + mensaje.Tamaño;
            }

            return tamañoTotal;
        }

        public double CalcularEspacioDisponible()
        {
            double tamañoLibre = Tamaño - CalcularEspacioTotal();

            return tamañoLibre;
        }

    }
}
