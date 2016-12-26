using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Sertification_40_483_Synchronization_Events.Classes;
namespace Sertification_40_483_Synchronization_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            //EventWaitHandleClass eventwaithandleclass = new EventWaitHandleClass();
            //eventwaithandleclass.Test();

            //CountDownEventClass countDownEventClass = new CountDownEventClass();
            //countDownEventClass.Test();

            //BarrierClass barrierClass = new BarrierClass();
            //barrierClass.Test();

            CancellationTokenClass cancelationTokenClass = new CancellationTokenClass();
            cancelationTokenClass.Test();

        }
    }
}
