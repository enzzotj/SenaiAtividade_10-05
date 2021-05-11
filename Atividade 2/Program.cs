using System;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você ira abastecer com álcool ou gasolina? (a/g)");
            string combustível = Console.ReadLine().ToLower();
            Console.WriteLine("Quantos litros ira abastecer?");
            int litros = int.Parse(Console.ReadLine());

            switch (combustível) {
                case "a":
                    double precoa = 4.90;
                    if (litros <= 20) {
                        double desc = precoa * 0.7;
                        double total = desc * litros;
                        Console.WriteLine($"O valor deu = {Math.Round(total, 2)}");
                    } else {
                        double desc = precoa * 0.5;
                        double total = desc * litros;
                        Console.WriteLine($"O valor deu = {Math.Round(total, 2)}");
                    }
                break;
                case "g":
                    double precog = 5.30;
                    if (litros <= 20) {
                        double desc = precog * 0.6;
                        double total = desc * litros;
                        Console.WriteLine($"O valor deu = {Math.Round(total, 2)}");
                    } else {
                        double desc = precog * 0.4;
                        double total = desc * litros;
                        Console.WriteLine($"O valor deu = {Math.Round(total, 2)}");
                    }
                break;
                
            }
        }
    }
}
