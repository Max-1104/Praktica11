using System;

// Zadanie 3

namespace PR11._3
{
    class Book
    {
        private string title;

        public int Pages { get; set; } = 1;

        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Название не может быть пустым или отсутствовать!");
                }

                else
                {
                    title = value;
                }
            }
        }

        public Book(string title)
        {
            Title = title;
        }

        public bool IsLong => Pages > 300;

        public void Info()
        {
            string longText;

            if (IsLong)
            {
                longText = "да";
            }

            else
            {
                longText = "нет";
            }

            Console.WriteLine($"Книга: {Title}, страниц: {Pages}, длинная: {longText}");
        }
    }
        class Program 
        {
            static void Main(string[] args)
            {
                Book book1 = new Book("Улисс");
                book1.Pages = 1152;
                book1.Info();

                Book book2 = new Book("");
                book2.Info();

                Book book3 = new Book("Краткая история");
                book3.Info();
            }
        }
    
}

