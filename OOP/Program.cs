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

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

       public int Y
        {
            get { return _y; }
            set { _y = value; }
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
            int xPos = player.X;
            int yPos = player.Y;
            Console.SetCursorPosition(xPos, yPos);
            Console.WriteLine("Отрисовал");
        }
    }
}

