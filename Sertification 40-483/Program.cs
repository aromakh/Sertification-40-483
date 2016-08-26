using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sertification_40_483.Classes;
namespace Sertification_40_483
{
    class Program
    {
        static void Main(string[] args)
        {
            Person test = new Person();
            foreach (var a in test)
            {
                Console.WriteLine(a);
            }
        }
    }
}
