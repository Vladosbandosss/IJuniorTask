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
                Console.WriteLine("7 выйти с обмена");
                int ourChoose = Convert.ToInt32(Console.ReadLine());
                if (ourChoose == 7)
                {
                    makeChange = false;
                    break;
                }
                else
                {
                    switch (ourChoose)
                    {
                        case 1:
                            Console.WriteLine("Сколько евро хотите поменять на доллары?");
                            int howMuchWeWantChangeEurInUsd = Convert.ToInt32(Console.ReadLine());
                            int exchangeEURinUsd = howMuchWeWantChangeEurInUsd * 2;
                            myEur -= howMuchWeWantChangeEurInUsd;
                            myUsd += exchangeEURinUsd;
                            Console.WriteLine("Готово");
                           break;
                        case 2:
                            Console.WriteLine("Сколько евро хотите поменять на рубли?");
                            int howMuchWeWantChangeEurInRub = Convert.ToInt32(Console.ReadLine());
                            int exchangeEurInRub = howMuchWeWantChangeEurInRub * 4;
                            myEur -= howMuchWeWantChangeEurInRub;
                            myRub += exchangeEurInRub;
                            break;
                        case 3:
                            Console.WriteLine("Сколько долларов хотите поменять на евро?");
                            int howMuchWeWantChangeUsdInEur = Convert.ToInt32(Console.ReadLine());
                            double exchangeUsdInEUR = howMuchWeWantChangeUsdInEur * 0.5;
                            myUsd -= howMuchWeWantChangeUsdInEur;
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
                            int howMuchWeWantChangeRubleInUsd = Convert.ToInt32(Console.ReadLine());
                            double exchangeRubleInUsd = howMuchWeWantChangeRubleInUsd * 0.5;
                            myRub -= howMuchWeWantChangeRubleInUsd;
                            myUsd += exchangeRubleInUsd;
                            break;
                        case 6:
                            Console.WriteLine("Сколько рублей хотите поменять на евро?");
                            int howMuchWeWantChangeRubleInEur = Convert.ToInt32(Console.ReadLine());
                            double exchangeRubleInEur = howMuchWeWantChangeRubleInEur * 0.25;
                            myRub -= howMuchWeWantChangeRubleInEur;
                            myEur += exchangeRubleInEur;
                            break;

                        default:
                            Console.WriteLine("Ввели непонятную хрень");
                            break;
                    }
                }
               













            }
           
        }
    }
}
