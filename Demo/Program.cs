using Demo.Inteface_Example_03;
using Demo.Interface_Example_01;
using Demo.Interface_Example_02;

namespace Demo
{
    internal class Program
    {
        static void PrintTenNumbersFromSeries(ISeries series)
        {
            if (series is null)
                return;
            for (int i = 0; i<= 10; i++)
            {
                Console.Write($"{series.Current} \t");
                series.GetNext();
            }
            series.Reset();
            Console.WriteLine();
        }
        static void Main()
        {
            #region Video 2
            //IMyType myType;

            //MyType myType1 = new MyType();
            //myType1.MyProperty = 10;
            //myType1.MyFunction();

            //IMyType refFromInterface = new MyType();
            //refFromInterface.MyProperty = 20;
            //refFromInterface.MyFunction();
            //refFromInterface.Print();
            #endregion

            #region Video 3
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //PrintTenNumbersFromSeries(seriesByTwo);
            //SeriesByThree seriesByThree = new SeriesByThree();  
            //PrintTenNumbersFromSeries(seriesByThree);
            //SeriesByFour seriesByFour = new SeriesByFour();
            //PrintTenNumbersFromSeries(seriesByFour); 
            #endregion

            #region Video 4
            //IMovable movable = new Airplane();
            //movable.Forward();

            //IFlyable flyable = new Airplane();
            //flyable.Forward();
            #endregion

            int[] Arr01 = [1,2,3];
            int[] Arr02 = [4,5,6];
            Console.WriteLine($"Arr01.GetHashCode() : {Arr01.GetHashCode()}"); 
            Console.WriteLine($"Arr02.GetHashCode() : {Arr02.GetHashCode()}");

            Arr02 = Arr01; // this object [1,2,3] has 2 references [Arr01,Arr02] , [4,5,6] became unreachable object.
            //Console.WriteLine("After Shallow Copy");
            Console.WriteLine("After Deep Copy");
            Arr02 = (int[])Arr01.Clone();
            Console.WriteLine($"Arr01.GetHashCode() : {Arr01.GetHashCode()}");
            Console.WriteLine($"Arr02.GetHashCode() : {Arr02.GetHashCode()}");
            Arr02[0] = 100;
            foreach (int number in Arr01)
                Console.WriteLine(number);
            Console.WriteLine("******************");
        }
    } 
}
