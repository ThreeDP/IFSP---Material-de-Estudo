using System;

namespace LISTA_01
{
    class Program
    {
        static class Constants
        {
            public const float centimeter = 100.00f;
            public const float millimeter = 1000.00f;
            public const float salaryIncrease = 0.25f;
        }

        // Menu de escolha de programas.
        static void Menu()
        {
            Console.WriteLine("Entre o numero do exercicio para executar:  \n");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Exercicio........:  " + (i + 1));
            }
            Console.Write(">>>  ");
        }


        // Exercicio 01.
        static void Ex01()
        {
            Console.WriteLine("Entre um valor em metros: ");
            double meters = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Correspondente em centímetros " + (meters * Constants.centimeter));
            Console.WriteLine("Correspondente em milímetros  " + (meters * Constants.millimeter));
        }

        // Exercicio 02.
        static void Ex02()
        {
            //Entrada de dados.
            Console.WriteLine("Entre um valor em Graus Fahrenheit: ");
            double f = Convert.ToDouble(Console.ReadLine());

            //Conversão e saida.
            double c = (f - 32.00f) * (5.00f / 9.00f);
            Console.WriteLine("Graus Celsius.........:   {0:F2}", c);

            //Entrada de dados.
            Console.WriteLine("Entre um valor em Graus Fahrenheit: ");
            int intF = int.Parse(Console.ReadLine());

            //Conversão e saida.
            int intC = (intF - 32) * (5 / 9);
            Console.WriteLine("Graus Celsius.........:   " + intC);
        }

        // Exercicio 03.
        static void Ex03()
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

        // Exercicio 04.
        static void Ex04()
        {
            // declaração de variaveis
            double[,] array = new double[3, 2];
            double x = 0.00f;
            double z = 0.00f;
            double medP = 0.00f;

            // Entrada de dados
            for (int i = 0; i <= 2; i++)
            {
                for (int y = 0; y <= 1; y++)
                {
                    switch (y + 1)
                    {
                        case 1:
                            Console.WriteLine("Entre um numero........: ");
                            array[i, y] = Convert.ToDouble(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Entre um peso..........: ");
                            array[i, y] = Convert.ToDouble(Console.ReadLine());
                            break;
                    }
                }
            }

            // Processamento 
            for (int i = 0; i <= 2; i++)
            {
                x = x + array[i, 1] * array[i, 0];
                z = z + array[i, 0];
            }
            medP = x / z;
            Console.WriteLine("Valor da média ponderada ..........: {0:F2}", medP);
        }

        // Exercicio 05.
        static void Ex05()
        {
            double a = 0.00f;
            double v = 0.00f;
            double p = 0.00f;

            Console.WriteLine("Calculo de potência");
            Console.Write("Entre o valor de amperes (A) ........:   ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entre o valor de volts (V) ..........:   ");
            v = Convert.ToDouble(Console.ReadLine());

            p = a * v;
            Console.WriteLine("Resultado do calculo ............:   {0:F2}", p);

        }

        // Exercicio 06.
        static void Ex06()
        {
            double salaryEmployee = 0.00f;
            double newSalaryEmployee = 0.00f;
            Console.Write("Entre o salario do funcionário:   ");
            salaryEmployee = Convert.ToDouble(Console.ReadLine());

            newSalaryEmployee = salaryEmployee + salaryEmployee * Constants.salaryIncrease;
            Console.WriteLine("Salario com correção........:   {0:F2}", newSalaryEmployee);

        }

        // Exercicio 07.
        static void Ex07()
        {
            double real = 0.00f;
            double dolar = 0.00f;
            double dolarRate = 0.00f;

            Console.Write("Entre um valor em real........:   ");
            real = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entre a cotação do dolar......:   ");
            dolarRate = Convert.ToDouble(Console.ReadLine());

            dolar = real / dolarRate;
            Console.WriteLine("Valor em Dolar............:   {0:F2}", dolar);
        }

        // Exercicio 08.
        static void Ex08()
        {
            int n = 0;
            int r = 0;

            Console.Write("Entre um numero...:   ");
            n = int.Parse(Console.ReadLine());

            r = (n * 3 + 1) + (n * 2 - 1);
            Console.WriteLine("Resultado.....:   " + r);
        }

        // Exercicio 09.
        static void Ex09()
        {
            double show = 0.00f;
            int n = 0;
            double mul = 0.00f;
            double remains = 0.00f;

            Console.Write("Entre um numero inteiro.....:   ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int power = 3; power >= 0; power--)
            {
                mul = Math.Pow(10, power);
                show = n / mul;
                remains = n % mul;
                n = Convert.ToInt32(remains);
                Console.WriteLine("{0:F0}", Math.Floor(show));
            }
        }

        // Exercicio 10.
        static void Ex10()
        {
            double investment = 1000.00f;
            double[] tax = new double[] { -0.034, 0.028, 0.14, -0.085 };

            Console.WriteLine(tax.Length);

            for (int i = 0; i < tax.Length; i++)
            {
                investment = investment + investment * tax[i];
            }
            
            Console.WriteLine("Marquesito possui {0:F2} investidos", investment);
        }

        // Exercicio 11.
        static void Ex11()
        {
            double n = 0.00f;
            double nSquare = 0.00f;
            double nCube = 0.00f;
            
            Console.Write("Entre um numero.....:  ");
            n = Convert.ToDouble(Console.ReadLine());
            nSquare = Math.Pow(n, 2);
            nCube = Math.Pow(n, 3);

            Console.WriteLine("Numero ao quadrado......:   {0:F2}", nSquare);
            Console.WriteLine("Numero ao cubo..........:   {0:F2}", nCube);
        }

        // Exercicio 12.
        static void Ex12()
        {
            double heightPerson = 0.00f;
            char genrePerson = 'A';
            double idealWeight = 0.00f;

            Console.Write("Entre sua altura......:  ");
            heightPerson = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("escolha m para mulher || h para homem!");
            Console.WriteLine("Entre seu genero");
            Console.Write(">>>>   ");
            genrePerson = char.ToUpper(char.Parse(Console.ReadLine()));

            if (true == genrePerson.Equals('H'))
            {
                idealWeight = 72.70f * heightPerson - 58.00f;
                Console.WriteLine("Homem || Seu peso ideal é de....:  {0:F2}", idealWeight);
            } else if( true == genrePerson.Equals('M'))
            {
                idealWeight = 62.10f * heightPerson - 44.70f;
                Console.WriteLine("Mulher || Seu peso ideal é de...:  {0:F2}", idealWeight);
            } else
            {
                Console.WriteLine("Sexo não estabelecido!");
            }
        }

        // Programa base.
        static void Main(string[] args)
        {
            Menu();
            int selectOption = int.Parse(Console.ReadLine());

            switch ( selectOption )
            {
                case 1:
                    Ex01();
                    break;
                case 2:
                    Ex02();
                    break;
                case 3:
                    Ex03();
                    break;
                case 4:
                    Ex04();
                    break;
                case 5:
                    Ex05();
                    break;
                case 6:
                    Ex06();
                    break;
                case 7:
                    Ex07();
                    break;
                case 8:
                    Ex08();
                    break;
                case 9:
                    Ex09();
                    break;
                case 10:
                    Ex10();
                    break;
                case 11:
                    Ex11();
                    break;
                case 12:
                    Ex12();
                    break;
                default:
                    Console.WriteLine("Nenhuma opção foi selecionada!");
                    break;
            }
        }
    }
}
