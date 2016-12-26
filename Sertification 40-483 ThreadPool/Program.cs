using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Sertification_40_483_ThreadPool.Classes;
namespace Sertification_40_483_ThreadPool
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueUserWorkItemTest.Test();
            RegisterWaitForSingleObjectTest.Test();

            while (Console.ReadKey().Key != ConsoleKey.A) { }
        }
    }
}
