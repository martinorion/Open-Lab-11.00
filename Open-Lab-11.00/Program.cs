using System;

namespace Open_Lab_11._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Library schooLibrary = new Library();
            schooLibrary.studentsList.Add("Poul");
            schooLibrary.booksList.Add(new Book("Macko Pu", 55, "rozprávka", "Alan Alexander Milne", 2017));
            schooLibrary.booksList.Add(new Book("C#", 256, "", "Pavel Bory", 2016 ));

            schooLibrary.studentsList.Add("John");
            schooLibrary.booksList.Add(new Book("Mein Kampf", 704, "autobiografia", "Adolf Hitler", 1992));
            schooLibrary.booksList.Add(new Book("C++", 272, "tutorial", "David Matoušek", 2016));

            schooLibrary.All();
            Console.ReadKey();
        }

    }
}
