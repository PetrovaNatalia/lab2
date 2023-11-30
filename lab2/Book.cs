using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace lab2
{
    internal class Book
    {
        public string name_of_book;
        public string autor;
        public int ISBN;
        public string annotation;
        public string summary;
        public string Text;
        public int count = 0;
        public bool flag = true;

        public Book(string name_of_book, string autor, int ISBN, string annotation, string summary, string Text)
        {
            this.name_of_book =name_of_book;
            this.autor =autor;
            this.ISBN = ISBN;
            this.annotation = annotation;
            this.summary = summary;
            this.Text = Text;
        }
    }
}
