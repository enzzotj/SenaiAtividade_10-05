using System;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a descrição do produto (nome)?");
            string produto = Console.ReadLine();
            Console.WriteLine($"Qual é a quantidade adquirida de {produto}?");
            int quant = int.Parse(Console.ReadLine());
            Console.WriteLine($"Qual é o preço de {produto}?");
            double preco = double.Parse(Console.ReadLine());
            double pt = preco * quant;

            if (quant <= 5) {
                double desca = 0.8;
                Console.WriteLine($"Object valor será = {Math.Round(Desc(desca,pt), 2)}");
            }
            else if (quant > 5 && quant <= 10){
                double desca = 0.7;
                Console.WriteLine($"Object valor será = {Math.Round(Desc(desca,pt), 2)}");
            } else {
                double desca = 0.5;
                Console.WriteLine($"Object valor será = {Math.Round(Desc(desca,pt), 2)}");
            }
        }
        static double Desc(double d, double vt){
            return  d * vt;
        }
    }
}
