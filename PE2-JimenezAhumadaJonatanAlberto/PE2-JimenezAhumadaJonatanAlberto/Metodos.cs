using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_JimenezAhumadaJonatanAlberto
{
    class Metodos
    {
        int[] SucesionNumeros;
        int tamaño;
      

        public void InvertirSucesion(int[] sucesion,int inicio, int final)
        {
            if (inicio < final)
            {
                int variableAux = sucesion[inicio];
                sucesion[inicio] = sucesion[final];
                sucesion[final] = variableAux;
                InvertirSucesion(sucesion, inicio + 1, final - 1);
            }
        }

        public int CalcularMaximo(int [] sucesion, int indice, int maximo)
        {
            if (indice != sucesion.Length)
            {
                if (sucesion[indice] > maximo)
                {
                    maximo = CalcularMaximo(sucesion, indice + 1, sucesion[indice]);
                }
                else
                {
                    maximo = CalcularMaximo(sucesion, indice + 1, maximo);
                }
            }
            return maximo;
        }

       

        public int CalcularMinimo(int[] sucesion, int indice, int minimo)
        {
            if (indice != sucesion.Length)
            {
                if (sucesion[indice] < minimo)
                {
                    minimo = CalcularMinimo(sucesion, indice + 1, sucesion[indice]);
                }
                else
                {
                    minimo = CalcularMinimo(sucesion, indice + 1, minimo);
                }
            }
            return minimo;
        }



        public void Menu()
        {
            menu:
            string respuesta;
            Console.WriteLine("Ingrese un numero para elegir una opcion:\n1.-Calcular el Minimo de una sucesion de numeros\n" +
                "2.-Calcular el Maximo de una sucesion de numeros\n3.-Invertir una sucesion de numeros");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("¿Cuantos numeros desea ingresar? ");
                    tamaño = int.Parse(Console.ReadLine());
                    SucesionNumeros = new int[tamaño];
                    for (int i = 0; i < tamaño; i++)
                    {
                        Console.Write("Ingrese un numero: ");
                        SucesionNumeros[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Minimo: {0}", CalcularMinimo(SucesionNumeros, 0, SucesionNumeros[0]));
                    Console.WriteLine("Desea continuar: si/no");
                    respuesta = Console.ReadLine();
                    if (respuesta.ToUpper() == "SI")
                    {
                        Console.Clear();
                        goto menu;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                    break;
                case 2:
                    Console.WriteLine("¿Cuantos numeros desea ingresar? ");
                    tamaño = int.Parse(Console.ReadLine());
                    SucesionNumeros = new int[tamaño];
                    for (int i = 0; i < tamaño; i++)
                    {
                        Console.Write("Ingrese un numero: ");
                        SucesionNumeros[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Maximo: {0}", CalcularMaximo(SucesionNumeros, 0, SucesionNumeros[0]));
                    Console.WriteLine("Desea continuar: si/no");
                    respuesta = Console.ReadLine();
                    if (respuesta.ToUpper() == "SI")
                    {
                        Console.Clear();
                        goto menu;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                    break;
                case 3:
                    Console.WriteLine("¿Cuantos numeros desea ingresar? ");
                    tamaño = int.Parse(Console.ReadLine());
                    SucesionNumeros = new int[tamaño];
                    for (int i = 0; i < tamaño; i++)
                    {
                        Console.Write("Ingrese un numero: ");
                        SucesionNumeros[i] = int.Parse(Console.ReadLine());
                    }
                    InvertirSucesion(SucesionNumeros, 0, SucesionNumeros.Length - 1);
                    Console.WriteLine("La sucesion invertida es: ");
                    for (int i = 0; i < SucesionNumeros.Length; i++)
                    {
                        Console.WriteLine(SucesionNumeros[i]);
                    }
                    Console.WriteLine("Desea continuar: si/no");
                    respuesta = Console.ReadLine();
                    if (respuesta.ToUpper() == "SI")
                    {
                        Console.Clear();
                        goto menu;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                    break;
                default:
                    Console.WriteLine("Ha ingresado una opcion no valida: ");
                    break;
            }
        }

    }
}
