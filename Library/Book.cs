using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        public readonly Writer writer;
        private List<string> books;
       
        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public Book(Writer author, string title)
        {
            this.writer = author;
            this.title = title;
        }
        public string GetFirstName()
        {
            return writer.GetFirstName();
        }

    }
}
