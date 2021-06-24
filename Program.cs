using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamantes24_06_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            GeradorDima aux = new GeradorDima();

            string auxx = aux.GerarDima("z");

            Console.WriteLine(aux.GerarDima("c"));
            Console.WriteLine(aux.GerarDima("a"));
            Console.WriteLine(aux.GerarDima("d"));

        }

    }
}
