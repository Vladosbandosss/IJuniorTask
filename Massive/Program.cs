using System;

namespace Massive
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int count = 30;
            int[] myArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                myArray[i] = random.Next(1, 30);
            }
            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < count; i++)
            {
                if (i <= count-2 && i>0 && myArray[i] > myArray[i-1] && myArray[i] > myArray[i + 1])
                {
                    Console.WriteLine(myArray[i]);
                }
                 if(i==0&&myArray[i]>myArray[i+1])
                {
                    Console.WriteLine(myArray[i]);
                }
                 if (i == count-1&&myArray[i]>myArray[i-1])
                {
                    Console.WriteLine(myArray[i]);
                }

            }

        }
    }
}
