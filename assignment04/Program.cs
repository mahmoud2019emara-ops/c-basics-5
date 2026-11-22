using System.Drawing;

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
            book mybook = new book();
            Console.WriteLine(mybook.copiesInStock);
            // yes it will compile because te access modifier of th copiesInStock is[internal]
            #endregion
        }
    }
}
