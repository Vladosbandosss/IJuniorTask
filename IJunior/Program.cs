using System;

namespace IJunior
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Введите количество людей перед вами");
            int countOfPeopleBeforeMe = Convert.ToInt32(Console.ReadLine());
            int minutesOfWaiTing = countOfPeopleBeforeMe * 10;
            TimeSpan findRes = TimeSpan.FromMinutes(minutesOfWaiTing);
            Console.WriteLine("Вам стоять " + findRes.Hours + " часов " + findRes.Minutes + " минут");

            
            

            

        }
    }
}
