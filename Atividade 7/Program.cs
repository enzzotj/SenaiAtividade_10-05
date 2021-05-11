using System;

namespace Atividade_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[15];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Coloque o {i+1}º número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] numinv = new int [numeros.Length];
            int c = 0;
            for (int i = numeros.Length; i > 0; i--) {
                numinv[c] = numeros[i-1];
                c++;
            }

            foreach (var item in numinv)
            {
                Console.Write($"{item}  ");
            }

        }
    }
}
