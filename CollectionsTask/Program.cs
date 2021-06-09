using System;
using System.Collections.Generic;

namespace CollectionsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sum = 0;
            int count = 0;
            bool isWorking = true;
            Queue<int> monewClients = new Queue<int>();
            for (int i = 0; i < 5; i++)
            {
                monewClients.Enqueue(random.Next(1, 9));
            }

            while (isWorking&&monewClients.Count>0)
            {
                WorkProcess(ref sum, ref count, monewClients);

            }
            Console.WriteLine("Прогррамма завершена"); 
            Console.WriteLine("Обслужили " + count + " клиентов и заработали " + sum + " денег");
        }

        private static void WorkProcess(ref int sum, ref int count, Queue<int> monewClients)
        {
            Console.WriteLine("Добро пожаловать в магазин,у нас " + sum + " денег");
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
            Console.Clear();
            sum += monewClients.Dequeue();
            count++;
        }
    }
}
