using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client2
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = Type.GetTypeFromProgID("KSR.Stos.2");
            object k = Activator.CreateInstance(t);
            t.InvokeMember("Push", System.Reflection.BindingFlags.InvokeMethod,
             null, k, new object[] { 100 });
            object[] stack_args = new object[] { null };
            t.InvokeMember("Pop", System.Reflection.BindingFlags.InvokeMethod,
             null, k, stack_args);
            t.InvokeMember("Pop", System.Reflection.BindingFlags.InvokeMethod,
             null, k, stack_args);
            Console.WriteLine("Pop = {0}", (int)stack_args[0]);
        }
    }
}
