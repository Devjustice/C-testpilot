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
            uint a = uint.MaxValue;
            uint b = uint.MinValue;
            Console.WriteLine(a);
            a = a + 1;//overflow
            Console.WriteLine(a);
            b = b - 1;//underflow   
            Console.WriteLine(a);
        }


    }
}
