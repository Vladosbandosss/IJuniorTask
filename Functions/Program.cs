using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Functions
{
    class Program
    {

        static void Main(string[] args)
        {
           bool isPlaing = true;
           int packmanX,packmanY;
           int pacmanDX = 0, pacmanDY = 1;
           char[,] map = ReadMap("text.txt", out packmanX, out packmanY);

            DrawMap(map);

            while (isPlaing)
            {
               
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            pacmanDX = -1;pacmanDY = 0;
                            break;
                        case ConsoleKey.DownArrow:
                            pacmanDX = 1; pacmanDY = 0;
                            break;
                        case ConsoleKey.LeftArrow:
                            pacmanDX = 0; pacmanDY = -1;
                            break;
                        case ConsoleKey.RightArrow:
                            pacmanDX = 0; pacmanDY = 1;
                            break;
                      
                    }
                    if (map[packmanX + pacmanDX, packmanY + pacmanDY] != '#')
                    {
                        Console.SetCursorPosition(packmanY, packmanX);
                        Console.Write(" ");

                        packmanX += pacmanDX;
                        packmanY += pacmanDY;

                        Console.SetCursorPosition(packmanY, packmanX);
                        Console.Write('@');
                    }
                }
            }
        }

        static void DrawMap(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }

        }
       
         static char[,]ReadMap(string mapName, out int packmanX,out int packmanY)
        {
            packmanX = 0;
            packmanY = 0;
            string[] newFile = File.ReadAllLines($"Map/{mapName}");
            char[,] map = new char[newFile.Length, newFile[0].Length];
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    
                    map[i, j] = newFile[i][j];
                    if (map[i, j] == '@')
                    {
                        packmanX = i;
                        packmanY = j;
                    }
                    
                }
            }
            return map;
        }
    }
}
  


