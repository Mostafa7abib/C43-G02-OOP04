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

            IMovable movable = new Airplane();
            movable.Forward();

            IFlyable flyable = new Airplane();
            flyable.Forward();
        }
    } 
}
