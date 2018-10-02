using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_2JimenezAhumadaJonatanAlberto
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.ImprimirMetodoIterativo();
            fibonacci.ImprimirMetodoRecursivo();
            Console.ReadKey();
        }
    }
}
