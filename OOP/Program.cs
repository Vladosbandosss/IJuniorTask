using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;

            while (isWorking)
            {
                Console.WriteLine("Поезда свободны");
                Console.WriteLine("Добро пожаловать 1-что б отправить людей,2 выйти");
                int userInput;
                int.TryParse(Console.ReadLine(), out userInput);

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Давай создавай пассажиров нажми exit что б прекратить");
                        bool isCreating = true;
                        List<Person> personList = new List<Person>();

                        while (isCreating)
                        {
                            Console.WriteLine("Вводи");
                            string userComand = Console.ReadLine();

                            if (userComand == "exit")
                            {
                                isCreating = false;
                            }
                            else
                            {
                                Person person = new Person(userComand);
                                person.ShowDescription();
                                personList.Add(person);
                            }
                        }

                        Console.WriteLine("Ну все у нас " + personList.Count() + " пассажиров");
                        Console.WriteLine("Засовываем по вагонам!");
                        Random random = new Random();
                        int freePlace = random.Next(2, 5);

                        if (freePlace >= personList.Count())
                        {
                            Console.WriteLine("Все всех запихнули в 1 вагон");
                            Carriage carriage = new Carriage(personList,personList.Count());
                            List<Carriage> onlyOneCarriage = new List<Carriage>();
                            onlyOneCarriage.Add(carriage);
                            Train train = new Train(onlyOneCarriage);
                            carriage.ReadyToMove();
                            train.ShowTrainInfo();
                        }
                        else
                        {
                            Console.WriteLine("");
                            List<Carriage> carriageList = new List<Carriage>();
                            Console.WriteLine("епрст,надо несколько вагонов");

                            for (int i = 0; i <personList.Count();)
                            {
                                Carriage carriage = new Carriage(personList, freePlace);
                                carriageList.Add(carriage);
                                i += freePlace;
                                personList.RemoveRange(0,freePlace);
                                freePlace = random.Next(1, 5);
                            }
                            Carriage carriage1 = new Carriage(personList, personList.Count());
                            carriageList.Add(carriage1);
                            
                            Train train = new Train(carriageList);
                            train.ShowTrainInfo();
                            Console.WriteLine("Поезд в рейсе");
                        }

                    break;
                        case 2:
                        Console.WriteLine("Адьос");
                        isWorking = false;
                    break;
                    default:
                        Console.WriteLine("Ошибка");
                    break;
                }
            }
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

            for (int i = 0; i < _size; i++)
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


   


