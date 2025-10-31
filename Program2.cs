using System;

// Zadanie 2

namespace PR11._2
{
    class Phone
    {
        private int battery;

        public string Brand { get; set; }

        public int BatteryLevel
        {
            get { return battery; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Заряд не может быть ниже 0% или превышать 100%!");
                }

                else
                {
                    battery = value;
                }
            }
        }

        public Phone(string brand, int batteryLevel)
        {
            Brand = brand;
            BatteryLevel = batteryLevel;
        }

        public void Use()
        {
            if (battery >= 10)
            {
                BatteryLevel = battery - 10;
            }

            else
            {
                BatteryLevel = 0;
            }

            Console.WriteLine($"{Brand}: заряд {BatteryLevel}%");
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                Phone phone = new Phone("Samsung Galaxy S25 Ultra", 50);

                phone.Use();
                phone.Use();
                phone.Use();

                phone.BatteryLevel = 150;
            }
        }
    
}

