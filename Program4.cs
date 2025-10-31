using System;

// Zadanie 4

namespace PR11._4
{
    class Player
    {
        private int level;
        private int health;

        public string Name { get; set; }

        public int Level
        {
            get { return level; }
            set
            {
                if (value < 1)
                    level = 1;
                else if (value > 100)
                    level = 100;
                else
                    level = value;
            }
        }
        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0 || value > 100)
                {
                    health = 0;
                }
                else
                {
                    health = value;
                }
            }
        }
        public bool IsAlive
        {
            get
            {
                if (Health > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public Player(string name, int level, int health)
        {
            Name = name;
            Level = level;
            Health = health;
        }
        public void TakeDamage(int damage)
        {
            if (!IsAlive)
            {
                Console.WriteLine($"Игрок " + Name + " мертв!");
                return;
            }
            else
            {
                Health = Health - damage;
                Console.WriteLine(Name + " получил " + damage + " урона. Текущее здоровье: " + Health);
            }
            if (!IsAlive)
            {
                Console.WriteLine($"Игрок " + Name + " мертв!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Никита", 10, 100);
            Console.WriteLine("Создан игрок " + player.Name + ", уровень " + player.Level + ", здоровье " + player.Health + ".");

            player.TakeDamage(30);

            player.TakeDamage(100);

            player.TakeDamage(10);

            int player1level = 0;
            if (player1level < 1 || player1level > 100)
            {
                Console.WriteLine("Ошибка: лвл должен быть от 1 до 100");
            }
            else
            {
                Player player1 = new Player("Миша", player1level, 50);

                Console.WriteLine("Создан игрок " + player1.Name + ": уровень " + player1.Level + ", здоровье " + player1.Health + ".");
            }
        }

    }

}

