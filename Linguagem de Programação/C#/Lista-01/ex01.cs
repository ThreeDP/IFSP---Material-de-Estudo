using System;

namespace EX01
{   
    static class Constants
    {
        public const float centimeter = 100.00f;
        public const float millimeter = 1000.00f;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre um valor em metros: ");
            double meters = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Correspondente em centímetros " + (meters * Constants.centimeter));
            Console.WriteLine("Correspondente em milímetros  " + (meters * Constants.millimeter));
        }
    }
}
