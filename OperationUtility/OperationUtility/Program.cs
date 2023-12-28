using System;

namespace OperationUtility
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CalculationUtility<double> util1 = new CalculationUtility<double>();
            CalculationUtility<string> util2 = new CalculationUtility<string>();
            Console.WriteLine(util2.Add("1", "2"));
            Console.WriteLine(util1.Add(5, 5.5));
            Console.WriteLine(util2.Multiply("1", "2"));//Throws an exception
            Console.WriteLine(util1.Quotient(5,2));//...
        }
    }
}