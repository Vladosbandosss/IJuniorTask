using System;

namespace IJunior
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуй,ты ввудешь имя и символ а я красиво отрисую)");
            Console.WriteLine("Введи имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введи символ");
            string symbol = Console.ReadLine();
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(symbol + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"{symbol}{name}{symbol}");
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(symbol + " ");
            }

        }
    }
}

