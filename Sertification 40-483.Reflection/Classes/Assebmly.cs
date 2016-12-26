using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Sertification_40_483.Reflection.Classes
{
    public class Assebmly
    {
        public static void Test()
        {
            var assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine($"assembly name: {assembly.FullName}" +
                $"\n directory :{assembly.Location}");

            assembly.GetModules().ToList().ForEach(r => 
                Console.WriteLine($"module name: {r.Name}, " +
                    $"module info: {r.MetadataToken}"));

            assembly.GetTypes().ToList().ForEach(r =>
            { 
                Console.WriteLine($"type name: {r.Name}, members:");
                r.GetMembers().ToList().ForEach(m => Console.WriteLine($" {m.Name} "));
            });
        }
    }
}
