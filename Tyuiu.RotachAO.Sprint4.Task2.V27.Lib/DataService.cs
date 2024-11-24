using tyuiu.cources.programming.interfaces.Sprint4; 
 
namespace Tyuiu.RotachAO.Sprint4.Task2.V27.Lib;

public class DataService : ISprint4Task2V27
{
    public int Calculate(int[] array)
    {
        int sumArray = 1;
        for (int i = 0; i <= array.Length - 1; i++)
        {
            if (array[i] % 2 != 1)
            {
                sumArray += array[i];
            }
        }
        return sumArray;
    }
} 
