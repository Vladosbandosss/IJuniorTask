using System;

namespace Massive
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int count = 30;
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = random.Next(1, 30);
            }
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < count; i++)
            {
                if (i <= count-2 && i>0 && array[i] > array[i-1] && array[i] > array[i + 1])
                {
                    Console.WriteLine(array[i]);
                }
                 if(i==0&&array[i]>array[i+1])
                {
                    Console.WriteLine(array[i]);
                }
                 if (i == count-1&&array[i]>array[i-1])
                {
                    Console.WriteLine(array[i]);
                }

            }

        }
    }
}
