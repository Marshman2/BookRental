using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRental
{
    public class BookInfo
    {
        public string genre { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int pages { get; set; }
        public int price { get; set; }

        public BookInfo(string aGenre, string aTitle, string aAuthor, int aPages, int aPrice)
        {
            genre = aGenre;
            title = aTitle;
            author = aAuthor;
            pages = aPages;
            price = aPrice;
        }




    }


}
        




















     
