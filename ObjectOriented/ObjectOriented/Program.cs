using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // book is an object 
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);  // book object a physical book in the programme 
            /*book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;*/

            Book book2 = new Book("Lord of the Rings", "Tolkein" , 800);  // book object a physical book in the programme 
            /* book2.title = "Lord of the Rings";
            book2.author = "Tolkein";
            book2.pages = 800;*/

            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.8);

            Movie movie1 = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie movie2 = new Movie("Shrek", "Adam Adamson", "PG");

            Song song1 = new Song("Mehar Kari", "Darshan Raval", 2);
            Song song2 = new Song("Sawar loo", "Monali Thakur ", 5);

            //Console.WriteLine(Song.songCount);


            Chef chef = new Chef();
            chef.MakeChickn();
            chef.MakeSpecialDish();

            ItalianChef italianchef = new ItalianChef();
            italianchef.MakeChickn();
            italianchef.MakeSpecialDish();
            Console.ReadLine();
        }
    }
}
