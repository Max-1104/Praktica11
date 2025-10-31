using System;

// Zadanie 1

namespace PR11
{
    class Car
    {
        private int speed;

        public int Speed
        {
            get { return speed; }
            set
            {
                if (value < 0 || value > 300)
                {
                    Console.WriteLine("Ошибка: скорость должна быть от 0 до 300");
                }
                else
                {
                    speed = value;
                }
            }
        }

        public string Model { get; set; } = "unknown";

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public void Drive()
        {
            Console.WriteLine($"{Model} едет со скоростью {speed} км/ч");
        }
    }
        class Program 
        {
            static void Main(string[] args)
            {
                Car car1 = new Car("BMW", 120);
                car1.Drive();
                car1.Speed = 400;
                car1.Speed = -50; ;
                Console.ReadLine();
            }
        }
    
}

