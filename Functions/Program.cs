using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;
            string[] fioArray = { "" };
            string[] positionArray = { "" };

            while (isWorking)
            {
                Console.WriteLine("Выбери что нужно сделать!1-добавим досье,2 выведем все досье,3 удалю досье,4 поиск по фамилии,5 выход");
                try
                {
                    int ourChoise = Convert.ToInt32(Console.ReadLine());
                    MakeTask(ref isWorking, ref fioArray, ref positionArray, ourChoise);
                }
                catch (FormatException)
                {
                    Console.WriteLine(" Это не число");
                }
            }
            Console.WriteLine("Программа завершена,всего доброго");
        }

        private static void MakeTask(ref bool isWorking, ref string[] fioArray, ref string[] positionArray, int ourChoise)
        {
            switch (ourChoise)
            {
                case 1:
                    Console.WriteLine("Вы выбрали добавить досье!");
                    Console.WriteLine("Введите фио");
                    string fio = Console.ReadLine();
                    AddInfo(ref fioArray, fioArray.Length + 1, fio);
                    Console.WriteLine("Введите должность");
                    string position = Console.ReadLine();
                    AddInfo(ref positionArray, positionArray.Length + 1, position);
                    Console.WriteLine("Готово,данные добавлены");
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали вывести досье,вывожу");
                    int lenghtAllArray = fioArray.Length;
                    for (int i = 0; i < lenghtAllArray; i++)
                    {
                        if (i == 0)
                        {
                            continue;//пропустил первое тк заполнил его пустым значением и позицией ноль!
                            //таким образов так намного удобнее 
                        }
                        Console.WriteLine("Позиция " + i + " " + fioArray[i] + " - " + positionArray[i]);
                    }
                    break;
                case 3:
                    Console.WriteLine("Удаляю последнее досье");
                    DeleteInfo(ref fioArray, fioArray.Length - 1);
                    DeleteInfo(ref positionArray, positionArray.Length - 1);
                    break;
                case 4:
                    Console.WriteLine("Будем искать по фамилии,введите фамилию");
                    string surname = Console.ReadLine();
                    for (int i = 0; i < fioArray.Length; i++)
                    {
                        if (fioArray[i].ToLower().Contains(surname.ToLower()))
                        {
                            Console.WriteLine("человек найден,вывожу досье");
                            Console.WriteLine("Полное ФИО");
                            Console.WriteLine(fioArray[i]);
                            Console.WriteLine("Должность");
                            Console.WriteLine(positionArray[i]);
                        }
                    }
                    break;
                case 5:
                    Console.WriteLine("Вы нажали выход");
                    isWorking = false;
                    break;
                default:
                    Console.WriteLine("Ошибка выбора,повтори");
                    break;
            }
        }

        public static void AddInfo(ref string[] arr, int newSize, string fio)
        {
            string[] newArray = new string[newSize];
            for (int i = 0; i < arr.Length; i++)
            {
                MyArrCheck(arr, fio, newArray, i);
            }
            arr = newArray;
        }

        private static void MyArrCheck(string[] arr, string fio, string[] newArray, int i)
        {
            if (i == arr.Length - 1)
            {
                newArray[i + 1] = fio;
            }
            newArray[i] = arr[i];
        }

        public static void DeleteInfo(ref string[] arr, int newSize)
        {
            string[] newArray = new string[newSize];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
        }
    }
}
