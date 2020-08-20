using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample102
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("九九の表示");
            //            int n = int.Parse(Console.ReadLine());
            for (int m = 1; m <= 9; m++)
            {
                for (int n = 1; n <= 9; n++)
                {
                    Console.Write("{0}X{1}={2,2:d}", m, n, m * n);
                }
                Console.WriteLine();
            }       
        }
    }
} 
