// See https://aka.ms/new-console-template for more information
 
//Task 1

using CalculateAverage;

static double CalculateAverage(string path)
{
    List<int> integers = new List<int>();
    try
    {
        var readLine = File.ReadLines(path);
        try
        {
            foreach (var item in readLine)
            {
                integers.Add(Convert.ToInt32(item));
            }

            return integers.Average();
        }
        catch (FormatException )
        {
            Console.WriteLine("The file contains a non numerical element");
            throw;
        }
    }
    catch (FileNotFoundException )
    {
        Console.WriteLine("No file found with the given path");
        throw;
    }
    catch (IOException )
    {
        Console.WriteLine("Something went wrong");
        throw;
    }
}
var path1 = "/Users/alexvahanyan/Downloads/input.txt"; 
 var path2 = "/Users/alexvahanyan/Downloads/input.tx";
 Console.WriteLine(CalculateAverage(path1));//Everything runs smoothly
Console.WriteLine(CalculateAverage(path2));//Throws an exception

//Task 2
var matrix = new Matrix(3, 4);

// Setting values using the indexer
matrix[0, 0] = 1;
matrix[1, 1] = 5;

Console.WriteLine($"Value at (1, 2): {matrix[1,1]}");

//Task 3
Coordinate point = new Coordinate(3, 1);
Vector vector = point;  // Implicit conversion from Coordinate to Vector
Console.WriteLine(vector.X);
Console.WriteLine(vector.Y);
Vector vector2 = new Vector(2, 4);
Coordinate point2 = (Coordinate)vector2;  // Explicit conversion from Vector to Coordinate
Console.WriteLine(point2.X);
Console.WriteLine(point2.Y);