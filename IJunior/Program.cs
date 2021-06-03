using System;

namespace IJunior
{
    class Program
    {
        static void Main(string[] args)
        {
            //программа выводит 14 чисел начиная с 7,каждое последующее число больше
            //предыдущего на 7
            int number = 7;
            for (int i = 0; i < 14; i++)
            {
                Console.WriteLine(number);
                number += 7;
            }
            Console.WriteLine("числа выведены,программа завершена");

        }
    }
}

