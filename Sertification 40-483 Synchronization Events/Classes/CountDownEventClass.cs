using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sertification_40_483_Synchronization_Events.Classes
{
    public class CountDownEventClass
    {
        CountdownEvent countDonwnEvent = new CountdownEvent(10);

        public void Test()
        {
            Console.WriteLine("\n\t\t...CountdownEvent Test...");
            var theads = new List<Thread>();

            theads.Add(new Thread(new ThreadStart(() =>
            {
                var count = countDonwnEvent.CurrentCount;
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Thread {0} Start", i);
                    if (countDonwnEvent.CurrentCount > 0)
                        countDonwnEvent.Signal();
                    Thread.Sleep(500);
                    Console.WriteLine("Thread {0} End", i);
                }
                
            })));

            theads.Add(new Thread(new ThreadStart(() =>
            {
                Console.WriteLine("Waiting Thread Start");
                Console.WriteLine("Thread waiting for CountDownEvent...");
                countDonwnEvent.Wait();
                Console.WriteLine("Waiting Thread End");
            })));

            theads.ForEach(r => r.Start());
        }
    }
}
