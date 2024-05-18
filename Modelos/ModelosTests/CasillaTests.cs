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
        public void AgregarMensajeTest()
        {
            Mensaje mensaje = new Mensaje();
            mensaje.Tamaño = 30;
            List<Mensaje> listaMensajes = new List<Mensaje> { mensaje };

            Casilla casilla = new Casilla();
            casilla.Tamaño = 1024;
            casilla.ListaMensajes = listaMensajes;

            Mensaje mensajeNuevo = new Mensaje();
            mensajeNuevo.Tamaño = 40;

            bool seAgrego = casilla.AgregarMensaje(mensajeNuevo);

            Assert.IsTrue(seAgrego);
        }

        [TestMethod()]
        public void AgregarMensajePesado()
        {
            Mensaje mensaje = new Mensaje();
            mensaje.Tamaño = 30;
            List<Mensaje> listaMensajes = new List<Mensaje> { mensaje };

            Casilla casilla = new Casilla();
            casilla.Tamaño = 1024;
            casilla.ListaMensajes = listaMensajes;

            Mensaje mensajePesado = new Mensaje();
            mensajePesado.Tamaño = 400000;

            bool seAgrego = casilla.AgregarMensaje(mensajePesado);

            Assert.IsFalse(seAgrego);
        }

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

            double resultado = casilla.CalcularEspacioDisponible();

            Assert.IsTrue(resultado == 994);
        }

    }
}