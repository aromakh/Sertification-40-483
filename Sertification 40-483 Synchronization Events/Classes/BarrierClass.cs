using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sertification_40_483_Synchronization_Events.Classes
{
    public class BarrierClass
    {
        Barrier barrier = new Barrier(10, new Action<Barrier>(b => 
            Console.WriteLine("Barier event. Participients: {0}", 
                b.ParticipantCount)));

        public void Test()
        {
            Console.WriteLine("\n\t\t...Barrier Test...");

            for (int i = 0; i < 10; i++)
            {
                new Thread(new ThreadStart(() =>
                {
                    Console.WriteLine("Barier Thread {0} started", i);
                    barrier.SignalAndWait();
                    Console.WriteLine("Barier Thread {0} ended", i);
                })).Start();
            }
        }
    }
}
