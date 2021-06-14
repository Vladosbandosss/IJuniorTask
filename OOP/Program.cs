using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;
            List<Player> players = new List<Player>();
          
            while (isWorking)
            {
                Console.WriteLine("Добро пожаловать нажмите 1 что б добавить игрока,2 забанить,3 разабнить,4 удалить,5 выход");
                try
                {
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    switch (userInput)
                    {
                        case 1:
                            CreatPlayer(players);
                            break;
                        case 2:
                            ShowAllPlayers(players);
                            BunPlayers(players);
                            
                            break;
                        case 3:
                            ShowAllPlayers(players);
                            UnBunPlayers(players);

                            break;
                        case 4:
                            ShowAllPlayers(players);
                            DeletePlayers(players);

                            break;
                        case 5:
                            isWorking = false;
                            break;
                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка ввода");
                }
            }
            Console.WriteLine("Программа завершена");
        }

        private static void BunPlayers(List<Player> players)
        {
            int numberToBan = CheckPlayerInput();

            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].GetPlayerNumber() == numberToBan)
                {
                    players[i].BanUser();
                }
            }
        }

        public static int CheckPlayerInput()
        {
            Console.WriteLine("Введите номер который хотите забанить");
            int numberToBan;
            int.TryParse(Console.ReadLine(), out numberToBan);
            return numberToBan;
        }

        private static void UnBunPlayers(List<Player> players)
        {
            int numberToUnban = CheckPlayerInput();
            UnBanPlayer(players, numberToUnban);
        }

        private static void UnBanPlayer(List<Player> players, int numberToUnban)
        {
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].GetPlayerNumber() == numberToUnban)
                {
                    players[i].UnBunUser();
                }
            }
        }

        private static void DeletePlayers(List<Player> players)
        {
            int numberToDelete = CheckPlayerInput();

            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].GetPlayerNumber() == numberToDelete)
                {
                    players.Remove(players[i]);
                }
            }
        }

        private static void ShowAllPlayers(List<Player> players)
        {
            for (int i = 0; i < players.Count; i++)
            {
                players[i].ShowInfo();
            }
        }

        private static void CreatPlayer(List<Player> players)
        {
            int playerLevel;
            int playerNumber;
            Console.WriteLine("Введите имя");
            string playerName = Console.ReadLine();
            Console.WriteLine("Введиите порядковый номер");
            int.TryParse(Console.ReadLine(), out playerNumber);
            Console.WriteLine("Введите уровень");
            int.TryParse(Console.ReadLine(), out playerLevel);
            Player player = new Player(playerNumber, playerName, playerLevel);
            players.Add(player);
        }
    }
    class Player
    {
        private int _playerNumber;
        private string _playerName;
        private int _playerLevel;
        private bool _isBan;

        public Player(int number, string name, int level)
        {
            _playerNumber = number;
            _playerName = name;
            _playerLevel = level;
            _isBan = false;
        }

         public void ShowInfo()
        {
            Console.WriteLine($"номер {_playerNumber} имя {_playerName} уровень {_playerLevel} статус бана {_isBan}");
        }
        public void BanUser()
        {
            if (_isBan == false)
            {
                _isBan = true;
            }
        }
        public void UnBunUser()
        {
            if (_isBan == true)
            {
                _isBan = false;
            }
        }
        public int GetPlayerNumber()
        {
            return _playerNumber;
        }
    }

    class DataBase
    {
       //что запихивать не понимаю(
    }
}
   


