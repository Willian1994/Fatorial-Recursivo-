using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialRecursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Calcular ftorial de qual número? ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("O fatorial de " +num + " é " +  Fatorial(num));

            Console.ReadKey();
        }

        static int Fatorial(int num)
        {
            if (num <=0)
            {
                return 1;

            }
            return num * Fatorial(num - 1);
            // 5 * Fatorial(4);
            // 5 * Fatorial(3);
            // 5 * Fatorial(2);
            // 5 * Fatorial(1);
            // 5 * Fatorial(0);
            // return 1;
        }

    }
}
