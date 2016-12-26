using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sertification_40_483_async_await.Classes
{
    class AsyncAwaitTest
    {
        public static async void Test()
        {
            Console.WriteLine("Test start.");

            // Wait on WriteToConsole finish.
            await WriteToConsole(1000);
            // Don`t wait on WriteToConsole finish.
            WriteToConsole(3000);

            Console.WriteLine("Test finish.");
        }

        static async Task WriteToConsole(int dellay)
        {
            Console.WriteLine("acync write start.");

            await Task.Delay(dellay);

            Console.WriteLine("acync write finish.");
        }
    }
}
