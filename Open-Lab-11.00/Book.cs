using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{
    class Book
    {
        public static List<string> categoryList = new List<string>() { "detské", "romantické", "náučné", "sci-fi", "dobrodružné" };

        private string Title;
        private int Pages;
        private string Category;
        private string Author;
        private int ReleaseDate;


        public string author { get; set; }
        public string category
        {
         set => Category = value;
        }
        public int pages
        {
            get => this.Pages;
            set
            {
                if (value < 1)
                {
                    Pages = 1;
                }
                else
                {
                    Pages = value;
                }
            }
        }
        public int releaseDate
        {
            get => this.ReleaseDate;
            set
            {
                if (value < 1450 || value > 2020)
                {
                    ReleaseDate = -1;
                }
                else
                {
                    ReleaseDate = value;
                }
            }
        }

        public string title
        { get; set; }

        public Book()
        {
            title = "-1";
            pages = -1;
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }

        public Book(string title, int pages)
        {
            this.title = title;
            this.pages = pages;
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }

        public Book(string title, int pages, string category, string author, int releaseDate)
        {
            this.title = title;
            this.pages = pages;
            this.category = category;
            this.author = author;
            this.releaseDate = releaseDate;
        }

        public void All()
        {
            Console.WriteLine("title:" + title);
            Console.WriteLine("pages:" + pages);
            Console.WriteLine("category:" + Category);
            Console.WriteLine("author:" + author);
            Console.WriteLine("releaseDate:" + releaseDate);
            Console.WriteLine("");
        }


    }
}
