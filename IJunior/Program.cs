using System;

namespace IJunior
{
    class Program
    {
        static void Main(string[] args)
        {
            double myUsd = 100;
            double myEur = 100;
            double myRub = 100;
            bool makeChange = true;
            
            while (makeChange)
            {
                Console.WriteLine($"Добро пожаловать в обменник! У тебя есть {myRub} рублей,{myUsd} долларов,{myEur} евро");
                Console.WriteLine("Курс Евро/Доллар/Рубль равняется 1/2/4");
                Console.WriteLine("Выбери что надо сделать!");
                Console.WriteLine("1-обмен EUR на USD! 1 евро = 2 доллара");
                Console.WriteLine("2-обмен  EUR на RUB! 1 евро = 4 рубля");
                Console.WriteLine("3-обмен USD на EUR! 1 доллар = 0.5 евро");
                Console.WriteLine("4- обмен USD на RUB!1 доллар = 2 рубля");
                Console.WriteLine("5- обмен RUB на USD!1 рубль = 0.5 доллара");
                Console.WriteLine("6- обмен RUB на EUR!1 рубль = 0.25 евро");
                Console.WriteLine("Любая другая цифра заканчиваю работу");
                int ourChoose = Convert.ToInt32(Console.ReadLine());
               
                    switch (ourChoose)
                    {
                        case 1:
                            Console.WriteLine("Сколько евро хотите поменять на доллары?");
                            int EurInUsd = Convert.ToInt32(Console.ReadLine());
                            int exchangeEURinUsd = EurInUsd * 2;
                            myEur -= EurInUsd;
                            myUsd += exchangeEURinUsd;
                            Console.WriteLine("Готово");
                           break;
                        case 2:
                            Console.WriteLine("Сколько евро хотите поменять на рубли?");
                            int EurInRub = Convert.ToInt32(Console.ReadLine());
                            int exchangeEurInRub = EurInRub * 4;
                            myEur -= EurInRub;
                            myRub += exchangeEurInRub;
                            break;
                        case 3:
                            Console.WriteLine("Сколько долларов хотите поменять на евро?");
                            int UsdInEur = Convert.ToInt32(Console.ReadLine());
                            double exchangeUsdInEUR = UsdInEur * 0.5;
                            myUsd -= UsdInEur;
                            myEur += exchangeUsdInEUR;
                            break;
                        case 4:
                            Console.WriteLine("Сколько долларов хотите поменять на рубли?");
                            int howMuchWeWantChangeUsdInRuble = Convert.ToInt32(Console.ReadLine());
                            double exchangrUsdInRub = howMuchWeWantChangeUsdInRuble * 2;
                            myUsd -= howMuchWeWantChangeUsdInRuble;
                            myRub += exchangrUsdInRub;
                            break;
                        case 5:
                            Console.WriteLine("Сколько рублей хотите поменять на доллары?");
                            int RubleInUsd = Convert.ToInt32(Console.ReadLine());
                            double exchangeRubleInUsd = RubleInUsd * 0.5;
                            myRub -= RubleInUsd;
                            myUsd += exchangeRubleInUsd;
                            break;
                        case 6:
                            Console.WriteLine("Сколько рублей хотите поменять на евро?");
                            int RubleInEur = Convert.ToInt32(Console.ReadLine());
                            double exchangeRubleInEur = RubleInEur * 0.25;
                            myRub -= RubleInEur;
                            myEur += exchangeRubleInEur;
                            break;

                        default:
                            Console.WriteLine("Выхожу с паботы");
                        makeChange = false;
                            break;
                    }
                Console.WriteLine("Работа окончена");
                
                }
               













            }
           
        }
    }

