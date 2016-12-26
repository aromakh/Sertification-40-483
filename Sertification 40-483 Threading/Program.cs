using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Sertification_40_483_Threading.Classes;
namespace Sertification_40_483_Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoResetEventTest.Test();
            ManualResetEventTest.Test();
        }


    }
}
