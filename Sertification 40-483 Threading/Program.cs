using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sertification_40_483_Threading
{
    class Program
    {
        static ManualResetEvent manualResetEvent = new ManualResetEvent(false);;

        static void Main(string[] args)
        {
            Thread myThead = new Thread(() => Console.WriteLine(123));
            myThead.IsBackground = false;

            myThead.Start();

            Console.ReadKey();
            Console.ReadKey();
            manualResetEvent.Set();
            Console.ReadKey();
        }

        static void TestManualRestartEvent()
        {

            manualResetEvent.Set();
            Thread thread = new Thread(() => Console.WriteLine("test"));
            manualResetEvent.WaitOne();
        }

    }
}
