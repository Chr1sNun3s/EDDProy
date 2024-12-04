using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_recursivos.Clases
{
    public class Exponente
    {
        public static int Operaciones { get; private set; }

        public static BigInteger Calcular(BigInteger baseNum, BigInteger exponente)
        {
            Operaciones++;
            if (exponente == 0) return 1;
            return baseNum * Calcular(baseNum, exponente - 1);
        }

        public static void ResetOperaciones()
        {
            Operaciones = 0;
        }
    }
}
