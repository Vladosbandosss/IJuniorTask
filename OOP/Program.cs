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
            firstTeam.AddRange(CreateTeam());

            List<Warior> secondTeam = new List<Warior>();
            secondTeam.AddRange(CreateTeam());

            FightPlace fightPlace = new FightPlace();
            fightPlace.Fight(firstTeam, secondTeam);

        }

        private static List<Warior> CreateTeam()
        {
            List<Warior> wariorsTeam = new List<Warior>();
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                int health = random.Next(50, 100);
                int damage = random.Next(10, 16);
                int armor = random.Next(1, 11);
                Warior warior = new Warior(health, damage, armor);
                wariorsTeam.Add(warior);
            }
             return wariorsTeam;
        }
    }
       
    class Warior : Hero {
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
      abstract class Hero
    {
        public int superAbiliti;
        public int SuperPower()
        {
            Random random = new Random();
            superAbiliti = random.Next(1, 11);
            return superAbiliti;
        }
    }  

    class FightPlace
    {
         public void Fight(List<Warior>firstTeam,List<Warior>secondTeam)
        {
            Console.WriteLine("Начинаем бой!");
            int firsTeamCount = 0;
            int secondTeamCount = 0;

            FightTeam(firstTeam, secondTeam, ref firsTeamCount, ref secondTeamCount);

            Console.WriteLine("Бой завершен");

            if (firsTeamCount > secondTeamCount)
            {
                Console.WriteLine("Победила первая команда");
            }
            else if (firsTeamCount < secondTeamCount)
            {
                Console.WriteLine("Победила вторая команда");
            }
            else
            {
                Console.WriteLine("Ничья");
            }
        }

        private static void FightTeam(List<Warior> firstTeam, List<Warior> secondTeam, ref int firsTeamCount, ref int secondTeamCount)
        {
            for (int i = 0; i < firstTeam.Count; i++)
            {
                bool isFight = true;
                int firstTeamHealth = firstTeam[i].GetHealth()+firstTeam[i].superAbiliti;
                int secondTeamHealth = secondTeam[i].GetHealth()+secondTeam[i].superAbiliti;

                while (isFight)
                {
                    firstTeamHealth -= (secondTeam[i].GetDamege() + secondTeam[i].GetUnique()) + firstTeam[i].GetArmor();
                    secondTeamHealth -= (firstTeam[i].GetDamege() + firstTeam[i].GetUnique()) + secondTeam[i].GetArmor();

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
        }
    }
}


   


