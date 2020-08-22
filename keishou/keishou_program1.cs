using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keishou1
{
    class keishou_program1
    {
        static void Main(string[] args)
        {
            ExCalculator c1 = new ExCalculator();
            c1.Num1 = 10;
            c1.Num2 = 3;

            c1.add();
            c1.sub();
            ExCalculator c2 = new ExCalculator();
            c2.Num1 = 10;
            c2.Num2 = 3;
            c2.add();
            c2.sub();

            c2.mul();
            c2.div();
        }
    }
}
