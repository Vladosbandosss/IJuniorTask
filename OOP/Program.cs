using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Влад");
            Person person1 = new Person("Паша");
            Person person2 = new Person("Рома");
            Person person3 = new Person("Саша");

            List<Person> personList = new List<Person>();
            personList.Add(person);
            personList.Add(person1);
            personList.Add(person2);
            personList.Add(person3);

            Carriage carriage = new Carriage(personList, 3);
            carriage.ReadyToMove();

            Person person4 = new Person("зоя");
            Person person5 = new Person("ян");
            Person person6 = new Person("клава");
            Person person7 = new Person("амир");
            Person person8 = new Person("хуанито");

            List<Person> personSecondList = new List<Person>();
            personSecondList.Add(person4);
            personSecondList.Add(person5);
            personSecondList.Add(person6);
            personSecondList.Add(person7);
            personSecondList.Add(person8);

            Carriage secondCarriage = new Carriage(personSecondList, 4);
            secondCarriage.ReadyToMove();

            List<Carriage> cariageList = new List<Carriage>();
            cariageList.Add(carriage);
            cariageList.Add(secondCarriage);
            Console.WriteLine();
            Train train = new Train(cariageList);
            train.ShowTrainInfo();
        }
    }
    class Person
    {
        private string _name;
        private bool _isHasTicket;

       public Person(string name)
        {
            _name = name;
            _isHasTicket = false;
        }
        public bool GetTicket()
        {
            return _isHasTicket;
        }
        public string GetName()
        {
            return _name;
        }
        public void ShowDescription()
        {
            string ticket = "";
            if (_isHasTicket == true)
            {
                ticket = "у меня есть билет";
            }
            else
            {
                ticket = "у меня нет билета";
            }
            Console.WriteLine($"я {_name} {ticket}");
        }
        public void AddTicket()
        {
            _isHasTicket = true;
        }
    }
    class Carriage
    {
       private int _size;
       private List<Person> _listPerson = new List<Person>();

        public Carriage(List<Person> personList,int size)
        {
            _size = size;
            if (personList.Count() > _size)
            {
                Console.WriteLine("на всех не хватит)Заполню как смогу");
            }
            for (int i = 0; i < size; i++)
            {
                _listPerson.Add(personList[i]);
            }
        }
        public void ReadyToMove()
        {
            for (int i = 0; i < _listPerson.Count; i++)
            {
                _listPerson[i].AddTicket();
                _listPerson[i].ShowDescription();
            }
        }
    }
    class Train
    {
        private List<Carriage> _carriageList = new List<Carriage>();

        public Train(List<Carriage> list)
        {
            _carriageList.AddRange(list);
        }
        public void ShowTrainInfo()
        {
            for (int i = 0; i < _carriageList.Count(); i++)
            {
                Console.Write("Вагон" + (i+1) + " люди");
                Console.WriteLine();
                _carriageList[i].ReadyToMove();
                Console.WriteLine();
            }
            Console.WriteLine("Все я уехал!Адьес");
        }
    }
}


   


