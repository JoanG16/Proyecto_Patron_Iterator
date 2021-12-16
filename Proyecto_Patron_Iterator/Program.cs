using System;

namespace Proyecto_Patron_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {

            CContenedor date = new CContenedor();
            foreach (string variable in date)
            {
                Console.WriteLine(variable);
            }
        }
    }
}
