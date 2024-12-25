using Demo.Interface_Example_01;

namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            IMyType myType;

            MyType myType1 = new MyType();
            myType1.MyProperty = 10;
            myType1.MyFunction();

            IMyType refFromInterface = new MyType();
            refFromInterface.MyProperty = 20;
            refFromInterface.MyFunction();
            refFromInterface.Print();
        }
    }
}
