using System;
namespace LibrarySystem{
    class Program{
        public static void Main(string[]args){
            Book book1=new Book("1984","George Orwell");
            Book book2=new Book("The Hobbit","J.R.R. Tolkien",310);
            book1.CheckOut();
            book2.ReturnBook();
            Console.WriteLine(book1.ToString());
            Console.WriteLine(book2.ToString());
        }
    }
}