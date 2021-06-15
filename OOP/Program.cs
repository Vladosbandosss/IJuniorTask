using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Arene arene = new Arene();
            
            arene.AddWarriots(CreateWarriors());
           
            bool isBattleArene = true;

            while (isBattleArene)
            {
                int userInput = AreneFight(arene);

                switch (userInput)
                {
                    case 1:
                        isBattleArene = true;
                        break;
                    case 2:
                        isBattleArene = false;
                        break;
                    default:
                        Console.WriteLine("Что то не то");
                        break;
                }
            }
            Console.WriteLine("Программа завершена");
        }

        private static int AreneFight(Arene arene)
        {
            Console.WriteLine("Добро пожаловать на бой!Вот список бойцов");
            arene.ShowWarriotInfo();
            Console.WriteLine("Выбери 2 бойцов");
            Console.WriteLine("Выбери первого бойца");
            int userFirstChoose;
            int.TryParse(Console.ReadLine(), out userFirstChoose);
            Console.WriteLine("Выбери второго бойца");
            int userSecondChpoise;
            int.TryParse(Console.ReadLine(), out userSecondChpoise);
            arene.Fight(arene.GetWarrior(userFirstChoose), arene.GetWarrior(userSecondChpoise));

            Console.WriteLine("Желаете повторить?1-да 2-нет");
            int userInput;
            int.TryParse(Console.ReadLine(), out userInput);
            return userInput;
        }

        private static List<Warrior> CreateWarriors()
        {
            List<Warrior> creatWarrior = new List<Warrior>();
            Warrior Vlad = new Warrior("Влад", 100, 20, 10, 10);
            creatWarrior.Add(Vlad);
            Warrior Roma = new Warrior("Рома", 100, 10, 10, 5);
            creatWarrior.Add(Roma);
            Warrior Pashe = new Warrior("Паша", 75, 20, 5, 7);
            creatWarrior.Add(Pashe);
            Warrior Zoy = new Warrior("Зой", 125, 23, 8, 1);
            creatWarrior.Add(Zoy);
            Warrior Edvard = new Warrior("Эдвард", 90, 5, 5, 20);
            creatWarrior.Add(Edvard);

            return creatWarrior;
        }
    }
    class Hero
    {
        protected int Health;
        protected int Damage;
        protected int Armor;
        protected string Name;
       
        public Hero(string name ,int health,int damage,int armor) {
            Name = name;
            Health = health;
            Damage = damage;
            Armor = armor;
        }

        public int GetHealth()
        {
            return Health;
        }
        public int GetDamage()
        {
            return Damage;
        }
        public int GetArmor()
        {
            return Armor;
        }
        public void ShowDescription()
        {
            Console.WriteLine($"имя {Name} здоровье {Health} урон {Damage} броня {Armor} ,а супер сила секрет");
        }
    }

    class Warrior : Hero
    {
        protected int WarriorSuperPower;
        public Warrior(string WariorName, int WariorHealth,int WariorDamage,int WariorArmor,int superPower):base(WariorName,WariorHealth,WariorDamage,WariorArmor)
        {
            WarriorSuperPower = superPower;
        }

        public int GetSuperPower()
        {
            Random random = new Random();
            int superPower = random.Next(1, 11);
            return WarriorSuperPower+superPower;
        }
    }
    
    class Arene
    {
        List<Warrior> listWarriors = new List<Warrior>();

        public void AddWarriots(List<Warrior>warriors)
        {
            listWarriors.AddRange(warriors);
        }

        public Warrior GetWarrior(int userInput)
        {
            if (userInput - 1 >= 0 && userInput - 1 < listWarriors.Count)
            {
                return listWarriors[userInput - 1];
            }
            else
            {
                Console.WriteLine("Ошибка выбора я сам поставлю бой");
                return listWarriors[0];
            }
           
        }
        public void ShowWarriotInfo()
        {
            for (int i = 0; i < listWarriors.Count; i++)
            {
                Console.Write("боец" + (i+1) + " ");
                listWarriors[i].ShowDescription();
            }
        }

       public void Fight(Warrior firstWarrior,Warrior secondWarrior)
        {
            int firstWarriorHealth = firstWarrior.GetHealth();
            int secondWarriorHealth = secondWarrior.GetHealth();
            bool isFight= true;
            
            while (isFight)
                {
                    Console.WriteLine("Идет бой между двумя героями");
                    Console.WriteLine($"У первого героя {firstWarriorHealth} здоровья");
                    Console.WriteLine($"У второго героя {secondWarriorHealth} здоровья");
                    firstWarriorHealth -= (secondWarrior.GetDamage() + secondWarrior.GetSuperPower()) + firstWarrior.GetArmor();
                    secondWarriorHealth -= (firstWarrior.GetDamage() + firstWarrior.GetSuperPower()) + secondWarrior.GetArmor();

                    if (firstWarriorHealth <= 0 && secondWarriorHealth <= 0)
                    {
                        Console.WriteLine("Ничья");
                        isFight = false;
                    }
                    if (firstWarriorHealth > 0 && secondWarriorHealth <= 0)
                    {
                        Console.WriteLine("Победил первый герой");
                        isFight = false;
                    }
                    if (firstWarriorHealth <= 0 && secondWarriorHealth > 0)
                    {
                        Console.WriteLine("Победил второй игрок");
                        isFight = false;
                    }
            }
          Console.WriteLine("Бой окончен");
       }
    }
}


   


