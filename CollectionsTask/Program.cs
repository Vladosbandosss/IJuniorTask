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
            var workers = new Dictionary<string, string>();

            while (isWorking)
            {
                int number;
                Console.WriteLine("Нажмите 1 что б добавить досье,2 вывести,3 удалить,4 выход");
                string userInput = Console.ReadLine();
                bool result = int.TryParse(userInput, out number);

                if (result == true)
                {
                    switch (number)
                    {
                        case 1:
                            Add(workers);
                            break;
                        case 2:
                            Console.WriteLine("Вывожу все досье");

                            foreach (var item in workers)
                            {
                                Console.WriteLine(item.Key + " - " + item.Value);
                            }

                            break;
                        case 3:
                            RevomeWorkers(workers);
                            break;
                        case 4:
                            isWorking = false;
                            break;
                        default:
                            Console.WriteLine("Вы ввели что то не то");
                            break;
                    }
                }
            }
            Console.WriteLine("Работа завершена");
        }

        private static void RevomeWorkers(Dictionary<string, string> workers)
        {
            Console.WriteLine("Удаляем досье");
            int count = 1;
            foreach (var item in workers)
            {
                Console.WriteLine(count + " " + item.Key + " - " + item.Value);
                count++;
            }

            Console.WriteLine("Выберите номер который хотите удалить!");
            string userChoise = Console.ReadLine();
            int choise;
            bool isNormalConvertion = int.TryParse(userChoise, out choise);

            if (isNormalConvertion && choise > 0 && choise <= workers.Count)
            {
                int prepareForDelete = choise - 1;
                for (int i = 0; i < workers.Count; i++)
                {
                    if (i == prepareForDelete)
                    {
                        
                        //workers.Remove(); без понятия как удалить(((((
                    }

                }
            }
        }

        private static void Add(Dictionary<string, string> workers)
        {
            Console.WriteLine("Добавляем!Введите ФИО");
            string fio = Console.ReadLine();
            Console.WriteLine("Введите должность");
            string position = Console.ReadLine();
            workers.Add(fio, position);
            Console.WriteLine("Добавил");
        }
    }
}
