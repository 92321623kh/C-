using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample502
{
    class Super
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Sub c = new Sub();
            p.Foo();
            c.Foo();

        }
    }
}
