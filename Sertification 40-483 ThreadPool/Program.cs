using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sertification_40_483_ThreadPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j = 0;
            ThreadPool.GetMinThreads(out i, out j);

            ThreadPool.QueueUserWorkItem((r) => Console.WriteLine("test"));
            WaitHandle wait = new AutoResetEvent(false);
            WaitHandle wai2t = new ManualResetEvent(false);
            

            ThreadPool.RegisterWaitForSingleObject(WaitHandle.WaitAll, null, null, 3000, false);
            //Thread.Sleep(5000);
        }
    }
}
