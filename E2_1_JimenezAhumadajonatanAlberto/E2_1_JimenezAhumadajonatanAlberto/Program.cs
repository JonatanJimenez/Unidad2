using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_1_JimenezAhumadajonatanAlberto
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();
            TimeSpan stop;
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
            int resultadoFor = factorial.FactorialFor();
            stop = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("Resultado del Factorial del numero 6 con For: {0} ", resultadoFor);
            Console.WriteLine("Tiempo de Ejecucion: {0} Milisegundos", stop.Subtract(start).TotalMilliseconds);

            TimeSpan parar;
            TimeSpan iniciar = new TimeSpan(DateTime.Now.Ticks);
            int resultadoRecursividad = factorial.FactorialRecursividad();
            parar = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("\nResultado del Factorial del numero 6 con Recursividad: {0}\n", resultadoRecursividad);
            Console.WriteLine("Tiempo de Ejecucion: {0} Milisegundos", parar.Subtract(iniciar).TotalMilliseconds);
        }
    }
}
