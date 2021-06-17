using System;
using System.Collections.Generic;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            ZooPlay();
        }

        private static void ZooPlay()
        {
            Animal wolf = new Wolf("Волк", "Женский", 5, "УУУУ");
            Animal fox = new Fox("Лиса", "Мужской", 2, "Тяу");
            Animal hamster = new Hamster("Хомяк", "Женский", 3, "Я только кушаю");
            Animal rabit = new Rabbit("Кролик", "Женский", 1, "хррррр");
            Zoo zoo = new Zoo();
            zoo.AddAnimal(wolf);
            zoo.AddAnimal(fox);
            zoo.AddAnimal(hamster);
            zoo.AddAnimal(rabit);
            zoo.VisitAnimals();
        }
    }
    class Animal
    {
        private string _name;
        private string _sex;
        private int _age;
        private string _sound;

        public Animal(string name,string sex,int age,string sound)
        {
            _name = name;
            _sex = sex;
            _age = age;
            _sound = sound;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"я {_name} мой пол {_sex} мне {_age} мой звук {_sound}");
        }
    }
    class Wolf : Animal
    {
      public Wolf(string name, string pol, int age,string sound) : base(name, pol, age,sound)
        {
           
        }
       public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Я люблю охотиться");
        }
    }

    class Fox : Animal
    {
      public Fox(string name, string pol, int age, string sound) : base(name, pol, age, sound)
        {
            
        }
        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Я люблю курочек");
        }
    }
    class Hamster : Animal
    {
      public Hamster(string name, string pol, int age, string sound) : base(name, pol, age, sound)
        {
          
        }
        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Люблю кушать");
        }
    }
    class Rabbit : Animal
    {
        public Rabbit(string name, string pol, int age, string sound) : base(name, pol, age, sound)
        {
           
        }
        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Люблю морковку");
        }
    }
    class Zoo
    {
       private List<Animal> _animalsRouster = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            _animalsRouster.Add(animal);
        }

        public void VisitAnimals()
        {
           bool isWorking = true;

            while (isWorking)
            {
                isWorking = ChoseInZoo(isWorking);
            }
        }

        private bool ChoseInZoo(bool isWorking)
        {
            Console.WriteLine("Добро пожаловать в зоопарк");
            Console.WriteLine("Тут у нас 4 зверька выбирай 1 2 3 4 и посмотрим кто это,5 для выхода");
            int userInput;
            int.TryParse(Console.ReadLine(), out userInput);

            switch (userInput)
            {
                case 1:
                    _animalsRouster[0].ShowInfo();
                    break;
                case 2:
                    _animalsRouster[1].ShowInfo();
                    break;
                case 3:
                    _animalsRouster[2].ShowInfo();
                    break;
                case 4:
                    _animalsRouster[3].ShowInfo();
                    break;
                case 5:
                    Console.WriteLine("Пока");
                    isWorking = false;
                    break;
                default:
                    Console.WriteLine("Ошибка выбора");
                    break;
            }
        return isWorking;
        }
    }
}
