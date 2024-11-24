using tyuiu.cources.programming.interfaces.Sprint4; 
 
namespace Tyuiu.RotachAO.Sprint4.Task4.V23.Lib;

public class DataService : ISprint4Task4V23
{
    public int Calculate(int[,] matrix)
    {

        int s = 0;
        int rows = matrix.GetUpperBound(0) + 1;
        int cals = matrix.Length / rows;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cals; j++)
            {
                if (matrix[i, j] % 2 != 0) { s += matrix[i, j]; }
            }
        }
        return s;
    }
} 
