using Microsoft.VisualStudio.TestTools.UnitTesting;
using Diamantes24_06_2021;
using System;
namespace Diamante.Testes
{
    [TestClass]
    public class TesteInverterString
    {
        [TestMethod]
        public void DeveInverterString()
        {
            GeradorDima dima = new GeradorDima();

            string letrasAlfabeto = "Banana";
            string auxString = dima.InverterString(letrasAlfabeto);

            Assert.AreEqual(auxString, "ananaB");
        }
    }
}
