using System;

namespace Functions
{
    class Program
    {
       
        static void Main(string[] args)
        {
            TryConvert();
        }

        private static void TryConvert()
        {
            bool isEnterNumber = true;
            while (isEnterNumber)
            {
                int convertedNumber;
                Console.WriteLine("Введите число");
                string inputNumber = Console.ReadLine();

                if (int.TryParse(inputNumber, out convertedNumber))
                {
                    Console.WriteLine("Удачная конвертация");
                    isEnterNumber = false;
                }
                else
                {
                    Console.WriteLine("Что-то не так,повторите");
                }
            }
            Console.WriteLine("Закончил работу");
        }
    }
}

