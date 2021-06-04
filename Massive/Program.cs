using System;

namespace Massive
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int count = 30;
            int[] Array = new int[count];
            for (int i = 0; i < count; i++)
            {
                Array[i] = random.Next(1, 30);
            }
            foreach (var item in Array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < count; i++)
            {
                if (i <= count-2 && i>0 && Array[i] > Array[i-1] && Array[i] > Array[i + 1])
                {
                    Console.WriteLine(Array[i]);
                }
                 if(i==0&&Array[i]>Array[i+1])
                {
                    Console.WriteLine(Array[i]);
                }
                 if (i == count-1&&Array[i]>Array[i-1])
                {
                    Console.WriteLine(Array[i]);
                }

            }

        }
    }
}
