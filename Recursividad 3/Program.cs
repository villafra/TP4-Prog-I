using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1000,22,456,345,555,123,876,3,8888,6,9};
            for (int n = 0; n <= ints.Length-1; n++)
            {
                Console.WriteLine(ints[n]);
            }
            Ordenar(ints, ints.Length);
            for (int n = 0; n <= ints.Length-1; n++)
            {
                Console.WriteLine(ints[n]);
            }
            Console.ReadKey();
        } 

        private static void Ordenar (int[] desordenado,int cantidad)
        {
            if (cantidad > 1)
            {
                for (int i = 0; i < cantidad - 1; i++)
                {
                    if (desordenado[i]> desordenado[i + 1])
                    {
                    int aux = desordenado[i];
                    desordenado[i] = desordenado[i + 1];
                    desordenado[i + 1] = aux;
                    }
                }
                Ordenar(desordenado, cantidad - 1);
            }
        }
    }
}
