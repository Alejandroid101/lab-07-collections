using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        public static Library<Book> library = new Library<Book>();
        public static List<Book> bookbag = new List<Book>();
        public Genre genre = new Genre();

        static void Main(string[] args)
        {

            LoadBooks();
            UserInterface();
        }

        static void UserInterface()
        {
            bool online = true;
            while (online)
            {
                Console.WriteLine("Welcome to Phil's Lending Library (PLL) LLC");
                Console.WriteLine("Main Menu options:");
                Console.WriteLine("1.) View all books.");
                Console.WriteLine("2.) Add a book.");
                Console.WriteLine("3.) Borrow a book.");
                Console.WriteLine("4.) Return a book");
                Console.WriteLine("5.) View book bag.");
                Console.WriteLine("6.) Exit Library.");
                Console.WriteLine("");

                string option = Console.ReadLine();
                //switch (option)
                //{
                //    case "1":
                //        ViewBooks();
                //        break;
                //    case "2":
                //        AddBook();
                //        break;
                //    case "3":
                //        BorrowBook();
                //        break;
                //    case "4":
                //        ReturnBook();
                //        break;
                //    case "5":
                //        BooksInBag();
                //        break;
                //    case "6":
                //        Environment.Exit(0);
                //        break;
                //    default:
                //        Console.WriteLine("That is not a valid option. Get it together!");
                //        break;
                //}
            }
        }

        public static void LoadBooks()
        {
            Book slauFive = new Book("Slaugtherhouse Five", new Author("Kurt", "Vonnegut"), Genre.Novel);
            Book digiFortress = new Book("Digital Fortress", new Author("Dan", "Brown"), Genre.Novel);
            Book selfish = new Book("The Selfish Gene", new Author("Richard", "Dawkins"), Genre.Other);
            Book alchemist = new Book("The Alchemist", new Author("Paulo", "Coelho"), Genre.Novel);
            Book it = new Book("IT", new Author("Stephen", "King"), Genre.Horror);
            Book aurelio = new Book("Meditations of Marcus Aurelius", new Author("Marcus", "Aurelius"), Genre.Philosophy;

            Book[] defaultLibrary = new Book[] { slauFive, digiFortress, selfish, alchemist, it, aurelio, };
            foreach (Book book in defaultLibrary)
            {
                library.Add(book);
            }
        }

        public static void ViewBooks()
        {
            foreach (Book book in library)
            {
                if (book != null)
                {
                    Console.WriteLine($"{book.Title}, Genre {book.Genre}. by {book.Author}. ");
                }
            }
        }


    }
}
