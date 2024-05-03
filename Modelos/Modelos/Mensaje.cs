using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Mensaje
    {
        public int Id {  get; set; }
        public int IdRemitente {  get; set; }
        public string Contenido {  get; set; }
        public double Tamaño { get; set; }
    }
}
