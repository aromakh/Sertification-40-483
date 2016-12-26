using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sertification_40_483_Threading.Classes
{
    public class ManualResetEventTest
    {
        ManualResetEvent manualResetEvent = new ManualResetEvent(false);

        public static void Test()
        {
            ManualResetEventTest test = new ManualResetEventTest();

            Thread thread = new Thread(() =>
            {
                int i = 0;
                while (++i < 5)
                {
                    test.manualResetEvent.WaitOne();
                    Console.WriteLine($"Manual reset event setted: {i}");
                }
            });

            thread.IsBackground = false;
            thread.Start();

            test.manualResetEvent.Set();

        }
    }
}
