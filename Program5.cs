using System;

// Zadanie 5

namespace PR11._5
{
    public class Product
    {
        private double _price;
        private double _discount;
        public string Name { get; set; } = "Без названия";
        public double Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Цена не может быть отрицательной!");
                    return;
                }
                _price = value;
            }
        }
        public double Discount
        {
            get { return _discount; }
            set
            {
                if (value < 0)
                    _discount = 0;
                else if (value > 100)
                    _discount = 100;
                else
                    _discount = value;
            }
        }
        public double FinalPrice
        {
            get { return Price * (1 - Discount / 100); }
        }
        public Product() { }

        public Product(double price, double discount)
        {
            Price = price;
            Discount = discount;
        }
        public Product(string name, double price, double discount)
        {
            Name = name;
            Price = price;
            Discount = discount;
        }
        public void Show()
        {
            Console.WriteLine($"{Name}: {FinalPrice:F0} (скидка {Discount}%)");
        }
    }     
        class Program 
        {
            static void Main(string[] args)
            {
                Product laptop = new Product("Ноутбук", 1000, 20);
                laptop.Show();
                laptop.Discount = 10;
                laptop.Price = 900;
                laptop.Show();
                laptop.Price = -100;
                laptop.Show();
            }
        }
    
}

