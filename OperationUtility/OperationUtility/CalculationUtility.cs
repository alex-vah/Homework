
using System;
using Microsoft.CSharp;
namespace OperationUtility
{
    public class CalculationUtility<T> : ICalculationUtility<T>
    {
        public T Add(T a, T b)
        {
            T val = default(T);
            try
            {
                val = (dynamic)a + b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return val;
        }
        public T Subtract(T a, T b)
        {
            T val = default(T);
            try
            {
                val = (dynamic)a - b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return val;

        }
        public T Multiply(T a, T b)
        {
            T val = default(T);
            try
            {
                val = (dynamic)a * b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return val;
        }
        public T Divide(T a, T b)
        {
            T val = default(T);
            try
            {
                val = (dynamic)a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return val;
        }
        public T Quotient(T a, T b)
        {
            T val = default(T);
            try
            {
                val = (dynamic)a % b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return val;
        }
    }
}