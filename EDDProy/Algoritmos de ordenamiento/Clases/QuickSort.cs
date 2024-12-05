using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_de_ordenamiento.Clases
{
    public class QuickSort
    {
        public static void Sort(int[] array, int izq, int der)
        {
            if (izq < der)
            {
                int particionIndex = Particion(array, izq, der);
                Sort(array, izq, particionIndex - 1);
                Sort(array, particionIndex + 1, der);
            }
        }

        private static int Particion(int[] array, int left, int right)
        {
            int pivote = array[right]; 
            int lowIndex = left - 1;

            for (int i = left; i < right; i++)
            {
                if (array[i] < pivote)
                {
                    lowIndex++;
                    Swap(ref array[lowIndex], ref array[i]);
                }
            }        
            Swap(ref array[lowIndex + 1], ref array[right]);

            return lowIndex + 1;
        }
        private static void Swap(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }
    }

}

