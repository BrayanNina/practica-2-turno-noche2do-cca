using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota;

            Console.Write("Ingrese una nota (1-100): ");
            nota = int.Parse(Console.ReadLine());

            if (nota >= 90)
                Console.WriteLine("Calificación: A");
            else if (nota >= 80)
                Console.WriteLine("Calificación: B");
            else if (nota >= 70)
                Console.WriteLine("Calificación: C");
            else if (nota >= 60)
                Console.WriteLine("Calificación: D");
            else
                Console.WriteLine("Calificación: F");
        }
    }
}
