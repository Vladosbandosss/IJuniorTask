using System;

using System.Collections.Generic;
using System.Linq;

namespace Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Solder> solderList = new List<Solder>();
            solderList.AddRange(CreateSolders());

            var resultNameRank = solderList.Select(x => new
            {
                Name =solderList.Select(p=>p.GetName()),
                Rank=solderList.Select(x=>x.GerRank())
            }).ToArray();
        }

        private static List<Solder> CreateSolders()
        {
            Solder firstSolder = new Solder("Вова", "Танкист", "Полковник", 5);
            Solder secondSolder = new Solder("Влад", "Мотоциклист", "Майор", 10);
            Solder thirdSolder = new Solder("Рома", "Пехота", "Лейтенант", 2);
            Solder fourhSolder = new Solder("Паша", "Авиация", "Генерал", 35);
            Solder fifthSolder = new Solder("Саша", "Снайпер", "Складовик", 13);

            List<Solder> listSolder = new List<Solder>();
            listSolder.Add(firstSolder);
            listSolder.Add(secondSolder);
            listSolder.Add(thirdSolder);
            listSolder.Add(fourhSolder);
            listSolder.Add(fifthSolder);

            return listSolder;
        }
    }
    class Solder
    {
        private string _name;
        private string _armament;
        private string _rank;
        private int _countMonth;
       
        public Solder(string name,string armament,string rank,int countMonth)
        {
            _name = name;
            _armament = armament;
            _rank = rank;
            _countMonth = countMonth;
        }

        public string GetName()
        {
            return _name;
        }
        public string GetArmament()
        {
            return _armament;
        }
        public string GerRank()
        {
            return _rank;
        }
        public int GetMonth()
        {
            return _countMonth;
        }
      
    }
}
