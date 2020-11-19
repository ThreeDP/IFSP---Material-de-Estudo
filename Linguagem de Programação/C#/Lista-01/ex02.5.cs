using System;

namespace EX01
{

    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados.
            Console.WriteLine("Entre um valor em Graus Fahrenheit: ");
            double f = Convert.ToDouble(Console.ReadLine());

            //Conversão e saida.
            double c = (f - 32.00f) * (5.00f / 9.00f);
            Console.WriteLine("Graus Celsius:        {0:F2}.", c);
        }
    }
}
