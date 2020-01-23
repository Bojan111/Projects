using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();
            while (true)
            {
                Console.WriteLine("Enter author to quit enter 'q'");
                Console.Write("Author First Name: ");
                var firstname = Console.ReadLine();
                if(firstname == "q")
                {
                    Console.WriteLine("Bye!");
                    break;
                }
                Console.Write("Author Last Name: ");
                var lastname = Console.ReadLine();

                Console.Write("Enter number of books: ");
                var bookCount = int.Parse(Console.ReadLine());

                var newwriter = new Writer();
                newwriter.AddName(firstname,lastname);
                for (int i = 0; i < bookCount; i++)
                {
                    Console.Write($"{i} book title: ");
                    var bookTitle = Console.ReadLine();

                    var book = new Book(newwriter, bookTitle);
                    library.AddBooks(book);
                }
            }
            Console.WriteLine("Serach by author first name, to exit enter 'q'");
            while (true)
            {
                Console.Write("Author first name: ");
                var authorName = Console.ReadLine();
                if (authorName == "q")
                {
                    Console.WriteLine("Bye!");
                    break;

                }
                Console.WriteLine("Book Title: ");
                var titlebook = Console.ReadLine();
                List<Book> books = null;
                if (titlebook == string.Empty)
                {
                    books = library.GetBooks(authorName);
                }
                else
                {
                    books = library.GetBooks(authorName, titlebook);
                }
                foreach (var book in books)
                {
                    Console.WriteLine($"{books.IndexOf(book) + 1} Book Title: {book.Title}");
                }
            }
           

        }
    }
}
