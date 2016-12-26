using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Sertification_40_483_Background_worker.Classes
{
    public class BackgroundWorkerTest
    {
        BackgroundWorker backgroundWorker = new BackgroundWorker();

        public static void Test(ProgressChangedEventHandler progressChangedAction)
        {
            BackgroundWorkerTest test = new BackgroundWorkerTest();
            test.backgroundWorker.WorkerReportsProgress = true;
            test.backgroundWorker.ProgressChanged += progressChangedAction;
            test.backgroundWorker.DoWork += test.DoWork;

            test.backgroundWorker.RunWorkerAsync();
        }

        void DoWork(object sender, DoWorkEventArgs args)
        {
            int i = 0;

            while(i++ < 5)
            {
                Console.WriteLine($"Do work: {i}");
                backgroundWorker.ReportProgress(i * 20);
            }
        }
    }
}
