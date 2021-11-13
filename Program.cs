using System;
using System.Collections.Generic;

namespace BookRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("Hello, Welcome to Louisville Book Rental!");

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        
            static bool MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Browse Books");
                Console.WriteLine("2) Shopping Cart");
                Console.WriteLine("3) Exit");

                switch (Console.ReadLine())
                {
                    case "1":
                        BookBrowser.BrowseBooks();
                        return true;
                    case "2":
                        //ShoppingCart();
                        return true;
                    case "3":
                        Console.Clear();
                        ListOfBooks();
                        Console.ReadLine();
                        return false;
                    default:
                        return true;
                }

            }


            static void ListOfBooks()
            {

                List<BookInfo> books = new List<BookInfo>();
                {
                    books.Add(new BookInfo("testing", "testing", "testing", 2, 3));
                    books.Add(new BookInfo("test", "test", "test", 2, 3));
                    books.Add(new BookInfo("testi", "testi", "testi", 2, 3));

                    foreach (var book in books)
                    {
                        Console.WriteLine($"Here is a book: {book.genre}, {book.author}, {book.title}, {book.pages}, {book.price}");
                    }

                }
            }












        }


    }
}







