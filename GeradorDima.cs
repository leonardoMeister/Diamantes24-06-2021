using System;
using System.Collections.Generic;

namespace Diamantes24_06_2021
{
    public class GeradorDima
    {
        Dictionary<char, string> dicionario = new Dictionary<char, string>()
            {
              {'a',"                         A\n"},
              {'b',"                        B B\n"},
              {'c',"                       C   C\n"},
              {'d',"                      D     D\n"},
              {'e',"                     E       E\n"},
              {'f',"                    F         F\n"},
              {'g',"                   G           G\n"},
              {'h',"                  H             H\n"},
              {'i',"                 I               I\n"},
              {'j',"                J                 J\n"},
              {'k',"               K                   K\n"},
              {'l',"              L                     L\n"},
              {'m',"             M                       M\n"},
              {'n',"            N                         N\n"},
              {'o',"           O                           O\n"},
              {'p',"          P                             P\n"},
              {'q',"         Q                               Q\n"},
              {'r',"        R                                 R\n"},
              {'s',"       S                                   S\n"},
              {'t',"      T                                     T\n"},
              {'u',"     U                                       U\n"},
              {'v',"    V                                         V\n"},
              {'w',"   W                                           W\n"},
              {'x',"  X                                             X\n"},
              {'y'," Y                                               Y\n"},
              {'z',"Z                                                 Z\n"},
            };
        string Letras = "abcdefghijklmnopqrstuvwxyz";
        string diamante = "";
        public GeradorDima()
        {

        }

        public string GerarDima(string elemento)
        {
            elemento = elemento.ToLower();
            char auxElemento = elemento[0];

            ConcatenarDima(auxElemento);
            return diamante;
        }

        private void ConcatenarDima(char elemento)
        {
            for (int i = 0; i < Letras.Length; i++)
            {
                char x = Letras[i];
                diamante += dicionario[x];
                Console.WriteLine(diamante);
                if (x == elemento)
                {
                    Letras = Letras.Substring(0, i);
                    Letras = InverterString(Letras);
                    ConcatenarDima(elemento);
                }
            }
        }

        private string InverterString(string auxLetras)
        {
            char[] arrChar = auxLetras.ToCharArray();
            Array.Reverse(arrChar);
            return new String(arrChar);
        }
    }
}
