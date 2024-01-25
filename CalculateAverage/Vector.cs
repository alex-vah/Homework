namespace CalculateAverage;

public class Vector
{
    public double X { get; set; }
    public double Y { get; set; }

    public Vector(double x, double y)
    {
        X = x;
        Y = y;
    }

    // Explicit conversion from Vector to Coordinate
    public static explicit operator Coordinate(Vector vector)
    {
        return new Coordinate(vector.X, vector.Y);
    }
}