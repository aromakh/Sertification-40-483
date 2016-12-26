using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sertification_40_483_ThreadPool.Classes
{
    class QueueUserWorkItemTest
    {
        public static void Test()
        {
            ThreadPool.QueueUserWorkItem((r) => Console.WriteLine("test"));
        }
    }
}
