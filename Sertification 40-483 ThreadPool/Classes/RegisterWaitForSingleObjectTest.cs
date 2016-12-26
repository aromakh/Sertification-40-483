using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sertification_40_483_ThreadPool.Classes
{
    class RegisterWaitForSingleObjectTest
    {
        public static void Test()
        {
            AutoResetEvent wait = new AutoResetEvent(false);
            WaitOrTimerCallback callback = new WaitOrTimerCallback((obj, TimeSpan) => 
                Console.WriteLine($"RegisterWaitForSingleObjectTest: {obj}"));

            ThreadPool.RegisterWaitForSingleObject(wait, callback,  "test", -1, false);
            wait.Set();
        }
}
}
