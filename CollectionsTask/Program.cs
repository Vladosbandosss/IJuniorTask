using System;
using System.Collections.Generic;

namespace CollectionsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;
            Dictionary<string, int> vocabulary = new Dictionary<string, int>();
            vocabulary.Add("a",1);
            vocabulary.Add("b",2);
            vocabulary.Add("c",3);
            vocabulary.Add("d",4);
            vocabulary.Add("e",5);
            vocabulary.Add("f",6);
            vocabulary.Add("g",7);
            vocabulary.Add("h",8);
            vocabulary.Add("i",9);

            while (isWorking)
            {
                Console.WriteLine("Введи слова,поищу значение");
                string userWord = Console.ReadLine();

                if (vocabulary.ContainsKey(userWord))
                {
                    Console.WriteLine("Все хорошо,вот значение " + vocabulary[userWord]);
                }
                else
                {
                    Console.WriteLine("нет такого значения");
                }
            }
        }
    }
}
