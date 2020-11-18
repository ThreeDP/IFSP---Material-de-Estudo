using System;

namespace Replace-exe
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);
        }
    }
}
