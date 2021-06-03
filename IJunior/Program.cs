using System;

namespace IJunior
{
    class Program
    {
        static void Main(string[] args)
        {
            string passworToAccount = "qwert";
            Console.WriteLine("Приветствую,введи пароль,что б получить доступ,у тебя 3 попытки");
            int tryCount = 3;
            while (tryCount > 0)
            {
                string pass = Console.ReadLine();
                if (passworToAccount == pass)
                {
                    Console.WriteLine("Пароль верный открываю доступ");
                    break;
                }
                else
                {
                    tryCount--;
                    if (tryCount == 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Неправильно у тебя осталось {tryCount} попыток");
                }

            }
            Console.WriteLine("Программа завершенна");

        }
    }
}

