using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Library
    {
        public List<Book> newbook;
        public List<Book> NewBook
        {
            get
            {
                return newbook;
            }
            set
            {
                newbook = value;
            }
        }

        public Library()
        {
            newbook = new List<Book>();

        }
        public void AddBooks(Book books)
        {
            newbook.Add(books);
        }
        public List<Book> GetBooks(string authorName)
        {
            var result = new List<Book>();
            foreach (Book book in newbook)
            {
                if (book.GetFirstName() == authorName)
                {
                    result.Add(book);
                }
            }
            return result;

        }
        public List<Book> GetBooks(string authorName,string bookTitle)
        {
            var result = new List<Book>();
            foreach (Book book in newbook)
            {
                if (book.GetFirstName() == authorName && book.Title.StartsWith(bookTitle)) 
                {
                    result.Add(book);
                }
            }
            return result;

        }
    }
}
