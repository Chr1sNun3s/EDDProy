using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_de_ordenamiento.Clases
{
    public class RadixSort
    {
        public static void Sort(int[] array)
        {
            int n = array.Length;
            int max = GetMax(array, n);        
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountSort(array, n, exp);
            }
        }
        private static int GetMax(int[] array, int n)
        {
            int max = array[0];
            for (int i = 1; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        private static void CountSort(int[] array, int n, int exp)
        {
            int[] salida = new int[n]; 
            int[] conteo = new int[10]; 
            for (int i = 0; i < n; i++)
            {
                conteo[(array[i] / exp) % 10]++;
            }
            for (int i = 1; i < 10; i++)
            {
                conteo[i] += conteo[i - 1];
            }
            for (int i = n - 1; i >= 0; i--)
            {
                int Num = (array[i] / exp) % 10;
                salida[conteo[Num] - 1] = array[i];
                conteo[Num]--;
            }        
            for (int i = 0; i < n; i++)
            {
                array[i] = salida[i];
            }
        }
    }
}
