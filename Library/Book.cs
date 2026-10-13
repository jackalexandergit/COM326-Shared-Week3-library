using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    public class Book
    {

        // private fields

        private string title;
        private string author;
        private string isbn;

        public string Title
        {
            get { return title; }
            set
            {
                // Ensure title does not contain any numbers
                if (!value.Any(char.IsDigit) && value != "")
                {
                    title = value;
                }
                else
                {
                    Console.WriteLine("Error: Member name cannot be blank or contain numbers.");
                }
            }
        }

        public string Author
        {
            get { return author; }
            set {
                // Ensure author does not contain any numbers
                if (!value.Any(char.IsDigit) && value != "")
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot be blank or contain numbers.");
                }
            }
        }

        public string ISBN
        {
            get { return isbn; }
            set
            {
                // Ensure isbn does not contain any numbers
                if (!value.Any(char.IsDigit) && value != "")
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("Error: ISBN cannot be blank or contain numbers.");
                }
            }
        }

        // constructor

        public Book(string bookTitle, string bookAuthor, string bookIsbn)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookIsbn;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
} 
    
