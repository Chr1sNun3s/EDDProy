﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_de_ordenamiento.Clases
{
    public class Burbuja
    {
        public static void Ordenar(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                bool huboIntercambio = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        huboIntercambio = true;
                    }
                }
                if (!huboIntercambio)
                {
                    break;
                }
            }
        }
    }
}
