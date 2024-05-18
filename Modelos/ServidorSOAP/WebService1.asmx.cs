using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServidorSOAP
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        //Datos de ejemplo

        List<Casilla> ListaCasillas = new List<Casilla>
        {
            new Casilla { Id = 1, Nombre = "Martin Diaz", Tamaño = 50000,
                ListaMensajes = new List<Mensaje>
                {
                    new Mensaje {Id = 1, IdRemitente = 1, Contenido = "Buenos dias estimados, adjunto lo solicitado", Tamaño = 18 },
                    new Mensaje {Id = 2, IdRemitente = 1, Contenido = "Va de nuevo: Me olvide el adjunto. Saludos!", Tamaño = 1101 }
                }
            }
        };

        [WebMethod]
        public double CalcularEspacioTotal(int idCasilla)
        {
            Casilla casilla = ListaCasillas.Find(x => x.Id == idCasilla);

            double tamañoTotal = casilla.CalcularEspacioTotal();

            return tamañoTotal;
        }

        [WebMethod]
        public double CalcularEspacioDisponible(int idCasilla)
        {
            Casilla casilla = ListaCasillas.Find(x => x.Id == idCasilla);

            double espacioDisponible = casilla.CalcularEspacioDisponible();

            return espacioDisponible;
        }

        [WebMethod]
        public bool AgregarMensaje(int idCasillaDestinatario, Mensaje mensaje)
        {
            Casilla casilla = ListaCasillas.Find(x => x.Id == idCasillaDestinatario);

            bool espacioDisponible = casilla.AgregarMensaje(mensaje);

            return espacioDisponible;
        }
    }
}
