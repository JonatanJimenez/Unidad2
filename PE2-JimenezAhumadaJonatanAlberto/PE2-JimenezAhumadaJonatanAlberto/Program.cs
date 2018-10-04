using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_JimenezAhumadaJonatanAlberto
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos metodos = new Metodos();
            bool bandera = true;
            do
            {
                try
                {
                    metodos.Menu();
                    bandera = false;
                }
                
                catch (FormatException formato)
                {
                    Console.WriteLine(formato.Message);
                }

            } while (bandera == true);
           
        }
    }
}
