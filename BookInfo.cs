using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRental
{
    public class BookInfo
    {
        public string Genre { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Price { get; set; }

        ////public BookInfo(string aGenre, string aTitle, string aAuthor, int aPages, int aPrice)
        //{
        //    Genre = aGenre;
        //    Title = aTitle;
        //    Author = aAuthor;
        //    Pages = aPages;
        //    Price = aPrice;
        //}

        public class BookSelection
        {
            BookInfo _book1;
            BookInfo _book2;
            BookInfo _book3;

            public BookSelection()
            {
                _book1 = new BookInfo()
                {
                    Title = "Star Wars",
                    Author = "George Lucas",
                    Genre = "Science Fiction",
                    Pages = (int)200,
                    Price = (int)2.00
                };

                _book2 = new BookInfo()
                {
                    Title = "Harry Potter",
                    Author = "JK Rowling",
                    Genre = "Fantasy",
                    Pages = (int)500,
                    Price = (int)12.00
                };

                _book3 = new BookInfo()
                {
                    Title = "Lord of the Rings",
                    Author = "Tolkien",
                    Genre = "Adventure",
                    Pages = (int)2000,
                    Price = (int)20.00
                };
            }

            public void ListFunction()
            {
                List<BookInfo> books = new();
                books.Add(_book1);
                books.Add(_book2);
                books.Add(_book3);

                foreach(var book in books)
                {
                    Console.WriteLine($"\nTitle: {book.Title} \nAuthor: {book.Author} \nGenre: {book.Genre} \nPages: {book.Pages} \nPrice: ${book.Price}");
                }
            }





            }




    }


}
        




















     
