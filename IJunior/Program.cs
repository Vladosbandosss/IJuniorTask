using System;

namespace IJunior
{
    class Program
    {
        static void Main(string[] args)
        {
            bool workApp = true;
            int appPasword = 12345;
            
            while (workApp)
            {
                Console.WriteLine("Выбери команду а я исполню!");
                Console.WriteLine("Нажми 1 что б изменить название консоли");
                Console.WriteLine("Нажми 2 что б изменить цвет консоли");
                Console.WriteLine("Нажми 3,введешь свое имя и я выведу его 3 раза");
                Console.WriteLine("нажми 4 и введи пароль и я расскажу историю");
                Console.WriteLine("Нажми другую цифру любую и прекратим");
                int numberChoose = Convert.ToInt32(Console.ReadLine());
                switch (numberChoose)
                {
                    case 1:
                        Console.WriteLine("Веди новое название для консоли");
                        string consoleNewName = Console.ReadLine();
                        Console.Title =consoleNewName;
                        Console.WriteLine("Готово название изменено");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Готово цвет консоли изменен");
                        break;
                    case 3:
                        Console.WriteLine("Введи имя");
                        string name = Console.ReadLine();
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write(name + " ");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Веди пароль,надеюсь ты его не забыл");
                        int myPassword = Convert.ToInt32(Console.ReadLine());
                        if (appPasword == myPassword)
                        {
                            Console.WriteLine("Верный пароль,но я уже забыл истроию(");

                        }
                        else
                        {
                            Console.WriteLine("Пароль не верный");
                        }
                        
                        break;
                        
                     default:
                        Console.WriteLine("Жаль,что ты решил прекратить работу,пока");
                        workApp = false;
                        break;
                }
             }
                Console.WriteLine("Спасибо,работа окончена");
             }
           
        }
    }

