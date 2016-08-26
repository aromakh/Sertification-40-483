using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sertification_40_483_delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Action test = () => Console.WriteLine("Hello");

            Func<int, int> test2 = (r) => { return r; };

            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            Func<int, int> test3 = (r) => r;

            var i = test2(3);

            Console.WriteLine(i);

            test();
        }
    }
}
