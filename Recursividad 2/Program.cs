using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact;
            Console.WriteLine("Ingrese el número a calcular:");
            fact = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(fact));
            Console.ReadLine();
        }

        private static ulong Factorial(int numero)
        {
            if (numero <= 1) return 1;
            else return (ulong)numero * Factorial(numero - 1);
        }
    }
}
