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

            int? a = null;
            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);
            a = 3;
            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);
            Console.WriteLine(a.Value);//db에서 NULL은 빈공간을 의미한다.

        }
    }
}
