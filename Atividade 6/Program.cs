using System;

namespace Atividade_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Digite o {i + 1}° nome= ");
                nomes[i] = Console.ReadLine().ToUpper();
            }
            Console.Write("Qual nome desseja bucar= ");
            string buscar = Console.ReadLine().ToUpper();
            bool verificado = false;

            foreach (var item in nomes)
            {
                if (item == buscar)
                {
                    verificado = true;
                }
            }
            if (verificado)
            {
                Console.WriteLine("Seu nome está na lista {0} :)", buscar);
            } else {
                Console.WriteLine("Seu nome não está na lista {0} :(", buscar);
            }


        }
    }
}
