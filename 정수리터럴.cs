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
            byte a = 240;//10진수 리터럴
            byte b = 0b1111_0000;//2진수 리터럴
            byte c = 0XF0;//16진수리터럴
            uint d = 0X1234_abcd;//16진수리터럴

            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");
            Console.WriteLine($"c={c}");
            Console.WriteLine($"d={d}");



        }
    
    
    }
}
