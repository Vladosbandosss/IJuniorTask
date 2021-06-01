using System;

namespace IJunior
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Введите количество людей перед вами");
            int countOfPeople = Convert.ToInt32(Console.ReadLine());
            int timeresultInMinuters = countOfPeople * 10;
            TimeSpan findRes = TimeSpan.FromMinutes(timeresultInMinuters);
            Console.WriteLine("Вам стоять " + findRes.Hours + " часов " + findRes.Minutes + " минут");

            
            

            

        }
    }
}
