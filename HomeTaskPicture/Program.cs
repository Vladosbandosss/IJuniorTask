using System;

namespace HomeTaskPicture
{
    class Program
    {
        static void Main(string[] args)
        {
            int allPicture = 52;
            int pictureInColuum = 3;
            int howMuchColumWeCanDo = allPicture / pictureInColuum;
            Console.WriteLine($"Всего мы сможем сделать {howMuchColumWeCanDo} колонок");
            int howMuchWeDone = howMuchColumWeCanDo * pictureInColuum;
            int pictureLose = allPicture - howMuchWeDone;
            Console.WriteLine($"Осталось лишней {pictureLose} картинка");
        }
    }
}
