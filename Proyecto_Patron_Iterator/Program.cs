using System;

namespace Proyecto_Patron_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            //tenemos la instancia de la clase CContenedor
            CContenedor date = new CContenedor();

         //hacemos uso del foreach
         //que va a pedir a CContenedor el enumerador, luego de eso va a ir invocando el reset para colocarlo al icnio del contenedor,
         //el movenext para ver si hay o no elementos, en el momento que ya no hay as elementos en esa coleccion entonces el foreach finaliza 
            foreach (string variable in date)
            {
                Console.WriteLine(variable);
            }
        }
    }
}

