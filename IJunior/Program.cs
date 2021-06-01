using System;

namespace IJunior
{
    class Program
    {
        static void Main(string[] args)
        {

            int minutesOfWaitingPerOnePeople = 10;
            Console.WriteLine("Введите количество людей перед вами");
            int countOfPeopleBeforeMe = Convert.ToInt32(Console.ReadLine());
            int AllminutesOfWaiTing = countOfPeopleBeforeMe * minutesOfWaitingPerOnePeople;
            TimeSpan findRes = TimeSpan.FromMinutes(AllminutesOfWaiTing);
            Console.WriteLine("Вам стоять " + findRes.Hours + " часов " + findRes.Minutes + " минут");

            
            

            

        }
    }
}
