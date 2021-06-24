using Microsoft.VisualStudio.TestTools.UnitTesting;
using Diamantes24_06_2021;
using System;

namespace Diamante.Testes
{
    [TestClass]
    public class TesteDiamante
    {
        [TestMethod]
        public void DeveRetornarFalso()
        {
            GeradorDima dima = new GeradorDima();

            string auxDima = dima.GerarDiamante("a");

            Assert.AreEqual(auxDima, "False");
        }

        [TestMethod]
        public void DeveRetornarDimaDeAaZ()
        {
            GeradorDima dima = new GeradorDima();

            string auxDima = dima.GerarDiamante("z");

            Assert.AreEqual(auxDima, "                         A\n                        B B\n                       C   C\n                      D     D\n                     E       E\n                    F         F\n                   G           G\n                  H             H\n                 I               I\n                J                 J\n               K                   K\n              L                     L\n             M                       M\n            N                         N\n           O                           O\n          P                             P\n         Q                               Q\n        R                                 R\n       S                                   S\n      T                                     T\n     U                                       U\n    V                                         V\n   W                                           W\n  X                                             X\n Y                                               Y\nZ                                                 Z\n Y                                               Y\n  X                                             X\n   W                                           W\n    V                                         V\n     U                                       U\n      T                                     T\n       S                                   S\n        R                                 R\n         Q                               Q\n          P                             P\n           O                           O\n            N                         N\n             M                       M\n              L                     L\n               K                   K\n                J                 J\n                 I               I\n                  H             H\n                   G           G\n                    F         F\n                     E       E\n                      D     D\n                       C   C\n                        B B\n                         A\n");
        }


        [TestClass]
        public class TesteLetrasDiamante
        {
            [TestMethod]
            public void DeveRetornarFalso()
            {
                GeradorDima dima = new GeradorDima();

                string auxDima = dima.GerarDiamante("a");

                Assert.AreEqual(auxDima, "False");
            }
        }
    }
}
    

                    
        
        
        
        
    






    

