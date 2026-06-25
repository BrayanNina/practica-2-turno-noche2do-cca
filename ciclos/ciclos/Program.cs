using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.Clear();
            Console.WriteLine("***** MENU *****");
            Console.WriteLine("1. Generador de Tablas");
            Console.WriteLine("2. Acumulador de Ventas");
            Console.WriteLine("3. Validacion de PIN");
            Console.WriteLine("4. Contador de Pares e Impares");
            Console.WriteLine("5. Calculo de factorial");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    int n;
                    Console.Write("Ingrese un numero: ");
                    n = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= 12; i++)
                    {
                        Console.WriteLine(n + " x " + i + " = " + (n * i));
                    }
                    break;

                case 2:
                    double v, s = 0;

                    do
                    {
                        Console.Write("Ingrese venta 0 para terminar: ");
                        v = double.Parse(Console.ReadLine());
                        s += v;
                    } while (v != 0);

                    Console.WriteLine("Total de ventas: " + s);
                    break;

                case 3:
                    int pin;

                    do
                    {
                        Console.Write("Ingrese el PIN: ");
                        pin = int.Parse(Console.ReadLine());

                        if (pin != 4560)
                        {
                            Console.WriteLine("PIN incorrecto");
                        }

                    } while (pin != 4560);

                    Console.WriteLine("Acceso permitido");
                    break;

                case 4:
                    int n, pares = 0, impares = 0;

                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write("Ingrese numero " + i + ": ");
                        n = int.Parse(Console.ReadLine());

                        if (n % 2 == 0)
                            pares++;
                        else
                            impares++;
                    }

                    Console.WriteLine("Pares: " + pares);
                    Console.WriteLine("Impares: " + impares);
                    break;

                case 5:
                    int num;
                    long factorial = 1;

                    Console.Write("Ingrese un numero: ");
                    num = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= num; i++)
                    {
                        factorial *= i;
                    }

                    Console.WriteLine("Factorial = " + factorial);
                    break;

                case 6:
                    Console.WriteLine("Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Opcion no valida.");
                    break;
            }

           
         while (opcion != 0);
        }
    }
}
