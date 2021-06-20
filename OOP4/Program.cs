using System;
using System.Collections.Generic;

namespace OOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isShopWorking = true;

            Shop shop = ShopService();

            while (isShopWorking)
            {
                Console.WriteLine("Добро пожаловать в магазин!Нажми 1 что б обслужить людей,2 что б выйти");
               string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        shop.MakeSale();
                        break;
                    case "2":
                        Console.WriteLine("Пока");
                        isShopWorking = false;
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
            }
        }

        private static Shop ShopService()
        {
            Product productChease = new Product("Сыр", 100);
            Product productMilk = new Product("Молоко", 150);
            Product productCoffe = new Product("Кофе", 50);
            Product productTea = new Product("Чай", 60);
            Product productPC = new Product("Компьютер", 200);
            Product productNapkin = new Product("Салфетка", 80);

            List<Product> productsFirst = new List<Product>
            {
                productChease,
                productCoffe
            };

            Customer customer = new Customer(250, productsFirst);

            List<Product> productSecond = new List<Product>
           {
               productChease,
               productMilk,
               productCoffe
           };

            Customer secondCustomer = new Customer(200, productSecond);

            List<Customer> customerList = new List<Customer>();
            customerList.Add(customer);
            customerList.Add(secondCustomer);

            Shop shop = new Shop(customerList);
            return shop;
        }
    }
    class Product
    {
        private string _name;
        private int _price;

        public Product(string name,int price)
        {
            _name = name;
            _price = price;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetPrice()
        {
            return _price;
        }

        public void ShowDescription()
        {
            Console.WriteLine($"{_name} цена {_price} р");
        }
    }

    class Customer
    {
        private int _money;
        private List<Product> _productsList = new List<Product>();

        public Customer(int money, List<Product> products)
        {
            _money = money;
            _productsList.AddRange(products);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"У меня есть {_money} р");
            Console.WriteLine("Вот мой список продуктов");

            for (int i = 0; i < _productsList.Count; i++)
            {
                _productsList[i].ShowDescription();
            }
        }

        public int GetMyMoney()
        {
            return _money;
        }

        public int GetProductsPrice()
        {
            int moneyForPrice = 0;

            for (int i = 0; i < _productsList.Count; i++)
            {
                moneyForPrice += _productsList[i].GetPrice();
            }

            return moneyForPrice;
        }

       public void RemoveProducts()
        {
            Random random = new Random();
            int revomeRroduct = random.Next(0, _productsList.Count);
            ///for (int i = 0; i < _productsList.Count; i++)
            //{
                _productsList.RemoveAt(revomeRroduct);
            //}
        }
    }

    class Shop
    {
        private List<Customer> _customers = new List<Customer>();

        public Shop(List<Customer> customers)
        {
            _customers.AddRange(customers);
        }
        
        public void MakeSale()
        {
            for (int i = 0; i < _customers.Count;)
            {
                Console.WriteLine("У нас есть " + _customers[i].GetMyMoney() + " сумма покупок " + _customers[i].GetProductsPrice());

                if (_customers[i].GetMyMoney() >= _customers[i].GetProductsPrice())
                {
                    Console.WriteLine("Покупка прошла успешно!");
                    _customers.RemoveAt(i);
                    //i++;
                }
                else
                {
                    Console.WriteLine("Нешта ты много набрал,ща выкину что нибудь");
                    while(_customers[i].GetMyMoney() <= _customers[i].GetProductsPrice())
                    {
                        _customers[i].RemoveProducts();
                    }
                    // _customers[i].RemoveProducts();
                    Console.WriteLine("Вышвырнул,покупка прошла успешно");
                    i++;
                   // MakeSale();
                }
            }
        }
    }
}
