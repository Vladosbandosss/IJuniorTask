using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;
            List<int> numbers = new List<int>();

            while (isWorking)
            {
                Console.WriteLine("Вводи числа,введи exit что б выйти с программы,введи sum и я все выведу");
                string result = Console.ReadLine();
                int userNumber;
                int sum;

                if (result == "exit")
                {
                    isWorking = false;
                }
                else if (result == "sum")
                {
                    sum = numbers.Sum();
                    Console.WriteLine("Сумма всех элементов в массиве- " + sum);
                }
                else
                {
                    if (int.TryParse(result, out userNumber))
                    {
                        numbers.Add(userNumber);
                    }
                }
            }
        }
    }
}
