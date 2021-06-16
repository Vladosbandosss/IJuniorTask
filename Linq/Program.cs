using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ill> illPerson = new List<Ill>();
            AddIllPerson(illPerson);

            bool isWorking = true;

            while (isWorking)
            {
                Console.WriteLine("Добро пожаловать в больничный список,что хотите сделать?1-отсортировать по фио,2-отсортировать по возрасту," +
                    "3 вывести заболевание, 4 выход");
                int userInput;
                int.TryParse(Console.ReadLine(), out userInput);

                switch (userInput)
                {
                    case 1:
                        var fioSort = illPerson.Where(ill => ill.GetAge() > 0).OrderBy(x => x.GetFio()).ToList();
                        ShowInfo(fioSort);
                        break;
                    case 2:
                        var ageSort = illPerson.Where(ill => ill.GetAge() > 0).OrderBy(x => x.GetAge()).ToList();
                        ShowInfo(ageSort);
                        break;
                    case 3:
                        Console.WriteLine("Введите болезнь,поищу");
                        string illness = Console.ReadLine();
                        var illSort = illPerson.Where(ill => ill.GetIll().Contains(illness)).ToList();
                        ShowInfo(illSort);
                        break;
                    case 4:
                        isWorking = false;
                        break;
                    default:
                        Console.WriteLine("Ошибка выбора");
                        break;
                }
            }

            Console.WriteLine("Завершил");
        }

        private static void ShowInfo(List<Ill> fioSort)
        {
            foreach (var item in fioSort)
            {
                item.ShowDescription();
            }
        }

        private static void AddIllPerson(List<Ill> illPerson)
        {
            illPerson.Add(new Ill("Влад", 20, "Понос"));
            illPerson.Add(new Ill("Рома", 25, "Перелом"));
            illPerson.Add(new Ill("Вадим", 30, "Понос"));
            illPerson.Add(new Ill("Роман", 18, "Укус клеща"));
            illPerson.Add(new Ill("Саша", 60, "Перелом"));
            illPerson.Add(new Ill("Даша", 27, "Ушиб"));
            illPerson.Add(new Ill("Слава", 22, "Насморк"));
            illPerson.Add(new Ill("Вячеслав", 33, "Столбняк"));
            illPerson.Add(new Ill("Павел", 48, "Дифтерия"));
            illPerson.Add(new Ill("Ян", 32, "Перелом"));
        }
    }
    class Ill
    {
        private string _fio;
        private int _age;
        private string _illName;

        public Ill(string fio,int age,string illName)
        {
            _fio = fio;
            _age = age;
            _illName = illName;
        }

        public string GetFio()
        {
            return _fio;
        }
        
        public int GetAge()
        {
            return _age;
        }

        public string GetIll()
        {
            return _illName;
        }

        public void ShowDescription()
        {
            Console.WriteLine($"пациент {_fio} возраст {_age} болезнь {_illName}");
        }
    }
}
