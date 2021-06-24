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
        string letrasAlfabeto = "abcdefghijklmnopqrstuvwxyz";
        string textoDiamante = "";
        public GeradorDima()
        {
        }

        public string GerarDiamante(string letraSelecionada)
        {
            if (letraSelecionada.ToLower()[0] == 'a') return "False";
            ConcatenarDiamante(letraSelecionada.ToLower()[0]);
            
            return textoDiamante;
        }

        private void ConcatenarDiamante(char letraSelecionada)
        {
            for (int i = 0; i < letrasAlfabeto.Length; i++)
            {
                char PosicaoLetrasAlfabeto = letrasAlfabeto[i];
                textoDiamante += dicionario[PosicaoLetrasAlfabeto];
                if (PosicaoLetrasAlfabeto == letraSelecionada)
                {
                    letrasAlfabeto = letrasAlfabeto.Substring(0, i);
                    letrasAlfabeto = InverterString(letrasAlfabeto);
                    ConcatenarDiamante(letraSelecionada);
                }
            }
        }

        public string InverterString(string auxLetras)
        {
            char[] arrayLetrasAlfabeto = auxLetras.ToCharArray();
            Array.Reverse(arrayLetrasAlfabeto);
            return new string(arrayLetrasAlfabeto);
        }
    }
}