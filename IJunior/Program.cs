using System;

namespace IJunior
{
    class Program
    {
        static void Main(string[] args)
        {
            string NameThatWillBePrinted = "Vlad";

            Console.WriteLine($"Здравствуйте,я выведу слово {NameThatWillBePrinted} привет столько раз сколько вы захотите");
            Console.WriteLine("Сколько раз вывести?");
            int countOfRepeat = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < countOfRepeat; i++)
            {
                Console.WriteLine(NameThatWillBePrinted);
            }
            
            

            

        }
    }
}
