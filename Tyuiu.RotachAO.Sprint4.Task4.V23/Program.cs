using Tyuiu.RotachAO.Sprint4.Task4.V23.Lib; 
 
namespace Tyuiu.RotachAO.Sprint4.Task4.V23; 
 
class Program 
{ 
    static void Main(string[] args) 
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Ротач. А. О. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #4                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #4                                                           *"); 
        Console.WriteLine("* Вариант #23                                                          *"); 
        Console.WriteLine("* Выполнил: Ротач Анастасия Олеговна  | ИИПб-24-1                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        Console.WriteLine("*Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значениями *");
        Console.WriteLine("*с клавиатуры в диапазоне от 3 до 6. Найдите сумму нечетных элементов        *");
        Console.WriteLine("массива.                                                                     *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                            *");
        Console.WriteLine("*                                                                            *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("Введите количество столбцов:");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество строк:");
        int cols = Convert.ToInt32(Console.ReadLine());
        int[,] x = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine("Введите эллемент" + i + j + ":");
                x[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{x[i, j]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("******************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                  *");
        Console.WriteLine("******************************************************************************");
        Console.WriteLine(ds.Calculate(x));
    }
} 
