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
            book mybook = new book();
            mybook.password;
            // it is wrang because th access modifie of the password is [private]
            #endregion
    }
    }
}
