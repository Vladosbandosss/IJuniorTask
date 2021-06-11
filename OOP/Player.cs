using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Player
    {
        private string _name;
        private int _health;
        private int _damage;

        public Player(string name,int health,int damage)
        {
            _name = name;
            _health = health;
            _damage = damage;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"имя {_name} здоровье {_health} урон {_damage}");
        }
    }
}
