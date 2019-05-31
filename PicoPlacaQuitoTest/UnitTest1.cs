using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PicoPlacaQuito;

namespace PicoPlacaQuitoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Caso_Pico_Placa_No_Circulacion_Miercoles_Mañana()
        {
            string fecha = "03/04/2019";
            string placa = "PCJ956";
            string hora = "9:00";
            bool expected = false;

            Auto auto = new Auto(1, placa);

            bool resultado = auto.PuedeSalir(fecha, placa, hora);
            Assert.AreEqual(expected, resultado);

        }

        [TestMethod]
        public void Caso_Pico_Placa_Circulacion_Miercoles()
        {
            string fecha = "10/04/2019";
            string placa = "PCJ956";
            string hora = "12:00";
            bool expected = true;

            Auto auto = new Auto(1, placa);

            bool resultado = auto.PuedeSalir(fecha, placa, hora);
            Assert.AreEqual(expected, resultado);

        }

        [TestMethod]
        public void Caso_Pico_Placa_No_Circulacion_Miercoles_Tarde()
        {
            string fecha = "17/04/2019";
            string placa = "PCJ956";
            string hora = "17:00";
            bool expected = false;

            Auto auto = new Auto(1, placa);

            bool resultado = auto.PuedeSalir(fecha, placa, hora);
            Assert.AreEqual(expected, resultado);

        }

        [TestMethod]
        public void Caso_Pico_Placa_Circulacion_Fin_Semana()
        {
            string fecha = "06/04/2019";
            string placa = "PCJ956";
            string hora = "8:00";
            bool expected = true;

            Auto auto = new Auto(1, placa);

            bool resultado = auto.PuedeSalir(fecha, placa, hora);
            Assert.AreEqual(expected, resultado);

        }


    }
}
