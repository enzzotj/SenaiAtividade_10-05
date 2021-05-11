using System;

namespace Atividade_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual tabuada se gostaria ver de de 0 á 10?");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (n >=0 && n<=10) {
                
                for(int i = 1; i<= 10; i++) {
                    Console.WriteLine(n + " X " + i + " = " + n*i);
                }

            } else {
                Console.WriteLine("Seu numero é maior que foi pedido :(");
            }
        }
    }
}
