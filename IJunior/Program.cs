using System;

namespace IJunior
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordForRepeat = "Hi";
            Console.WriteLine($"Привет,я буду выводить слово {wordForRepeat} бесконечное количество раз пока ты не введешь exit");
            bool doForInfinite = true;
            string stopWord = "exit";
            while (doForInfinite)
            {
                string commandStop = Console.ReadLine();
                if (stopWord == commandStop)
                {
                    doForInfinite = false;
                    Console.WriteLine($"Вы ввели {commandStop} я прекращаю работать");
                    break;
                }
                
                Console.WriteLine(wordForRepeat);
            }
            Console.WriteLine("Работу закончил");
           
        }
    }
}
