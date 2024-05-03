using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Tests
{
    [TestClass()]
    public class CasillaTests
    {
        [TestMethod()]
        public void CalcularEspacioTotalTest()
        {
            Mensaje mensaje = new Mensaje();
            mensaje.Tamaño = 30;
            List<Mensaje> listaMensajes = new List<Mensaje> { mensaje };

            Casilla casilla = new Casilla();
            casilla.Tamaño = 1024;
            casilla.ListaMensajes = listaMensajes;

            double resultado = casilla.CalcularEspacioTotal();

            Assert.IsTrue(resultado == 30);
        }


        [TestMethod()]
        public void CalcularEspacioLibreTest()
        {
            Mensaje mensaje = new Mensaje();
            mensaje.Tamaño = 30;
            List<Mensaje> listaMensajes = new List<Mensaje> { mensaje };

            Casilla casilla = new Casilla();
            casilla.Tamaño = 1024;
            casilla.ListaMensajes = listaMensajes;

            double resultado = casilla.CalcularEspacioLibre();

            Assert.IsTrue(resultado == 994);
        }
    }
}