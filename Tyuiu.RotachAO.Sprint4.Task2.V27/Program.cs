using Tyuiu.RotachAO.Sprint4.Task2.V27.Lib; 
 
namespace Tyuiu.RotachAO.Sprint4.Task2.V27; 
 
class Program 
{ 
    static void Main(string[] args) 

    {
        Random rnd = new Random();
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Ротач. А. О. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #4                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #2                                                           *"); 
        Console.WriteLine("* Вариант #27                                                          *"); 
        Console.WriteLine("* Выполнил: Ротач Анастасия Олеговна  | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        Console.WriteLine("Введите количество элементов массива: ");
        int len = Convert.ToInt32(Console.ReadLine());

        int[] numsArray = new int[len];

        for (int i = 0; i <= len - 1; i++)
        {
            numsArray[i] = rnd.Next(2, 7);
        }

        Console.WriteLine("Массив:");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine(numsArray[i] + "\t");
        }

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(numsArray);
        Console.WriteLine("Cумма четных элементов массива = " + res);
        Console.ReadKey();
    } 
} 
