using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            char op;

            Console.Write("Ingrese el primer número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la operación (+, -, *, /): ");
            op = char.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine("Resultado: " + (num1 + num2));
                    break;

                case '-':
                    Console.WriteLine("Resultado: " + (num1 - num2));
                    break;

                case '*':
                    Console.WriteLine("Resultado: " + (num1 * num2));
                    break;

                case '/':
                    if (num2 != 0)
                        Console.WriteLine("Resultado: " + (num1 / num2));
                    else
                        Console.WriteLine("No se puede dividir entre cero.");
                    break;

                default:
                    Console.WriteLine("Operación no válida.");
                    break;

            }
        }
}
