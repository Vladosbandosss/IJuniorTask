using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;
            var fioInfo = new List<String>();
            var positionInfo = new List<String>();
            while (isWorking)
            {
                int choose;
                Console.WriteLine("Выбери что нужно сделать!1-добавим досье,2 выведем все досье,3 удалю досье,4 поиск по фамилии,5 выход");
                string userInput = Console.ReadLine();
                bool resultIsWorking = int.TryParse(userInput,out choose);
                if (resultIsWorking)
                {
                    switch (choose)
                    {
                        case 1:
                            AddDossier(fioInfo, positionInfo);
                            break;
                        case 2:
                            ShowAllDosier(fioInfo, positionInfo);
                            break;
                        case 3:
                            DeleteDosier(fioInfo, positionInfo);
                            break;
                        case 4:
                            FindSurnameDossier(fioInfo, positionInfo);
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
                else
                {
                    Console.WriteLine("Что-то не так,повторите");
                }
                
             }
        }

        private static void FindSurnameDossier(List<string> fioInfo, List<string> positionInfo)
        {
            Console.WriteLine("Будем искать по фамилии,введите фамилию");
            string surname = Console.ReadLine();
            for (int i = 0; i < fioInfo.Count; i++)
            {
                if (fioInfo[i].ToLower().Contains(surname.ToLower()))
                {
                    Console.WriteLine("Информация найдена");
                    Console.WriteLine("номер " + (i + 1) + " должность " + fioInfo[0] + " должность " + positionInfo[0]);
                }
            }
        }

        private static void DeleteDosier(List<string> fioInfo, List<string> positionInfo)
        {
            Console.WriteLine("Удаляю досье");
            ShowInfo(fioInfo, positionInfo);
            Console.WriteLine("Выберите номер досье который хотите удалить");
            int WhatInfoDelate = Convert.ToInt32(Console.ReadLine());
            fioInfo.RemoveAt(WhatInfoDelate - 1);
            positionInfo.RemoveAt(WhatInfoDelate - 1);
        }

        private static void ShowAllDosier(List<string> fioInfo, List<string> positionInfo)
        {
            Console.WriteLine("Вы выбрали вывести досье,вывожу");
            ShowInfo(fioInfo, positionInfo);
        }

        private static void ShowInfo(List<string> fioInfo, List<string> positionInfo)
        {
            for (int i = 0; i < fioInfo.Count; i++)
            {
                Console.WriteLine("номер " + (i + 1) + " должность " + fioInfo[i] + " должность " + positionInfo[i]);
            }
        }

        private static void AddDossier(List<string> fioInfo, List<string> positionInfo)
        {
            Console.WriteLine("Вы выбрали добавить досье!");
            Console.WriteLine("Введите фио");
            string fio = Console.ReadLine();
            fioInfo.Add(fio);
            Console.WriteLine("Введите должность");
            string position = Console.ReadLine();
            positionInfo.Add(position);
            Console.WriteLine("Готово,данные добавлены");
        }
    }
}