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
                        BrowseBooks();
                        return true;
                    case "2":
                        ShoppingCart();
                        return true;
                    case "3":
                        return false;
                    default:
                        return true;
                }

            }













            List<String> bookList = new List<String>(); 
            {
                bookList.Add("Harry Potter");
                bookList.Add("Long Road");

                foreach (String item in bookList)
                {
                    Console.WriteLine(item);
                }


            }












        }


    }
}







