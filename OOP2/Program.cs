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
            zoo.AddToZoo(wolf);
            zoo.AddToZoo(fox);
            zoo.AddToZoo(hamster);
            zoo.AddToZoo(rabit);
            zoo.WelcomeZoo();
        }
    }
    class Animal
    {
        private string _name;
        private string _pol;
        private int _age;

        public Animal(string name,string pol,int age)
        {
            _name = name;
            _pol = pol;
            _age = age;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"я {_name} мой пол {_pol} мне {_age}");
        }
    }
    class Wolf : Animal
    {
        private string _zvuk;
        public Wolf(string name, string pol, int age,string zvuk) : base(name, pol, age)
        {
            _zvuk = zvuk;
        }
       public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("А вот мой звук " + _zvuk);
        }
    }

    class Fox : Animal
    {
        private string _zvuk;
        public Fox(string name, string pol, int age, string zvuk) : base(name, pol, age)
        {
            _zvuk = zvuk;
        }
        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("А вот мой звук " + _zvuk);
        }
    }
    class Hamster : Animal
    {
        private string _zvuk;
        public Hamster(string name, string pol, int age, string zvuk) : base(name, pol, age)
        {
            _zvuk = zvuk;
        }
        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("А вот мой звук " + _zvuk);
        }
    }
    class Rabbit : Animal
    {
        private string _zvuk;
        public Rabbit(string name, string pol, int age, string zvuk) : base(name, pol, age)
        {
            _zvuk = zvuk;
        }
        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("А вот мой звук " + _zvuk);
        }
    }
    class Zoo
    {
        List<Animal> listAnimals = new List<Animal>();
        public void AddToZoo(Animal animal)
        {
            listAnimals.Add(animal);
        }
        public void WelcomeZoo()
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
                    listAnimals[0].ShowInfo();
                    break;
                case 2:
                    listAnimals[1].ShowInfo();
                    break;
                case 3:
                    listAnimals[2].ShowInfo();
                    break;
                case 4:
                    listAnimals[3].ShowInfo();
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
