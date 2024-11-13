using EDDemo.Estructuras_No_Lineales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    public class Colas
    {
        private NodoBinario primero;
        private NodoBinario ultimo;

        public Colas()
        {
            primero = null;
            ultimo = null;
        }

        public void Enqueue(NodoBinario dato)
        {
            NodoBinario nuevo = dato;  
            if (ultimo == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Der = nuevo;  
                ultimo = nuevo;
            }
        }

        public NodoBinario Dequeue()
        {
            if (primero == null)
            {
                Console.WriteLine("Cola vacia");
                return null;
            }
            NodoBinario dato = primero;  
            primero = primero.Izq;  

            if (primero == null)
            {
                ultimo = null;
            }

            return dato; 
        }
        public bool IsEmpty()
        {
            return primero == null;
        }
    }
}
