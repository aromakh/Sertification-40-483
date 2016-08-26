using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Sertification_40_483_async_await
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task> start = async () =>
            {
                Console.WriteLine("Start async method");

                Func<Task> delay = async () => await Task.Delay(2000);
                await delay();

                Console.WriteLine("End async method");
            };

            start();

            int i = 0;
            while (++i < 100)
            {
                Thread.Sleep(500);
                Console.WriteLine("Other stuff");
            }
        }
    }
}
