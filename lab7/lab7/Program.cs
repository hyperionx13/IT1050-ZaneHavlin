using System;

namespace lab7
{
    class program
    {
        static void Main(string[] args)
        {
            Book bookObject = new Book();
            bookObject.Title = "The Shining";
            bookObject.Author = "Steven King";
            bookObject.Year = "1977";

            Console.WriteLine("and the best book of all time is");

            Console.WriteLine("{0},{1},{2}",
                bookObject.Title, bookObject.Author, bookObject.Year);
            Console.ReadLine();
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }
    }
}

    /*class Book
    {
        public static void Main(string[] args)
        {
            Book book = new Booktest
            {
                BookTitle = "The Shining",
                BookAuthor = "Steven King",
                BookYear = "1977",
            };
        }
    }*/

//3.
//When creating a type "Book"before adding a constructor method
//we are creating what is know as common language run time. 

//4.
//If you are creating two new new constructor methods then you are using
//what is called overloading

//5.
//It is important to use exception handling so that your program is able to
//handle and resolve exception, problems that occur while the program runs.

//6. 
// Public classes are used to allow acess by and mothod and does not hide any information
//the client. where as private classes are only used when called and needed. 
//

//7.
//when useing composition if the parent object is deleted then the child will too.
// this is known as a "part-of" relation ship and the child does not exist without the parent

//8.
//Data abstracition is when you use access modifiers to hide the details of a object, 
//allowing you to only show the necessary methods and properies. 