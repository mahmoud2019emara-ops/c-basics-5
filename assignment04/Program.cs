using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            //Add a private string password = "secret"; field to a Book class. Try to print it from Main(outside the class).
            //What happens, and why?
            //book mybook = new book();
            //mybook.password;
            //// it is wrang because th access modifie of the password is [private]
            #endregion

            #region question 2
            //Add an internal int copiesInStock = 5; field to Book.Print it from Main.Does it compile? Why?
            //book mybook = new book();
            //Console.WriteLine(mybook.copiesInStock);
            // yes it will compile because te access modifier of th copiesInStock is[internal]
            #endregion

            #region question 3
            //Add a public string Title; field to Book.Set it and print it from Main.
            //book mybook = new book();
            //Console.WriteLine(mybook.Title);
            #endregion

            #region question 4
            //Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book, assign it Genre.Science, and print it.
            //genre g = genre.Science;
            //Console.WriteLine(g);
            #endregion

            #region question 5
            //Using the Genre enum above, print the underlying int value of Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int. 
            //genre g1=(genre)0;
            //Console.WriteLine(g1);
            //genre g2 = (genre)1;
            //Console.WriteLine(g2);
            //genre g3 = (genre)2;
            //Console.WriteLine(g3);
            #endregion

            #region question 6
            //Given int genreNumber = 1;, cast it into a Genre value and print the result.
            //int genreNumber = 1;
            //genre g = (genre)genreNumber;
            //Console.WriteLine(g);

            #endregion

            #region question 7
            //Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.
            genre genre = genre.Fiction;
            string g = genre.ToString();
            Console.WriteLine(g);
            #endregion
        }
    }
}
