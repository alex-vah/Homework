namespace CalculateAverage;

public class Matrix
{
    private int[,] matrix;

    // Rows and Columns properties
    public int Rows { get; }
    public int Columns { get; }

    // Constructor to initialize the matrix
    public Matrix(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        matrix = new int[rows, columns];
    }

    // Indexer
    public int this[int row, int col]
    {
        get
        {
            CheckBounds(row, col);
            return matrix[row, col];
        }
        set
        {
            CheckBounds(row, col);
            matrix[row, col] = value;
        }
    }

    // Index bounds checking method
    private void CheckBounds(int row, int col)
    {
        if (row < 0 || row >= Rows || col < 0 || col >= Columns)
        {
            throw new IndexOutOfRangeException("Index out of bounds");
        }
    }
}