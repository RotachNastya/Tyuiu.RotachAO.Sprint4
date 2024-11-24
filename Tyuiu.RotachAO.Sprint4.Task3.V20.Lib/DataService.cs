using tyuiu.cources.programming.interfaces.Sprint4; 
 
namespace Tyuiu.RotachAO.Sprint4.Task3.V20.Lib;

public class DataService : ISprint4Task3V20
{
    public int Calculate(int[,] array)
    {

        int rows = array.GetUpperBound(0) + 1; // stroki
        int colums = array.Length / rows; //stolbci

        int min = array[0, 3];

        for (int i = 0; i < rows; i++)
        {
            if (array[i, 3] < min)
            {
                min = array[i, 3];
            }
        }
        return min;
    }
} 
