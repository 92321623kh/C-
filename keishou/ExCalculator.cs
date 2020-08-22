using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keishou1
{
    class ExCalculator : keishou1_1
    {
        public void mul()
        {
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
        }
        public void div()
        {
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
        }
    }
}
