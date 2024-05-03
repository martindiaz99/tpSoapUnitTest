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

        public double CalcularEspacioTotal()
        {
            double tamañoTotal = 0;

            foreach (Mensaje mensaje in ListaMensajes)
            {
                tamañoTotal = tamañoTotal + mensaje.Tamaño;
            }

            return tamañoTotal;
        }

        public double CalcularEspacioLibre()
        {
            double tamañoLibre = Tamaño - CalcularEspacioTotal();

            return tamañoLibre;
        }

    }
}
