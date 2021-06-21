using System;
using System.Collections.Generic;

namespace OOP5
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем детали с прайсом
            Detail detailWhell = new Detail(100, RosterDetails.Wheel);
            Detail detailHood = new Detail(150, RosterDetails.Hood);
            Detail detailHeadLight = new Detail(120,RosterDetails.Headlight);
            Detail detailRudder = new Detail(200, RosterDetails.Rudder);
            Detail detailTrunk = new Detail(130, RosterDetails.Trunk);
            //создаем авто
            ClientCar firstClientCar = new ClientCar(150, detailWhell);
            ClientCar secondClientCar = new ClientCar(50, detailHood);
            ClientCar thirdClientCar = new ClientCar(200, detailTrunk);
            //создали список деталей
            List<Detail> detailList = new List<Detail>();
            detailList.Add(detailWhell);
            detailList.Add(detailHood);
            detailList.Add(detailHeadLight);
            detailList.Add(detailRudder);
            detailList.Add(detailTrunk);
            //созщдали список авто
            List<ClientCar> clientsList = new List<ClientCar>();
            clientsList.Add(firstClientCar);
            clientsList.Add(secondClientCar);
            clientsList.Add(thirdClientCar);

            CarServise carServise = new CarServise(200, detailList, clientsList);
            bool isWorking = true;

            while (isWorking)
            {
                Console.WriteLine("Добро пожаловать в автосервис");
                Console.WriteLine("нажми 1 что б зайти в мастерску,2 что б выйти");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        carServise.ShowOurItems();
                        Console.WriteLine("Начинаю ремонт");
                        carServise.MakeRepair();
                        isWorking = false;
                        break;
                    case "2":
                        Console.WriteLine("Всего доброго");
                        isWorking = false;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Программа полностью завершена");
        }
    }

    enum RosterDetails
    {
        Wheel,
        Hood,
        Headlight,
        Rudder,
        Trunk
    }

    class Detail
    {
        private int _price;
        private RosterDetails _descriptionDetail;

        public Detail(int price,RosterDetails descriptionDetail)
        {
            _price = price;
            _descriptionDetail = descriptionDetail;
        }
        
         public void ShowDescription()
        {
            string detailInfo;

            switch (_descriptionDetail)
            {
                case RosterDetails.Wheel:
                    detailInfo = "Колесо";
                    break;
                case RosterDetails.Hood:
                    detailInfo = "Капот";
                    break;
                case RosterDetails.Headlight:
                    detailInfo = "Фара";
                    break;
                case RosterDetails.Rudder:
                    detailInfo = "Руль";
                    break;
                case RosterDetails.Trunk:
                    detailInfo = "Багажник";
                    break;
                default:
                    detailInfo = "Неизвестная Деталь";
                    break;
            }

            Console.WriteLine($"деталь: {detailInfo}");
        }
        public int GetPrice()
        {
            return _price;
        }
    }
    
    class ClientCar
    {
        private int _clientMoney;
        private Detail _brokenDetail;
        
        public ClientCar(int clientMoney,Detail brokenDetail)
        {
            _clientMoney = clientMoney;
            _brokenDetail = brokenDetail;
        }

        public void ShowProblem()
        {
            Console.WriteLine($"у меня есть {_clientMoney} $ мне нужно починить ");
            _brokenDetail.ShowDescription();
        }

        public Detail GetBrokenDeatail()
        {
            return _brokenDetail;
        }
        
        public int GetMoney()
        {
            return _clientMoney;
        }
    }
    
    class CarServise
    {
        private int _serviceMoney;
        private List<Detail> _listServiceDeatails = new List<Detail>();
        private List<ClientCar> _listClientsCar = new List<ClientCar>();

        public CarServise(int serviseMoney, List<Detail> listServiseDeatails, List<ClientCar>listClientCar)
        {
            _serviceMoney = serviseMoney;
            _listServiceDeatails.AddRange(listServiseDeatails);
            _listClientsCar.AddRange(listClientCar);
        }
        public void ShowOurItems()
        {
            Console.WriteLine($"Сумма баланса - {_serviceMoney}");
            Console.WriteLine("Приветствую,вот что есть у меня в мастерской");

            for (int i = 0; i < _listServiceDeatails.Count; i++)
            {
                _listServiceDeatails[i].ShowDescription();
            }
        }
        public int GetMoney()
        {
            return _serviceMoney;
        }
        
        public void MakeRepair()
        {
            int fine = 50;
            int serviceMoney = GetMoney();
            Console.WriteLine("Наш баланс " + serviceMoney);

            for (int i = 0; i < _listClientsCar.Count; i++)
            {
                _listClientsCar[i].ShowProblem();
                int isGoorRepaire = 0;
                for (int j = 0; j < _listServiceDeatails.Count; j++)
                {
                   
                    if (_listServiceDeatails[j].GetPrice() == _listClientsCar[i].GetBrokenDeatail().GetPrice() && _listServiceDeatails[j].GetPrice()<=_listClientsCar[i].GetMoney())
                    {
                        Console.WriteLine("Починил!");
                        serviceMoney += _listClientsCar[i].GetMoney();
                        Console.WriteLine("теперь у нас нету "); 
                        _listServiceDeatails[j].ShowDescription();
                        _listServiceDeatails.RemoveAt(j);
                        isGoorRepaire++;
                        break;
                        
                    }                
                }
                if (isGoorRepaire == 0)
                {
                    serviceMoney -= fine;
                    Console.WriteLine("Ремонт не удался плачу штраф");
                }
                
                Console.WriteLine("Закончил,теперь у нас " + serviceMoney + " денег");
            }
            Console.WriteLine("теперь у нас " + serviceMoney + " вот какие детали остались");

            for (int i = 0; i < _listServiceDeatails.Count; i++)
            {
                _listServiceDeatails[i].ShowDescription();
            }

        }
    }
}
