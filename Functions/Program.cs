using System;
using System.Collections.Generic;
using System.Linq;

namespace Functions
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Shufle();
        }

        private static void Shufle()
        {
            Random random = new Random();
            var arrToShufle = new List<int> { 1, 2, 3, 4, 5 };
            var shufle = arrToShufle.OrderBy(n => random.Next()).ToList();
            foreach (var item in shufle)
            {
                Console.WriteLine(item);
            }
        }
    }
}

