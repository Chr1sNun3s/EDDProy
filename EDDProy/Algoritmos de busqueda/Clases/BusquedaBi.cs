using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_de_busqueda.Clases
{
    public class BusquedaBi
    {
        public static int Buscar(int[] arreglo, int valor)
        {
            int inicio = 0;
            int fin = arreglo.Length - 1;            
            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;
                if (arreglo[medio] == valor)
                {
                    return medio; 
                }
                if (arreglo[medio] < valor)
                {
                    inicio = medio + 1; 
                }
                else
                {
                    fin = medio - 1; 
                }
            }
            return -1; 
        }
    } 
}
