using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diamantes24_06_2021.Dominio;

namespace Diamantes24_06_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            GeradorDiamante aux = new GeradorDiamante();
            Console.WriteLine(aux.GerarDima("c"));
        }

    }
}
