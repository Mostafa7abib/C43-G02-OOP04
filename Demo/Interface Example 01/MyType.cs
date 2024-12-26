using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example_01
{
    internal class MyType : IMyType

    {
        public int MyProperty { get; set; }

        public void MyFunction()
        {
            Console.WriteLine("Hello World!!"); 
        }
    }
}
