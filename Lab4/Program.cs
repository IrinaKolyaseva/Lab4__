using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            for (int N = 1; N > 0; N++)
            {
                Console.WriteLine("Квадрат числа {0} равен {1}", N, Math.Pow(N ,2));
            }
            Console.ReadKey();


        }
    }
}
