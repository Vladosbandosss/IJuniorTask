using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Solder> sorderSortList = new List<Solder>();
            List<Solder> solderList = new List<Solder>();
            solderList.AddRange(CreateSolders());
            var filtr = solderList.Where(x => x.GetSurname().StartsWith("Б")).ToList();
            sorderSortList.AddRange(filtr);

            foreach (var item in sorderSortList)
            {
                item.ShowDescription();
            }
            


        }

        private static List<Solder> CreateSolders()
        {
            Solder firstSolder = new Solder("Влад", "Большов", 20);
            Solder secondSolder = new Solder("Рома", "Путров", 30);
            Solder thirdSolder = new Solder("Паша", "Боловв", 25);
            Solder fourhSolder = new Solder("Саша", "Троц", 21);
            Solder fifthSolder = new Solder("Демьян", "Бостов", 24);
            List<Solder> solderList = new List<Solder>();
            solderList.Add(firstSolder);
            solderList.Add(secondSolder);
            solderList.Add(thirdSolder);
            solderList.Add(fourhSolder);
            solderList.Add(fifthSolder);
            return solderList;
        }
    }
    class Solder
    {
        private string _name;
        private string _surname;
        private int _age;
        
        public Solder(string name,string surname,int age)
        {
            _name = name;
            _surname = surname;
            _age = age;
        }
        public string GetSurname()
        {
            return _surname;
        }
        public void ShowDescription()
        {
            Console.WriteLine($"имя {_name} фамилия { _surname} возраст { _age}");
        }
    }
}
