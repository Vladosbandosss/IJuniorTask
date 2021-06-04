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
            int heroHelpHelth = 30;
            int enemyHelpHealth = 30;
            int heroSuperHeal;
            int enemySuperHeal;
            int heroSuperAttack;
            int enemySuperAttack;
            int whitchAttackUse;
            bool isFight = true;
            int lucckyPersonAttack;
            int superAtack;
            int zaklinanie;
            int strengthenAttack = 2;
            int littleStrenghten = 15;

             while (isFight)
            {
                Console.WriteLine("Давай бей!Выбирай 1,2,или 3!");
                int myChoiseAttack = Convert.ToInt32(Console.ReadLine());
                int whatNextStep = random.Next(0, 2);
                if (whatNextStep == 0)
                {
                    Console.WriteLine("Ты выбрал " + myChoiseAttack + " атакуем");
                    whitchAttackUse = myChoiseAttack;
                }
                else
                {
                    Console.WriteLine("Ай,не буду тебя слушать,пусть будет наугад");
                    whitchAttackUse = random.Next(1, 4);
                }
                lucckyPersonAttack = random.Next(0, 2);
                zaklinanie = random.Next(0, 2);
                
                switch (whitchAttackUse)
                {
                    case 1:
                         if (lucckyPersonAttack == 0)
                        {
                            heroHelth -= enemyCatAttack - heroArmor - heroHelpHelth;
                            enemyHealth -= heroSqueezeAttack;
                            Console.WriteLine($"У героя {heroHelth} жизней, у врага {enemyHealth}");
                            Console.WriteLine("Настало время супер способностей!Герой и враг супер лечаться");
                            heroSuperHeal = random.Next(5, 50);
                            enemySuperHeal = random.Next(5, 50);
                            if (heroSuperHeal > 25 && enemySuperHeal > 25)
                            {
                                Console.WriteLine("Использую секретик");
                                heroSuperHeal = 0;
                                enemySuperHeal = 0;
                            }
                            heroHelth += heroSuperHeal;
                            enemyHealth += enemySuperHeal;
                            Console.WriteLine($"Теперь у героя {heroHelth} жизней, у врага {enemyHealth}");
                            if (heroHelth > 70)
                            {
                                Console.WriteLine("Произошло заклинание,враг усиливает атаку");
                                enemyCatAttack += random.Next(0, 10);
                               
                            }
                        }
                        else
                        {
                            superAtack = enemyCatAttack * strengthenAttack;
                            heroHelth -= superAtack - heroArmor - heroHelpHelth;
                            enemyHealth -= heroSqueezeAttack;
                            Console.WriteLine($"У героя {heroHelth} жизней, у врага {enemyHealth}");
                            Console.WriteLine("Настало время супер способностей!Герой и враг супер лечаться");
                            heroSuperHeal = random.Next(5, 50);
                            enemySuperHeal = random.Next(5, 50);
                            if (heroSuperHeal < 25 && enemySuperHeal < 25)
                            {
                                Console.WriteLine("Использую секретик");
                                heroSuperHeal = 20;
                                enemySuperHeal = 20;
                            }
                            heroHelth += heroSuperHeal;
                            enemyHealth += enemySuperHeal;
                            if (heroSuperHeal > 30)
                            {
                                Console.WriteLine("Герой сильно подлечился,но атака сейчас ослабнет(((");
                                heroSqueezeAttack -= random.Next(1, 7);
                            }
                            Console.WriteLine($"Теперь у героя {heroHelth} жизней, у врага {enemyHealth}");
                        }
                        break;
                    case 2:
                        if (lucckyPersonAttack == 0)
                        {
                            superAtack = enemySandAttack + littleStrenghten;
                            heroHelth -= superAtack - heroArmor;
                            enemyHealth -= heroStormAttack;
                            Console.WriteLine($"У героя {heroHelth} жизней, у врага {enemyHealth}");
                            Console.WriteLine("Настало время супер способностей!Герой и враг супер атакуют");
                            heroSuperAttack = random.Next(10, 30);
                            enemySuperAttack = random.Next(5, 20);
                            if (enemySuperAttack > 25)
                            {
                                Console.WriteLine("Использую секретик");
                                enemySuperAttack = 35;
                            }
                            heroHelth -= enemySuperAttack;
                            enemyHealth -= heroSuperAttack;
                            Console.WriteLine($"Теперь у героя {heroHelth} жизней, у врага {enemyHealth}");
                            if (heroSuperAttack==30)
                            {
                                Console.WriteLine("Пока мы лечились враг усилил атаку(((");
                                enemySandAttack += random.Next(10, 15);
                            }
                        }
                        else
                        {
                            heroHelth -= enemySandAttack - heroArmor;
                            enemyHealth -= heroStormAttack;
                            Console.WriteLine($"У героя {heroHelth} жизней, у врага {enemyHealth}");
                            Console.WriteLine("Настало время супер способностей!Герой и враг супер атакуют");
                            heroSuperAttack = random.Next(10, 30);
                            enemySuperAttack = random.Next(5, 20);
                            if (heroSuperAttack > 25)
                            {
                                Console.WriteLine("Использую секретик");
                                heroSuperAttack = 30;
                            }
                            heroHelth -= enemySuperAttack;
                            enemyHealth -= heroSuperAttack;
                            Console.WriteLine($"Теперь у героя {heroHelth} жизней, у врага {enemyHealth}");
                         }
                         break;
                    case 3:
                        if (lucckyPersonAttack == 0)
                        {
                            superAtack = enemyHighAttack + random.Next(1, 7);
                            heroHelth -= superAtack - heroArmor;
                            enemyHealth -= heroBigAttack - enemyHelpHealth;
                            if (heroHelth < 30 && enemyHealth < 30)
                            {
                                Console.WriteLine("Использую секретик");
                                heroHelth += random.Next(1, 10);
                                enemyHealth += random.Next(5, 7);
                            }
                            Console.WriteLine($"У героя {heroHelth} жизней, у врага {enemyHealth}");
                        }
                        else
                        {
                            heroHelth -= enemyHighAttack - heroArmor;
                            enemyHealth -= heroBigAttack - enemyHelpHealth;
                            Console.WriteLine($"У героя {heroHelth} жизней, у врага {enemyHealth}");
                        }
                        if (heroHelth>60&&enemyHealth<20)
                        {
                            Console.WriteLine("Враг использует ульту");
                            enemyHighAttack += random.Next(10, 25);
                        }
                        break;
                        default:
                        Console.WriteLine("Ошибка выбора");
                        break;
                }
                    if (heroHelth <= 0 && enemyHealth <= 0)
                {
                    Console.WriteLine("Бой окончен ничья");
                    isFight = false;
                  }
                    else if (heroHelth <= 0 && enemyHealth > 0)
                {
                    Console.WriteLine("Бобедил враг");
                    isFight = false;
                 }
                    else if (heroHelth >= 0 && enemyHealth <= 0)
                {
                    Console.WriteLine("Бобедил герой");
                    isFight = false;
                 }
            }
             Console.WriteLine("Спасибо за бой");
        }
     }
}

