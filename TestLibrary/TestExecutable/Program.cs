using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//by default namespace takes the name of the application, untill and unless you change the namespace name
using TestLibrary;

namespace TestExecutable
{
    class Program
    {
        static void Main(string[] args)
        {
            Test testObjRef = new Test();
            string output = testObjRef.SayHello("Joydip");
            Console.WriteLine(output);
        }
    }
}
