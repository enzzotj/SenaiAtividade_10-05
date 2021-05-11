using System;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o ano atual?");
            int anot = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o ano que você nasceu?");
            int anon = int.Parse(Console.ReadLine());
            int idade;
            idade = anot - anon;
            if (idade >= 16){
                Console.WriteLine("Você ja pode votar :)");
            }else {
                Console.WriteLine("Você ainda não pode votar :(");
            }

        }
    }
}
