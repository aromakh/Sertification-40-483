using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sertification_40_483_Threading.Classes
{
    public class AutoResetEventTest
    {
        AutoResetEvent autoResetEvent = new AutoResetEvent(false);

        public static void Test()
        {
            AutoResetEventTest test = new AutoResetEventTest();

            Thread thread = new Thread(() =>
            {
                int i = 0;
                while (++i < 5)
                {
                    test.autoResetEvent.WaitOne();
                    Console.WriteLine($"Auto reset event setted: {i}");
                }
            });

            thread.IsBackground = false;
            thread.Start();

            test.autoResetEvent.Set();
        }
    }
}
