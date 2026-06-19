using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Ingrese el primer número: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("El mayor es: " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("El mayor es: " + b);
            }
            else
            {
                Console.WriteLine("El mayor es: " + c);
            }
        }
    }
}
