using System;

namespace GameGueesNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, lower, larger;
            int tryCount = 5;
            Random random = new Random();
            int userInput;
            number = random.Next(0, 101);
            lower = random.Next(number - 10, number);
            larger = random.Next(number + 1, number + 10);
            Console.WriteLine("загадал число от 1 до 100 оно больше " + lower + "но меньше " + larger);
            Console.WriteLine("что это за число");
            while (tryCount-- > 0)
            {
                Console.WriteLine("это число");
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == number)
                {
                    Console.WriteLine("верно");
                    break;
                }
                else
                {
                    Console.WriteLine("неверно давай еще");
                }
            }
        }
    }
}
