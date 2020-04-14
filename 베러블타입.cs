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
            var a = 20;
            var b = 3.14141213;
            var c = "Hello World";
            var d = new int[] { 10, 20, 30 };


            Console.WriteLine("Type:{0}, Value:{1}", a.GetType(), a);
            Console.WriteLine("Type:{0}, Value:{1}", b.GetType(), b);
            Console.WriteLine("Type:{0}, Value:{1}", c.GetType(), c);
            Console.WriteLine("Type:{0}, Value:{1}", d.GetType(), d);
            foreach (var e in d)
                Console.WriteLine("{0}", e);

        }
    }
}
