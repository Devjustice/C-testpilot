using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testpilot
{
    class Program
    {
        static void Main(string[] args)
        {

            sbyte a = 127;
            Console.WriteLine(a);

            int b = (int)a;
            Console.WriteLine(b);

            int x = 128;//sbyte maxvalue+1=오버플로우된값

            Console.WriteLine(x);
            sbyte y = (sbyte)x;
            Console.WriteLine(y);
        }




    }
}
