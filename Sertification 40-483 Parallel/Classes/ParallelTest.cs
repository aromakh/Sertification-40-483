using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sertification_40_483_Parallel.Classes
{
    class ParallelTest
    {
        public static void Test()
        {
            Parallel.For(0, 10, (i) => { Thread.Sleep(new Random(100).Next(1000)); Console.WriteLine(i); });
        }
    }
}
