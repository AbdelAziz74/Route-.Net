using AdvCSharp4;

namespace AdvCSharp4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public delegate string fPtr(Book b);

    class Program
    {
       
        
        static void Main(string[] args)
        {
            DateTime d = new DateTime(1997, 03, 28);
            string[] authors = { "J.K.Rowlling", "Autohr2", "Author3" };
            Book b1 = new Book("31235", "Harry Potter", authors, d, 1200);
            Book[] booksarr = new Book[] { b1 };
            //User Defined Delegate  delegate
            fPtr myDel = BookFunctions.GetAuthors;
            Console.WriteLine("Using Func");
            LibraryEngine.ProcessBooks(booksarr, BookFunctions.GetTitle, 1);
            Console.WriteLine();
            Console.WriteLine("Using user defined delegate");
            LibraryEngine.ProcessBooks(booksarr, myDel);
            Console.WriteLine();
            Console.WriteLine("sending delegate as parameter");
            LibraryEngine.ProcessBooks(booksarr, delegate (Book book) { return book.ISBN; });

            Console.WriteLine("Lambda expression");
            LibraryEngine.ProcessBooks(booksarr, (Book book) => { return (BookFunctions.GetAuthors(book)); });
            Console.WriteLine("Lambda expression one line statement");
            LibraryEngine.ProcessBooks(booksarr, book => book.PublicationDate.ToShortDateString());

        }
    }
}
public class Book
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string[] Authors { get; set; }
    public DateTime PublicationDate { get; set; }
    public decimal Price { get; set; }
    public Book(string _ISBN, string _Title,
    string[] _Authors, DateTime _PublicationDate,
    decimal _Price)
    {
        ISBN = _ISBN;
        Title = _Title;
        Authors = _Authors;
        PublicationDate = _PublicationDate;
        Price = _Price;
    }
    public override string ToString()
    {
        string bookAuthors = "";
        foreach (var a in Authors) { bookAuthors += a + "\n"; }

        return $"ISBN: {ISBN}\nTitle : {Title}\nAuthors : {bookAuthors}price : {Price}\nPublication date : {PublicationDate.ToShortDateString()} ";
    }
}
public class BookFunctions
{
    public static string GetTitle(Book B)
    {
        return B.Title;
    }
    public static string GetAuthors(Book B)
    {
        string bookAuthors = "";
        foreach (var a in B.Authors)
            bookAuthors += a + "\n";

        return bookAuthors;
    }
    public static string GetPrice(Book B)
    {
        return (B.Price).ToString();
    }
}
public class LibraryEngine
{
    public static void ProcessBooks(Book[] bList, Func<Book, string> funcExample, int a)
    {

        foreach (Book B in bList)
        {
            Console.WriteLine(funcExample(B));
        }
    }

    public static void ProcessBooks(Book[] bList, fPtr mydel)
    {

        foreach (Book B in bList)
        {
            Console.WriteLine(mydel(B));
        }
    }
}
