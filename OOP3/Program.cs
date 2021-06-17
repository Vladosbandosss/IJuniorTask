using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Fish
    {
        private string _name;
        private int _age;


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
    }
    class Aquarium
    {
        private List<Fish> _fishList = new List<Fish>();
        private int _maxFish = 10;
        private int _minFish = 1;
        

        public Aquarium(List<Fish> list)
        {
            _fishList.AddRange(list);
        }
        
        public List<Fish> GetFishList()
        {
            return _fishList;
        }
        
        public void AddFishAqua(Fish fish)
        {
            if (_fishList.Count() <= _maxFish)
            {
                _fishList.Add(fish);
                Console.WriteLine("Рыбка добавлена");
            }
            else
            {
                Console.WriteLine("Слишком много рыбок");
            }
        }
      public void DeleteFishAqua(int userChoise)
        {
            if (_fishList.Count() > _minFish)
            {
                _fishList.Remove(_fishList[userChoise-1]);
            }
            else
            {
                Console.WriteLine("У нас тогда не будет рыбок(");
            }
        }
        public void ShowAquarium()
        {
            for (int i = 0; i < _fishList.Count(); i++)
            {
                _fishList[i].ShowDescription();
            }
        }
    }
}
