using System;

namespace Atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            for (int i = 0;i<numeros.Length; i++)
            {
                Console.Write("Digite um número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numeros);
            Console.WriteLine();
            foreach (int i in numeros);

            Console.WriteLine("O menor número é: {0}",numeros[0]);
            Console.WriteLine("O menor número é: {0}",numeros[9]);
        }
    }
}
