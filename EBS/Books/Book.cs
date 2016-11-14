using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
  public class Book
  {
    //public string BookName;
    //public int ISBN;
    //public string AuthorName;
    //public string Publisher;

    public Book(int isbn, string bookname, string authorname, string publisher)
    {
      this.BookName = bookname;
      this.ISBN = isbn;
      this.AuthorName = authorname;
      this.Publisher = publisher;
  }

    public string BookName { get; set; }
    public int ISBN { get; set; }
    public string AuthorName { get; set; }
    public string Publisher { get; set; }



    public string GetBookInfo()
    {
      return this.ISBN + " " + this.BookName + " " + this.AuthorName + " " + this.Publisher;
    }

  }
}
