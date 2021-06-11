using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Player myPlayer = new Player(10, 5);
            Drawer myDrawer = new Drawer();
            myDrawer.DrawPlayer(myPlayer);
        }
    }

    class Player
    {
        private int _x;
        private int _y;

       public int GetX()
        {
            return _x;
        }
        public int GetY()
        {
            return _y;
        }

         public Player(int x,int y)
        {
            _x = x;
            _y = y;
        }
    }

    class Drawer
    {
        public void DrawPlayer(Player player)
        {
            int xPos = player.GetX();
            int yPos = player.GetY();
            Console.SetCursorPosition(xPos, yPos);
            Console.WriteLine("Отрисовал");
        }
    }
}

