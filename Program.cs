using System;
using System.Collections.Generic;
using System.Linq;
using static BookRental.BookInfo;

namespace BookRental
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
            Console.WriteLine("*****************************************");
            Console.WriteLine("Hello, Welcome to Louisville Book Rental!");
            Console.WriteLine("*****************************************");
            Console.WriteLine("\nPress Enter To Shop For Books");
            Console.ReadLine();

            Menu();

            static void Menu()
            {

                Console.Clear();
                Console.WriteLine("**********************");
                Console.WriteLine("Louisville Book Rental");
                Console.WriteLine("**********************");
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("\n1) Browse Books");
                Console.WriteLine("\n2) Shopping Cart");
                Console.WriteLine("\n3) Return");


                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        var selection = new BookSelection();
                        selection.ListFunction();
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Your cart is empty! Press Enter to return to the Menu!");
                        Console.ReadLine();
                        Menu();
                        break;

                    case "3":
                        Console.Clear();
                        Menu();
                        break;

                    default:
                        Menu();
                        break;
                }

            }


            //static void ListOfBooks()
            //{
            //    Console.WriteLine("**********************");
            //    Console.WriteLine("Louisville Book Rental");
            //    Console.WriteLine("**********************");
            //    Console.WriteLine("\nBrowse and select your desired book below. There is a two book rental limit.");

            //    //List<BookInfo> books = new List<BookInfo>();
            //    {
            //       // books.Add(new BookInfo("\n1) testing", "testing", "testing", 2,3));
            //        //books.Add(new BookInfo("\n2) test", "test", "test", 2, 3));
            //        books.Add(new BookInfo("\n3) testi", "testi", "testi", 2, 3));

            //        foreach (var book in books)

            //        {

            //            Console.WriteLine($"\n{book.Genre}, {book.Author}, {book.Title}, {book.Pages}, {book.Price}");

            //        }

            //    }


            //    switch (Console.ReadLine())
            //    {
            //        case "1":

            //            Console.WriteLine($"You have selected ");
            //            Console.ReadLine();
            //            Console.Clear();
            //            ListOfBooks();






            //            break;

            //        case "2":

            //            Console.WriteLine("");
            //            break;

            //        case "3":

            //            break;

            //        default:
            //            break;



            //    }


            //}














        }


    }
}







