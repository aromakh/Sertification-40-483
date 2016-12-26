using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Sertification_40_483_Background_worker.Classes;
namespace Sertification_40_483_Background_worker
{
    class Program
    {
        static void Main(string[] args)
        {
            BackgroundWorkerTest.Test((sender, workerArgs) => Console.WriteLine($"progres report: {workerArgs.ProgressPercentage}"));

            //while (Console.ReadKey().Key != ConsoleKey.A) { }
            Console.ReadKey();

        }
    }
}
