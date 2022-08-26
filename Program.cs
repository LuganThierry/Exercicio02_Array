using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;

namespace TP.Aula03Exer02
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            int[] pontos = new int[6] { 4, 5, 6, 4, 8, 1 };

            int[] entrada = new int[pontos.Length];
            Array.Copy(pontos, entrada, pontos.Length);

            int[] novoarray = new int[entrada.Length];
            Array.Copy(entrada, novoarray, entrada.Length);

            Array.Sort(novoarray);
            Array.Reverse(novoarray);    

            Dictionary<int, int> ranks = new Dictionary<int, int>();

            int rank = 1;

            for (int i = 0; i < novoarray.Length; i++)
            {
                int element = novoarray[i];

                if (!ranks.ContainsKey(element))
                {
                    ranks[element] = rank;
                    rank++;
                }
            }

            for (int j = 0; j < entrada.Length; j++)
            {
                entrada[j] = ranks[entrada[j]];
            }

            for (int i = 0; i < pontos.Length; i++)
            {
                Console.WriteLine($"Pontuação: {pontos[i]} | Colocação {entrada[i]}");
            }



        }

    }

}
