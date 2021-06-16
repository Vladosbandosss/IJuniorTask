using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводи число");
            string userInput = Console.ReadLine();
            int[] userMas = new int[5];

            for (int i = 0; i < userInput.Length; i++)
            {
                Console.WriteLine(userInput[i]);
                userMas[i] = Convert.ToInt32( userInput[i].ToString());
            }

            foreach (var item in userMas)
            {
                Console.WriteLine(item);
            }
            int sum = userMas.Sum();

            Console.WriteLine(sum);
       }
        
    }
}


   


