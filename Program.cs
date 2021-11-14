using System;
using System.Collections.Generic;
using System.Linq;

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
                    

                    string userinput;
                    userinput = Console.ReadLine();



                switch (userinput)
                {
                    case "1":
                        Console.Clear();
                        ListOfBooks();
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("Your cart is empty!");
                        Console.ReadLine();
                        
                        break;

                    case "3":
                        Console.Clear();
                        Menu();
                        break;
                        
                    default:
                        break;
                }

            }


            static void ListOfBooks()
            {
                Console.WriteLine("**********************");
                Console.WriteLine("Louisville Book Rental");
                Console.WriteLine("**********************");
                Console.WriteLine("\nBrowse and select your desired book below. There is a two book rental limit.");

                List<BookInfo> books = new List<BookInfo>();
                {
                    books.Add(new BookInfo("\n1) testing", "testing", "testing", 2,3));
                    books.Add(new BookInfo("\n2) test", "test", "test", 2, 3));
                    books.Add(new BookInfo("\n3) testi", "testi", "testi", 2, 3));

                    foreach (var book in books)

                    {

                        Console.WriteLine($"\n{book.genre}, {book.author}, {book.title}, {book.pages}, {book.price}");

                    }

                }
                string userinput;
                userinput = Console.ReadLine();

                switch (userinput)
                {
                    case "1":
                        Console.WriteLine("You have selected testing");



                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("");
                        break;

                    case "3":
                        Console.Clear();
                        Menu();
                        break;

                    default:
                        break;



                }
                String input = Console.ReadLine();
                List<String> userList = new List<String>();
                userList.Add(input);
                String inputNewUser = Console.ReadLine();
                userList.Add(inputNewUser);
                foreach (var user in userList)
                {
                    Console.WriteLine(user);



                   


                }

            }
           
            












        }


    }
}







