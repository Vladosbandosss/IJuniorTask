using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи число в % от 1 до 100");
            try
            {
                DrawSymbol();
            }
            catch (FormatException)
            {
                Console.WriteLine("Что-то пошло не так");
            }
        }

        private static void DrawSymbol()
        {
            int userInput = Convert.ToInt32(Console.ReadLine());
            int programDrawing = userInput / 10;
            Console.WriteLine(programDrawing);
            char SyblolForDrawing = '#';
            Console.Write("[");
            for (int i = 0; i < programDrawing; i++)
            {
                Console.Write(SyblolForDrawing);
            }
            Console.Write("]");
        }
    }
}

