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
            //Console.WriteLine("数当てゲーム");
            //Console.WriteLine("0から10の数値を入力してください:");
            Random rnd = new Random();
            int max = 0;
            int min = 101;
//            int n = rnd.Next(11);
  //          int i = 1;
//            int n = int.Parse(Console.ReadLine());
            for (int i = 1;i <= 10; i++)
            {
                int n = rnd.Next(1,101);
                Console.Write("{0} " +
                    "" +
                    "", n);
                if (n > max)
                {
                    max = n;
                }
                if (n < min)
                {
                    min = n;
                }
            }
            Console.WriteLine("最大値:{0}",max);
            Console.WriteLine("最小値:{0}", min);
        }
    }
} 
