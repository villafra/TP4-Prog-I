using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4__Recursividad
{
    class Program
    {

        static int Restando (int num)
        {
            if (num == 0) return num;
            return num - Restando(num - 1);
            Console.WriteLine(num);
        }
        static void Main(string[] args)
        {
            int resultado= Restando(10);
            Console.ReadKey();
        }
    }
}
