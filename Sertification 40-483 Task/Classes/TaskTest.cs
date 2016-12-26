using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sertification_40_483_Task.Classes
{
    class TaskTest
    {
        public static void Test()
        {
            Task<string> task = new Task<string>(() => "test");
            task.Start();
            var task2 = task.ContinueWith((r) => $"{r.Result} is continued by task2");
            var task3 = task2.ContinueWith((r) => $"{r.Result} is continued by task3") ;

            Console.WriteLine(task.Result);
            Console.WriteLine(task2.Result);
            Console.WriteLine(task3.Result);
        }
    }
}
