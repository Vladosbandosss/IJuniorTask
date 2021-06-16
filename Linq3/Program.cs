using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentYear = 2021;
            List<Meal> mealList = new List<Meal>();
            mealList.AddRange(CreateMeal());

            var badMeal = mealList.Where(meal => meal.GetExpire() + meal.GetReproduce() < currentYear).ToList();
            Console.WriteLine("Вывожу просрочку");

            foreach (var item in badMeal)
            {
                item.ShowDescriptionName();
            }

        }

        private static List<Meal> CreateMeal()
        {
            List<Meal> mealList = new List<Meal>();
            Meal firstMeal = new Meal("Бородинская", 2000, 30);
            Meal secondMeal = new Meal("Варшавская", 2005, 5);
            Meal thirdMeal = new Meal("Крымская", 2010, 30);
            Meal fourthMeal = new Meal("Русская", 2009, 30);
            Meal fifthMeal = new Meal("Норвежская", 2010, 5);
            mealList.Add(firstMeal);
            mealList.Add(secondMeal);
            mealList.Add(thirdMeal);
            mealList.Add(fourthMeal);
            mealList.Add(fifthMeal);
            return mealList;
        }
    }
    class Meal
    {
        private string _name;
        private int _yearReproduce;
        private int _expireYear;

        public Meal(string name,int reproduce,int expire)
        {
            _name = name;
            _yearReproduce = reproduce;
            _expireYear = expire;
        }

        public int GetReproduce()
        {
            return _yearReproduce;
        }
        public int GetExpire()
        {
            return _expireYear;
        }
        public void ShowDescriptionName()
        {
            Console.WriteLine($"Название {_name}");
        }

    }
}
