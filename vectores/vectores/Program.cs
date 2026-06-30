using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vectores
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int opcion;
            Console.Clear();
            Console.WriteLine("***** MENU *****");
            Console.WriteLine("1. Generador de Tablas");
            Console.WriteLine("2. promedio de calificaciones");
            Console.WriteLine("3. busqueda de un valor");
            Console.WriteLine("4. determinacion de extremos");
            Console.WriteLine("5. Calculo de factorial");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opcion: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    int suma = 0;
                    Console.WriteLine("tamaño de vector");
                    int n = int.Parse(Console.ReadLine());
                    int[] vec = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("valor de vector" + (i + 1));
                        vec[i] = int.Parse(Console.ReadLine());
                        suma = suma + vec[i];
                    }
                    Console.WriteLine("la suma total es" + suma);
                
                case 2:
                    int suma = 0;
                    Console.WriteLine("tamaño de vector");
                    int n = int.Parse(Console.ReadLine());
                    int[] vec = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("valor de vector" + (i + 1));
                        vec[i] = int.Parse(Console.ReadLine());
                        suma = suma + vec[i];
                    }
                    Console.WriteLine("la suma total es" + suma);
                case 3:
                    int suma = 0;
                    Console.WriteLine("tamaño de vector");
                    int n = int.Parse(Console.ReadLine());
                    int[] vec = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("valor de vector" + (i + 1));
                        vec[i] = int.Parse(Console.ReadLine());
                        suma = suma + vec[i];
                    }
                    Console.WriteLine("la suma total es" + suma);
                case 4:
                    int suma = 0;
                    Console.WriteLine("tamaño de vector");
                    int n = int.Parse(Console.ReadLine());
                    int[] vec = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("valor de vector" + (i + 1));
                        vec[i] = int.Parse(Console.ReadLine());
                        suma = suma + vec[i];
                    }
                    Console.WriteLine("la suma total es" + suma);







            }
    }
}
