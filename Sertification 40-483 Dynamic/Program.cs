using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace Sertification_40_483_Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic name = new ExpandoObject();

            name.Name = "123";
            name.Value = 123;

            Console.WriteLine(name.Value.ToString());
        }
    }
}
