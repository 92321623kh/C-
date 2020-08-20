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
            Console.Write("正の数を入力:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("{0}",i);
                }
            }
            Console.WriteLine(); 

        }
    }
} 
