using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example_01
{
    internal interface IMyType
    {
        public int MyProperty {  get; set; }

        public void MyFunction();

        public void Print()
        {
            Console.WriteLine("Hello Default Implemented method");
        }
    }
}
