using System;
using System.Linq;

namespace Massive
{
    class Program
    {
        static void ChangArray(ref  int[] array,int newSize,int valueAdd)
        {
            int []newArray = new int[newSize];

            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    newArray[i+1] = valueAdd;
                }
                 newArray[i] = array[i];
            }
            array = newArray;
        }
        static void Main(string[] args)
        {
            bool isWorking = true;
            int sum = 0;
            int[] array = { 0 };
            
            while (isWorking)
            {
                Console.WriteLine("Вводи число буду добавлять");
                string commad = Console.ReadLine();
                if (commad == "sum")
                {
                    sum = array.Sum();
                    isWorking = false;
                }
                else
                {
                    int addToArray = Convert.ToInt32(commad);
                    ChangArray(ref array, array.Length + 1, addToArray);
                }
            }
              Console.WriteLine($"Сумма всех элементов в массиве {sum}");
        }
    }
}
