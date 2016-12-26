using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sertification_40_483_Synchronization_Events.Classes
{
    class CancellationTokenClass
    {
        public void Test()
        {
            var canselationTokenSource = new CancellationTokenSource();
            var task = new TaskFactory(canselationTokenSource.Token).StartNew(() => { while (true) { Console.WriteLine("test"); Thread.Sleep(500); } });

            Thread.Sleep(2000);
            canselationTokenSource.Cancel();
        }
    }
}
