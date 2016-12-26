using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Sertification_40_483_Synchronization_Events.Classes
{
    public class EventWaitHandleClass
    {
        EventWaitHandle eventWaitHandle = new EventWaitHandle(false, EventResetMode.AutoReset);

        public void Test()
        {
            Console.WriteLine("\n\t\t...EventWaitHandle test...");

            new Thread(new ThreadStart(() => {
                Console.WriteLine("thread1 start...");
                Console.WriteLine("thread1 waiting on event...");
                eventWaitHandle.WaitOne();
                Console.WriteLine("thread1 end...");
            })).Start();

            Thread.Sleep(1500);

            new Thread(new ThreadStart(() => {
                Console.WriteLine("thread2 start...");
                eventWaitHandle.Set();
                Console.WriteLine("thread2 rising event...");
                Console.WriteLine("thread2 end...");
            })).Start();
        }
    }
}
