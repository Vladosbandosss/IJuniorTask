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
            int heroFirstAttack = 40;
            int heroSecondAttack = 20;
            int heroThirdAttach = 30;

            int enemyHealth = 200;
            int enemyFirstAttack = 30;
            int enemySecondAttack = 30;
            int enemyThirdAttack = 35;

            int heroHelpHelth = 30;
            int enemyHelpHealth = 30;

            bool fight = true;
            while (fight)
            {
                int useAttack = random.Next(1, 4);
                //Console.WriteLine($"захожу ударом {useAttack}");

                switch (useAttack)
                {
                    case 1:
                        heroHelth -= enemyFirstAttack - heroArmor - heroHelpHelth;
                        enemyHealth -= heroFirstAttack;
                        Console.WriteLine($"У героя {heroHelth} жизней, у врага {enemyHealth}");
                        break;
                    case 2:
                        heroHelth -= enemySecondAttack - heroArmor;
                        enemyHealth -= heroSecondAttack;
                        Console.WriteLine($"У героя {heroHelth} жизней, у врага {enemyHealth}");
                        break;
                    case 3:
                        heroHelth -= enemyThirdAttack - heroArmor;
                        enemyHealth -= heroThirdAttach - enemyHelpHealth;
                        Console.WriteLine($"У героя {heroHelth} жизней, у врага {enemyHealth}");
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

            Console.WriteLine("Спасибо за бой");
        }
    }
}

