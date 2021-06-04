using System;

namespace Massive
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] myArray = new int[10,10];
            int maxArrayNumber = myArray[0, 0];
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next(0, 10);
                    if (myArray[i, j] > maxArrayNumber)
                    {
                        maxArrayNumber = myArray[i, j];
                    }
                }
             }
            
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                   if (myArray[i, j] == maxArrayNumber)
                    {
                        myArray[i, j] = 0;
                    }
                }
            }
        }
    }
}
