using System;

namespace IJunior
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваше место работы");
            string placeOfWork = Console.ReadLine();
            Console.WriteLine("Введите вашу зарплату");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Спасибо,вывожу информацию о вас");
            Console.WriteLine($"Вас зовут {name}, вам {age} лет. Вы работаете {placeOfWork} ,а ваша зарплата {salary} ");
            Console.WriteLine($"Кстати через год вам будет {age+1} и если к вашей зарплате прибавить 200 долларов ,то вы будете получать {salary+200}");

            
            

            

        }
    }
}
