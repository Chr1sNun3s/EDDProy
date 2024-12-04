using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EDDemo.Algoritmos_recursivos.Clases
{
    public class Factorial
    {
        public static int Operaciones { get; private set; }
        public static BigInteger Calcular(BigInteger n)
        {
            Operaciones++;
            if (n == 0) return 1;
            return n * Calcular(n - 1);
        }

        public static void ResetOperaciones()
        {
            Operaciones = 0;
        }
    }
}
