using System;

namespace EX03
{

    class Program
    {
        static void Main(string[] args)
        {
            double imc = 0.00f;
            //Entrada de dados
            Console.WriteLine("Entre o seu peso:      ");
            double weightPerson = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre a sua altura:    ");
            double heightPerson = Convert.ToDouble(Console.ReadLine());

            imc = weightPerson / (heightPerson * heightPerson);

            Console.WriteLine("IMC............:  {0:F2}.", imc);
        }
    }
}
