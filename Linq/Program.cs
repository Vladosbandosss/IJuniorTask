using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            persons.AddRange(CreatePersons());
            Console.WriteLine("Люди в тюрьме"); 

            for (int i = 0; i < persons.Count; i++)
            {
                persons[i].ShowDescription();
            }

            var amnistiaMurders = persons.Where(prest => prest.GetMurderInfo() != "Антиправительственное").ToList();

            Console.WriteLine("Вот список людей которые остануться в тюрьме");
            foreach (var item in amnistiaMurders)
            {
                item.ShowDescription();
            }


        }

        private static List<Person> CreatePersons()
        {
            List<Person> personList = new List<Person>();
            Person firstPerson = new Person("Vlad","Воровство");
            personList.Add(firstPerson);
            Person secondPerson = new Person("Pasha","Воровство");
            personList.Add(secondPerson);
            Person thirdPerson = new Person("Roma","Антиправительственное");
            personList.Add(thirdPerson);
            Person fourthPerson = new Person("Sasha","Антиправительственное");
            personList.Add(fourthPerson);
            Person fifthPerson = new Person("Katya","Антиправительственное");
            personList.Add(fifthPerson);
            return personList;
        }
    }
    class Person
    {
        private string _name;
        private string _murderInfo;

        public Person(string name,string murderInfo)
        {
            _name = name;
            _murderInfo = murderInfo;
        }

        public void ShowDescription()
        {
         Console.WriteLine($"{_name} преступление  {_murderInfo}");
        }

        public string GetMurderInfo()
        {
            return _murderInfo;
        }
    }
}
