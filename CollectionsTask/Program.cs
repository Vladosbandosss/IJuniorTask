﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;
            List<int> userArray = new List<int>();

            while (isWorking)
            {
                isWorking = WorkMoment(isWorking, userArray);
            }
        }

        private static bool WorkMoment(bool isWorking, List<int> userArray)
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
                sum = userArray.Sum();
                Console.WriteLine("Сумма всех элементов в массиве- " + sum);
            }
            else
            {
                if (int.TryParse(result, out userNumber))
                {
                    userArray.Add(userNumber);
                }
            }

            return isWorking;
        }
    }
}
