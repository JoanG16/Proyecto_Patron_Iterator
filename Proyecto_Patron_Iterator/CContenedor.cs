using System;using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Patron_Iterator
{   
    //Esta clase se llamará CContenedora que va a implentar o heredar de IEnumerable, que ya la provee el mismo Framework 
    class CContenedor : IEnumerable
    {   
        //La estrcutura que se va a utilizar, en la cual se va a estar guardando la información, (en este caso un hacemos uso de un arreglo)
        //El arreglo será de tipo string
        private string[] elementos = new string[5];
        
        //En el constructor llenamos el arreglo o la estrcutura de datos de elementos 
        public CContenedor()
        {  
            //Elementos contendra 5 nombres 
            elementos = new string[] { "Joan", "Juan", "Wilson", "Mateo", "Miriam" };

        }
       
        //Al utilizar IEnumerable necesariamente hay que utilizar el GetEnumerator
        //Regresa un objeto que implenta IEnumerator
        IEnumerator IEnumerable.GetEnumerator()
        {
            //Retorna en una instancia del ContenedorEnum(enumerador), lo que se envia es el arreglo.
            return (new ContenedorEnum(elementos));

        }
    }

    //Se encarga de recorrer la estrcutura de datos para la recoleccion de elementos
    //Esta clase implementa a IEnumerator 
    class ContenedorEnum : IEnumerator
    {    
        //Se inicializa un arreglo
        public string[] array;
        
        //Varaibe de apoyo de posicion, inicialliza en -1
        private int posicion = -1;

        //En el constructor damos valores al array, se recibe elementos y todos sus datos se coloca o almacena en array
        public ContenedorEnum(string[] pArray)
        {
            array = pArray;
        }

       
        //Es necesario implmentarlo porque estamos haciendo uso de la interfaz IEnumerator
        //MoveNexxt va a regresar un booleano (true o false)  true si todavia hay un elemento mas que podamos procesar y falsa si ya llegamos al final de la coleccion o de la estrcutura de datos
       
        public bool MoveNext()
        {
            //Como tenemos un arreglo debemos de ir incrementado una posicion para verificar el arreglo
            posicion++;
            if (posicion < array.Length)
                return true;
            else
                return false;
        }

        //Reset lo que hace es que nos regresa al incio de la coleccion
        public void Reset()
        { 
            //posicion inicial es el -1
            posicion = -1;
        }

        //Current nos a regresar el elemento que se encuentre en tal posicion
        public object Current
        {
            get
            {
                return array[posicion];
            }
        }
    }
}
