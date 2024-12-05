using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_de_ordenamiento
{
    public class ShellSort
    {       
        public static void Sort(int[] array)
        {
            int n = array.Length;
            int interval = n / 2;

             while (interval >= 1)
             {
                 for (int i = 0; i + interval < n; i++)
                    {
                        int j = i;
                        while (j >= 0)
                        {
                            int k = j + interval;
                            if (array[j] > array[k])
                            {              
                                int temp = array[j];
                                array[j] = array[k];
                                array[k] = temp;

                                j -= interval;
                            }
                            else
                            {
                                break;
                            }
                        }
                 }
                    interval /= 2;
             }
        }
    }
}
