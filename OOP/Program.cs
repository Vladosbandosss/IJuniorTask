using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Warior> firstTeam = new List<Warior>();
            firstTeam.AddRange(CreateFirstTeam());

            List<Warior> secondTeam = new List<Warior>();
            secondTeam.AddRange(CreateSecondTeam());

            FightPlace fightPlace = new FightPlace();
            fightPlace.Fight(firstTeam, secondTeam);

        }

        private static List<Warior> CreateSecondTeam()
        {
            Warior seconsTeamOne = new Warior(200, 5, 5);
            Warior seconsTeamTwo = new Warior(105, 20, 0);
            Warior seconsTeamThree = new Warior(90, 7, 4);

            List<Warior> secondTeam = new List<Warior>();
            secondTeam.Add(seconsTeamOne);
            secondTeam.Add(seconsTeamTwo);
            secondTeam.Add(seconsTeamThree);
            return secondTeam;
        }

        private static List<Warior> CreateFirstTeam()
        {
            Warior firstTeamOne = new Warior(100, 20, 10);
            Warior firstTeamTwo = new Warior(105, 30, 5);
            Warior firstTeamThree = new Warior(110, 35, 6);

            List<Warior> firstTeam = new List<Warior>();
            firstTeam.Add(firstTeamOne);
            firstTeam.Add(firstTeamTwo);
            firstTeam.Add(firstTeamThree);
            return firstTeam;
        }
    }

    class Warior {
        private int _health;
        private int _damage_;
        private int _armor;
        private int _uniqueAtack;

        public Warior(int health,int damage,int armor)
        {
            Random random = new Random();
            _uniqueAtack = random.Next(1, 11);
            _health = health;
            _damage_ = damage;
            _armor = armor;
        }

        public int GetHealth()
        {
            return _health;
        }
        public int GetDamege()
        {
            return _damage_;
        }
        public int GetArmor()
        {
            return _armor;
        }
        public int GetUnique()
        {
            return _uniqueAtack;
        }
            
    }

    class FightPlace
    {
      

        public void Fight(List<Warior>firstTeam,List<Warior>secondTeam)
        {
            Console.WriteLine("Начинаем бой!");
            int firsTeamCount = 0;
            int secondTeamCount = 0;

            for (int i = 0; i < firstTeam.Count; i++)
            {
                
                bool isFight = true;
                int firstTeamHealth = firstTeam[i].GetHealth();
                int secondTeamHealth = secondTeam[i].GetHealth();

                while (isFight)
                {
                    firstTeamHealth -= (secondTeam[i].GetDamege()+secondTeam[i].GetUnique()) + firstTeam[i].GetArmor();
                    secondTeamHealth -= (firstTeam[i].GetDamege()+firstTeam[i].GetUnique()) + secondTeam[i].GetArmor();

                    if (firstTeamHealth < 0 && secondTeamHealth > 0)
                    {
                        secondTeamCount++;
                        isFight = false;
                    }
                    if (firstTeamHealth > 0 && secondTeamHealth < 0)
                    {
                        firsTeamCount++;
                        isFight = false;
                    }
                    if (firstTeamHealth <= 0 && secondTeamHealth <= 0)
                    {
                        isFight = false;
                    }
                }
            }
            Console.WriteLine("Бой завершен");

            if (firsTeamCount > secondTeamCount)
            {
                Console.WriteLine("Победила первая команда");
            }else if (firsTeamCount < secondTeamCount)
            {
                Console.WriteLine("Победила вторая команда");
            }
            else
            {
                Console.WriteLine("Ничья");
            }
        }
    }
}


   


