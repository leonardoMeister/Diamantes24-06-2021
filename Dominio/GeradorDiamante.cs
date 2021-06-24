using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamantes24_06_2021.Dominio
{
    public class GeradorDiamante
    {
        Dictionary<char, string> dicionario = new Dictionary<char, string>()
            {
              {'a',"               A"},
              {'b', "             B B"},
              {'c',"             C   C"},
              {'c',"            D     D"},
            };
        string Letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public GeradorDiamante()
        {
            
        }

        public string GerarDima(string elemento)
        {
            elemento = elemento.ToLower();
            string diamante

        }

    }
}
