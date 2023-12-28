namespace OperationUtility
{
    public interface ICalculationUtility<T>
    {
        T Add(T a, T b);
        T Subtract(T a, T b);
        T Multiply(T a, T b);
        T Divide(T a, T b);
        T Quotient(T a, T b);
    }
}