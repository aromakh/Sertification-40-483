using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sertification_40_483_events
{
    class Program
    {
        static EventHandler<PersonEventArgs> personEventHandler;     
        static void Main(string[] args)
        {
            personEventHandler += (r, per) => Console.WriteLine("123");
            personEventHandler += (r, per) => Console.WriteLine("123");

            personEventHandler -= (EventHandler<PersonEventArgs>)personEventHandler.GetInvocationList()[0];

            personEventHandler?.Invoke(new object(), new PersonEventArgs("Anna"));
        }
    }

    class PersonEventArgs: EventArgs
    {
        public string Name { get; set; }
        public PersonEventArgs (string name)
        {
            Name = name;
        }
    }
}
