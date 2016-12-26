using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sertification_40_483_Exception.Classes
{
    class Exception
    {
        public static void Test()
        {
            try
            {
                try
                {
                    throw new ArgumentOutOfRangeException();
                }

                catch (ArgumentOutOfRangeException ae)
                {
                    Console.WriteLine("AggregateException");
                    Console.WriteLine(ae.StackTrace);

                    throw ae;
                }
            }

            catch (System.Exception ex)
            {
                Console.WriteLine("Exeption");
                Console.WriteLine(ex.StackTrace);
            }

            finally
            {
                Console.WriteLine("finnaly");
            }
        }
    }
}
