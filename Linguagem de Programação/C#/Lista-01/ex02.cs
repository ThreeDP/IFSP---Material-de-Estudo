using System;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados.
            Console.WriteLine("Entre um valor em Graus Fahrenheit: ");
            int f = Convert.ToDouble(Console.ReadLine());

            //Conversão e saida.
            double c = (f - 32) * (5/9);
            Console.WriteLine("Graus Celsius:        " + c);
        }
    }
}
