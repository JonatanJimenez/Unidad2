using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2_2JimenezAhumadaJonatanAlberto
{
    class Fibonacci
    {
        int numero,resultado,numeroX = 1, numeroY = 0;
     
        public void MetodoIterativo()
        {
            Console.Write("Cuantos numeros de Fibonacci desea: ");
            numero = int.Parse(Console.ReadLine());          
            for (int i = 0; i < numero; i++)
            {
               if (i == 0 || i == 1)
               {
                    Console.WriteLine(i);
               }
               else 
               {
                    resultado = numeroX + numeroY;
                    Console.WriteLine(resultado);
                    numeroY = numeroX;
                    numeroX = resultado;                                              
               }
            }
        }

        public int MetodoRecursivo(int numero)
        {
            
            if (numero == 0 || numero == 1)
            {
                return numero;
            }
            else
            {
                return MetodoRecursivo(numero -1) + MetodoRecursivo(numero - 2);
            }
              
        }

        public void ImprimirMetodoRecursivo()
        {
            Console.WriteLine("FIBONACCI METODO RECURSIVO");
            Stopwatch tiempo = new Stopwatch(); tiempo.Start();
            Console.Write("Cuantos numeros de Fibonacci desea: ");
            numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine(MetodoRecursivo(i));
            }
            tiempo.Stop();
            Console.Write("Tiempo: {0}", tiempo.Elapsed.ToString());
        }

        public void ImprimirMetodoIterativo()
        {
            Console.WriteLine("FIBONACCI METODO Iterativo");
            Stopwatch tiempo = new Stopwatch(); tiempo.Start();
            MetodoIterativo();
            tiempo.Stop();
            Console.Write("Tiempo: {0}\n", tiempo.Elapsed.ToString());
        }
    }
}
