using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;
            DataBase listPlayers = new DataBase();
           
          
            while (isWorking)
            {
                Console.WriteLine("Добро пожаловать нажмите 1 что б добавить игрока,2 забанить,3 разабнить,4 удалить,5 выход");
                try
                {
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    switch (userInput)
                    {
                        case 1:
                            listPlayers.CreatPlayer();
                            break;
                        case 2:
                            listPlayers.ShowAllPlayers();
                            listPlayers.BunPlayers();
                             break;
                        case 3:
                            listPlayers.ShowAllPlayers();
                            listPlayers.UnBunPlayers();
                            break;
                        case 4:
                            listPlayers.ShowAllPlayers();
                            listPlayers.DeletePlayers();
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
      public  List<Player> playersList = new List<Player>();

        public  void BunPlayers()
        {
            Console.WriteLine("Введите номер который хотите забанить");
            int numberToBan = OperationWithPlayer();
          
            for (int i = 0; i < playersList.Count; i++)
            {
                if (playersList[i].GetPlayerNumber() == numberToBan)
                {
                    playersList[i].BanUser();
                }
            }
        }

    public void UnBunPlayers()
    {
        Console.WriteLine("Введите номер который хотите разбанить");
        int numberToUnbun = OperationWithPlayer();
        
        for (int i = 0; i < playersList.Count; i++)
        {
            if (playersList[i].GetPlayerNumber() == numberToUnbun)
            {
                playersList[i].UnBunUser();
            }
        }
    }
    public  void DeletePlayers()
        {
            Console.WriteLine("Введите номер который хотите удалить");
            int numberToBan = OperationWithPlayer();

            for (int i = 0; i < playersList.Count; i++)
            {
                if (playersList[i].GetPlayerNumber() == numberToBan)
                {
                    playersList.Remove(playersList[i]);
                }
            }
        }

        private static int OperationWithPlayer()
        {
            int numberToBan;
            int.TryParse(Console.ReadLine(), out numberToBan);
            return numberToBan;
        }

        public  void ShowAllPlayers()
    {
        for (int i = 0; i < playersList.Count; i++)
        {
            playersList[i].ShowInfo();
        }
    }

        public void CreatPlayer()
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
            playersList.Add(player);
        }
    }
}

   


