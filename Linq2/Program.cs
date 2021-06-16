using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> playerList = new List<Player>();
             playerList.AddRange(CreatePlayers());
            var threeTopLevel = playerList.Where(x => x.GetLevel() > 0).OrderByDescending(x => x.GetLevel()).Take(3).ToList();
            Console.WriteLine("Топ 3 по уровню");

            foreach (var item in threeTopLevel)
            {
                item.ShowDescription();
            }

            Console.WriteLine("Топ 3 по силе");
            var threeTopPower = playerList.Where(x => x.GetLevel() > 0).OrderByDescending(x => x.GetPower()).Take(3).ToList();

            foreach (var item in threeTopPower)
            {
                item.ShowDescription();
            }
        }

        private static List<Player> CreatePlayers()
        {
            List<Player> playerList = new List<Player>();
            Player firsrtPlayer = new Player("Vlad", 10, 5);
            playerList.Add(firsrtPlayer);
            Player secondPlayer = new Player("Rome", 5, 50);
            playerList.Add(secondPlayer);
            Player thirdPlayer = new Player("Vova", 20, 8);
            playerList.Add(thirdPlayer);
            Player fourthPlayer = new Player("Vadim", 200, 7);
            playerList.Add(fourthPlayer);
            Player fifthPlayer = new Player("Sasha", 30, 12);
            playerList.Add(fifthPlayer);
            Player sixPlayer = new Player("Vlados", 500, 50);
            playerList.Add(sixPlayer);
            Player sevenPlayer = new Player("Vard", 100, 25);
            playerList.Add(sevenPlayer);
            Player eightPlayer = new Player("Rav", 105, 55);
            playerList.Add(eightPlayer);
            Player ninePlayer = new Player("Jan", 107, 52);
            playerList.Add(ninePlayer);
            Player tenPlayer = new Player("Cac", 103, 25);
            playerList.Add(tenPlayer);
            return playerList;
         }
    }
    class Player
    {
        private string _name;
        private int _level;
        private int _power;
        
        public Player(string name,int level,int power)
        {
            _name = name;
            _level = level;
            _power = power;
        }

        public int GetLevel()
        {
            return _level;
        }

        public int GetPower()
        {
            return _power;
        }
        public void ShowDescription()
        {
            Console.WriteLine($"зовут {_name} уровень {_level} сила {_power}");
        }
    }
}
