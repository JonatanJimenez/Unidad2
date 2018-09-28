using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_1_JimenezAhumadajonatanAlberto
{
    class Factorial
    {
        public int FactorialFor()
        {
            int resultado = 1;
            for (int contador = 1; contador < 7; contador++)
            {
                resultado = resultado * contador;
            }

            return resultado;
        }

        public int FactorialRecursividad(int numero = 6)
        {
            if (numero == 0)
            {
                return 1;
            }
            else
            {
                return numero * FactorialRecursividad(numero - 1);
            }
        }
    }
}
