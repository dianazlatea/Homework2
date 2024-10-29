using System;
namespace LibrarySystem
{
    public class Book{
        public string title;
        public string author;
        public int pages;
        public bool isCheckOut;
        public Book(string title,string author){
            this.title=title;
            this.author=author;
            this.pages=100;
            this.isCheckOut=false;
        }
        public Book(string title,string author,int pages){
            this.title=title;
            this.author=author;
            this.pages=pages;
            this.isCheckOut=false;
        }
    
    public void CheckOut()
    {
isCheckOut=true;
    }
    public void ReturnBook()
    {
isCheckOut=false;
    }
        public override string ToString()
        {
            return $"Title:{title}, Author:{author}, Pages:{pages}, CheckOut:{(isCheckOut ? "YeS":"No")}";
        }
    }
}