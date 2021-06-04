using System;

namespace Massive
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] myArray = new int[3,5];
            int sumSecondStrok = 0;
            int proizvedFirstStolb = 1;

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next(0, 10);
                    if (i == 1)
                    {
                        sumSecondStrok += myArray[i, j];
                    }
                    if(j == 0)
                    {
                        proizvedFirstStolb *= myArray[i, j];
                    }
                }
             }
             Console.WriteLine($"Сумма второй строки {sumSecondStrok} произведение первого столбца {proizvedFirstStolb}");
         }
    }
}
