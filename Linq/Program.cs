using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Murder> murdersList = new List<Murder>();
            murdersList.AddRange(CreateMurders());

            FindMurders(murdersList);

        }

        private static void FindMurders(List<Murder> murdersList)
        {
            Console.WriteLine("Добро пожаловать в поиск!");
            Console.WriteLine("Введите рост преступника");
            int hightMurder;
            int.TryParse(Console.ReadLine(), out hightMurder);
            Console.WriteLine("Введите возраст преступника");
            int ageMurder;
            int.TryParse(Console.ReadLine(), out ageMurder);
            Console.WriteLine("Введите национлаьность");
            string nationalityMurser = Console.ReadLine();

            var userResult = murdersList.Where(murderSearch => murderSearch.GerArest() == false)
                .Where(murderSearch => murderSearch.GetAge() == ageMurder)
                .Where(murderSearch => murderSearch.GetHeight() == hightMurder)
                .Where(murderSearch => murderSearch.GetNation() == nationalityMurser).ToArray();

            if (userResult.Count() > 0)
            {
                foreach (var item in userResult)
                {
                    item.ShowMurderDesctiption();
                }
            }
            else
            {
                Console.WriteLine("Данные не найдены");
            }
        }

        private static List<Murder> CreateMurders()
        {
            List<Murder> mursderList = new List<Murder>();
            Murder firstMurder = new Murder("Vlad", true, 190, 20, "Belarus");
            mursderList.Add(firstMurder);
            Murder secondMurder = new Murder("Pavel", false, 180, 30, "Ukraine");
            mursderList.Add(secondMurder);
            Murder forthMurder = new Murder("Vova", false, 150, 29, "Belarus");
            mursderList.Add(forthMurder);
            Murder fifthMurder = new Murder("Zoy", false, 180, 30, "Belarus");
            mursderList.Add(fifthMurder);
            Murder sixMurder = new Murder("Sasha", true, 145, 50, "Russia");
            mursderList.Add(sixMurder);
            return mursderList;
        }
    }
    class Murder
    {
        private string _fio;
        private bool _isArested;
        private int _height;
        private int _age;
        private string _nation;

        public Murder(string fio,bool isArest,int height,int age,string nation)
        {
            _fio = fio;
            _isArested = isArest;
            _height = height;
            _age = age;
            _nation = nation;
        }
        public void ShowMurderDesctiption()
        {
            Console.WriteLine($"ФИО {_fio} статус ареста {_isArested} рост {_height} возраст {_age} национальность {_nation} ");
        }
        public string GetFio()
        {
            return _fio;
        }

        public bool GerArest()
        {
            return _isArested;
        }
        public int GetAge()
        {
            return _age;
        }
        public int GetHeight()
        {
            return _height;
        }
        public string GetNation()
        {
            return _nation;
        }
    }
}
