using System;

namespace IJunior
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int heroHelth = 100;
            int heroArmor = 20;
            int heroSqueezeAttack = 40;
            int heroStormAttack = 20;
            int heroBigAttack = 30;
            int enemyHealth = 200;
            int enemyCatAttack = 30;
            int enemySandAttack = 30;
            int enemyHighAttack = 35;
            StartBattle(random, ref heroHelth, heroArmor, heroSqueezeAttack, heroStormAttack, heroBigAttack, ref enemyHealth, enemyCatAttack, enemySandAttack, enemyHighAttack);

            Console.WriteLine("Спасибо за бой");
        }

       
        
        private static void StartBattle(Random random, ref int heroHelth, int heroArmor, int heroSqueezeAttack, int heroStormAttack, int heroBigAttack, ref int enemyHealth, int enemyCatAttack, int enemySandAttack, int enemyHighAttack)
        {
            int heroHelpHelth = 30;
            int enemyHelpHealth = 30;
            int heroSuperHeal;
            int enemySuperHeal;
            int heroSuperAttack;
            int enemySuperAttack;


            int useAttack;
            bool fight = true;
            while (fight)
            {
                Console.WriteLine("Давай бей!Выбирай 1,2,или 3!");
                int myChoise = Convert.ToInt32(Console.ReadLine());
                int WhatNext = random.Next(0, 2);
                if (WhatNext == 0)
                {
                    Console.WriteLine("Ты выбрал " + myChoise + " атакуем");
                    useAttack = myChoise;
                }
                else
                {
                    Console.WriteLine("Ай,не буду тебя слушать,пусть будет наугад");
                    useAttack = random.Next(1, 4);
                }

                switch (useAttack)
                {
                    case 1:
                        heroHelth -= enemyCatAttack - heroArmor - heroHelpHelth;
                        enemyHealth -= heroSqueezeAttack;
                        Console.WriteLine($"У героя {heroHelth} жизней, у врага {enemyHealth}");
                        Console.WriteLine("Настало время супер способностей!Герой и враг супер лечаться");
                        heroSuperHeal = random.Next(5, 50);
                        enemySuperHeal = random.Next(5, 50);
                        heroHelth += heroSuperHeal;
                        enemyHealth += enemySuperHeal;
                        Console.WriteLine($"Теперь у героя {heroHelth} жизней, у врага {enemyHealth}");

                        break;
                    case 2:
                        heroHelth -= enemySandAttack - heroArmor;
                        enemyHealth -= heroStormAttack;
                        Console.WriteLine($"У героя {heroHelth} жизней, у врага {enemyHealth}");
                        Console.WriteLine("Настало время супер способностей!Герой и враг супер атакуют");
                        heroSuperAttack = random.Next(10, 30);
                        enemySuperAttack = random.Next(5, 20);
                        heroHelth -= enemySuperAttack;
                        enemyHealth -= heroSuperAttack;
                        Console.WriteLine($"Теперь у героя {heroHelth} жизней, у врага {enemyHealth}");
                        break;
                    case 3:
                        heroHelth -= enemyHighAttack - heroArmor;
                        enemyHealth -= heroBigAttack - enemyHelpHealth;
                        Console.WriteLine($"У героя {heroHelth} жизней, у врага {enemyHealth}");
                        break;
                    default:
                        Console.WriteLine("Ошибка выбора");
                        break;
                }

                if (heroHelth <= 0 && enemyHealth <= 0)
                {
                    Console.WriteLine("Бой окончен ничья");
                    fight = false;
                    break;
                }
                if (heroHelth <= 0 && enemyHealth > 0)
                {
                    Console.WriteLine("Бобедил враг");
                    fight = false;
                    break;
                }
                if (heroHelth >= 0 && enemyHealth <= 0)
                {
                    Console.WriteLine("Бобедил герой");
                    fight = false;
                    break;
                }
            }
        }
    }
}

