using System;

namespace IJunior
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gold Task
            Console.WriteLine("Введите количесто золота которое у вас есть");
            int myGold =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("у меня есть " + myGold + " золотых монет");
            double crystalPrice = 2.55;
            Console.WriteLine("Курс обмена составляет "+ crystalPrice + " за 1 золотую монету");
            Console.WriteLine("Сколько золота хотите поменять?");
            int howMuchGoldChange = Convert.ToInt32(Console.ReadLine());
            double crystalResult = howMuchGoldChange * crystalPrice;
            Console.WriteLine("готово,вы отдали " + howMuchGoldChange + " золотых монеток и взамен получили " + Math.Round(crystalResult, 2) + " кристалов");
            int moneyNowWeHave = myGold - howMuchGoldChange;
            Console.WriteLine("У нас осталось " + moneyNowWeHave + " золотых монеток");
            

            

        }
    }
}
