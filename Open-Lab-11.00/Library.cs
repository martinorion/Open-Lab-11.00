using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{
    class Library
    {
        private int numberOfBooks = 4;
        private int numberOfStudents = 2;

        public List<string> studentsList = new List<string>() {};
        public List<Book> booksList = new List<Book>() {};

        public int NumberOfBooks
        {
            get => numberOfBooks;

            set => numberOfBooks = value;
        }

        private int NumberOfStudents
        {
            get => numberOfStudents;

            set => numberOfStudents = value;
        }

        public void All()
        {
            Console.WriteLine("numberOfBooks:" + numberOfBooks);
            Console.WriteLine("numberOfStudents:" + numberOfStudents);
            Console.WriteLine(" ");
            foreach (var student in studentsList)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(" ");

            foreach (var book in booksList)
            {
                book.All();
            }

        }

    }
}
