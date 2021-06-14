using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;
            Seller seller = new Seller(CreateGoods());
            Costumer costumer = new Costumer("Павел", 100);
            
            while (isWorking)
            {
                Console.WriteLine("Добро пожаловать в магазин");
                Console.WriteLine("Нажми 1 что б купить товар,нажми 2,что б посмотреть свои товары,3 что б выйти");
                int userInput;
                int.TryParse(Console.ReadLine(), out userInput);

                switch (userInput)
                {
                    case 1:
                        BuyGoods(seller, costumer);
                        break;
                    case 2:
                        Console.WriteLine("Давай посмотрим что у тебя есть");
                        costumer.ShowCostumerGoods();
                        break;
                    case 3:
                        isWorking = false;
                        break;
                    default:
                        Console.WriteLine("Что-то не то");
                        break;
                }
            }
            Console.WriteLine("Программа завершена");

        }

        private static void BuyGoods(Seller seller, Costumer costumer)
        {
            Console.WriteLine("Ты выбрал купить товары");
            seller.ShowSellerGoods();
            Console.WriteLine("У тебя есть " + costumer.ShowCostumerMoney());
            Console.WriteLine("Выбери товар который хочешь купить");
            int userWantBuy;
            int.TryParse(Console.ReadLine(), out userWantBuy);
            int finalUserDessicion = userWantBuy - 1;
            costumer.BuyGoods(CreateGoods(), finalUserDessicion);
            if (costumer.ShowCostumerMoney() >= seller.GetGoodPrice(finalUserDessicion))
            {
                seller.SellGoods(finalUserDessicion);
            }
        }

        public static List<Goods> CreateGoods()
        {
            List<Goods> allGoods = new List<Goods>();
            allGoods.Add (new Goods("Мяч", 50));
            allGoods.Add(new Goods("Компьютер", 200));
            allGoods.Add(new Goods("Чашка", 20));
            allGoods.Add(new Goods("Ручка", 10));
            allGoods.Add(new Goods("Кофе", 100));
            return allGoods;
        }
    }
   class Seller
    {
       private List<Goods> _goodsSellerList;

        public Seller(List<Goods> goodList)
        {
            _goodsSellerList = goodList;
        }
        public int GetGoodPrice(int index)
        {
            return _goodsSellerList[index].GetPriceGood();
        }
        public void ShowSellerGoods()
        {
            for (int i = 0; i < _goodsSellerList.Count; i++)
            {
                Console.Write("Позиция " + (i + 1) + "  ");
                _goodsSellerList[i].ShowGoodsDescription();
            }
        }
        public void SellGoods(int userInput)
        {
            for (int i = 0; i <=_goodsSellerList.Count; i++)
            {
                if (userInput == i )
                {
                    _goodsSellerList.Remove(_goodsSellerList[userInput]);
                }
            }
        }
    }
    class Costumer
    {
        private string _name;
        private int _money;
        private List<Goods> _costumerGoods = new List<Goods>();

        public Costumer(string name,int money)
        {
            _name = name;
            _money = money;
        }
        public int ShowCostumerMoney()
        {
            return _money;
        }
        public void ShowCostumerGoods()
        {
            for (int i = 0; i < _costumerGoods.Count; i++)
            {
               _costumerGoods[i].ShowGoodsDescription();
            }
        }
        public void BuyGoods(List<Goods>list,int userChoise)
        {
           
            if (_money >=list[userChoise].GetPriceGood())
            {
                _costumerGoods.Add(list[userChoise]);
                _money -= list[userChoise].GetPriceGood();
            }
            else
            {
                Console.WriteLine("Недостаточно денег");
               
            }
           
        }
    }
    class Goods
    {
        private string _name;
        private int _price;
        
        public Goods(string name,int price)
        {
            _name = name;
            _price = price;
        }
        public void ShowGoodsDescription()
        {
            Console.WriteLine($"Товар {_name} цена {_price}"); 
        }
        public int GetPriceGood()
        {
            return _price;
        }
    }
}

   


