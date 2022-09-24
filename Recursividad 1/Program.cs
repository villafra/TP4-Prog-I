using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int i;

            Console.WriteLine("Ingrese un numero: ");
            num = Int32.Parse(Console.ReadLine());

            Restando(num);
            Console.ReadKey();
        }

        private static int Restando(int numero)
        {
            Console.WriteLine(numero);
            if (numero <= 1) return 1; 
            else return Restando(numero - 1);
        }
    }
}
