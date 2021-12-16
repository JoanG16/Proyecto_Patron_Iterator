using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Patron_Iterator
{
    class CContenedor : IEnumerable
    {
        private string[] elementos = new string[5];
        public CContenedor()
        {
            elementos = new string[] { "Joan", "Juan", "Wilson", "Mateo", "Miriam" };

        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (new ContenedorEnum(elementos));

        }
    }
    class ContenedorEnum : IEnumerator
    {
        public string[] array;
        private int posicion = -1;
        public ContenedorEnum(string[] pArray)
        {
            array = pArray;
        }

        public object Current
        {
            get
            {
                return array[posicion];
            }
        }

        public bool MoveNext()
        {
            posicion++;
            if (posicion < array.Length)
                return true;
            else
                return false;
        }

        public void Reset()
        {
            posicion = -1;
        }
    }
}
