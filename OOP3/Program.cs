using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;
            Fish fish = new Fish("Влад", 1);
            List<Fish> aquariumOfFish = new List<Fish>();
            aquariumOfFish.Add(fish);
            Aquarium aquarium = new Aquarium(aquariumOfFish);

            while (isWorking)
            {
                Console.WriteLine("Наш аквариум");
                aquarium.ShowAquarium();
                Console.WriteLine("Нажмите 1 - что б добавить рыбку,2 что б удалить,3 просто наблюдать,4 выход");
                int userInput;
                int.TryParse(Console.ReadLine(), out userInput);

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Добавляю рыбку,как назовем?");
                        string nameFish = Console.ReadLine();
                        int ageFish = 1;
                        Fish fishAdd = new Fish(nameFish, ageFish);
                        aquarium.AddAgeFish();
                        aquarium.AddFishAqua(fishAdd);
                        break;
                    case 2:
                        Console.WriteLine("Давайте удалим рыбку введи имя рыбки");
                        aquarium.ShowAquarium();
                        string nameFishDelete = Console.ReadLine();
                        aquarium.DeleteFishAqua(nameFishDelete);
                        aquarium.AddAgeFish();
                        break;
                    case 3:
                        Console.WriteLine("Наблюдаю");
                        aquarium.AddAgeFish();
                        break;
                    case 4:
                        Console.WriteLine("Выхожу");
                        isWorking = false;
                        break;
                    default:
                        Console.WriteLine("Ввели что то не то");
                        break;
                }
            }
        }
    }
    class Fish
    {
        private string _name;
        private int _age;
        private int _addAge = 1;

        public Fish(string name,int age)
        {
            _name = name;
            _age = age;
        }
        public void ShowDescription()
        {
            Console.WriteLine($"Рыба {_name} возраст {_age}");
        }
        public int GetAge()
        {
            return _age;
        }
        public string GetName()
        {
            return _name;
        }
        public void AddFishAge()
        {
            _age += _addAge;
        }
    }
    class Aquarium
    {
        private List<Fish> _fishList = new List<Fish>();
        private int _maxCountFish = 10;
        private int _maxAgeFish = 10;
        
        public Aquarium(List<Fish> list)
        {
            _fishList.AddRange(list);
        }
        
        public void AddAgeFish()
        {
            for (int i = 0; i < _fishList.Count; i++)
            {
                _fishList[i].AddFishAge();
            }
        }
        public void AddFishAqua(Fish fish)
        {
            if (_fishList.Count() <= _maxCountFish)
            {
                _fishList.Add(fish);
                Console.WriteLine("Рыбка добавлена");
            }
            else
            {
                Console.WriteLine("Слишком много рыбок");
            }
        }
      public void DeleteFishAqua(string name)
        {
        for (int i = 0; i < _fishList.Count(); i++)
        {
            if (_fishList[i].GetName() == name)
            {
                _fishList.Remove(_fishList[i]);
                Console.WriteLine("Удалили рыбку");
            }
        }
            
      }
        public void ShowAquarium()
        {
            for (int i = 0; i < _fishList.Count(); i++)
            {
                _fishList[i].ShowDescription();

                CheckDeath(i);
            }
        }

        private void CheckDeath(int i)
        {
            if (_fishList[i].GetAge() > _maxAgeFish)
            {
                _fishList.Remove(_fishList[i]);
                Console.WriteLine("Рыбка померла");
            }
        }
    }
}
