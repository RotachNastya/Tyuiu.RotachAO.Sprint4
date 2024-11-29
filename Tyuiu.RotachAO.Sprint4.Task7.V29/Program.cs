using Tyuiu.RotachAO.Sprint4.Task7.V29.Lib; 
 
namespace Tyuiu.RotachAO.Sprint4.Task7.V29; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Ротач. А. О. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #4                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #7                                                           *"); 
        Console.WriteLine("* Вариант #29                                                          *"); 
        Console.WriteLine("* Выполнил: Ротач Анастасия Олеговна  | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Дана строка из одноразрядных цифр 983157642891. Преобразуйте ее в       *");
        Console.WriteLine("* матрицу 4 на 3 и подсчитайте сумму четных чисел.                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int rows = 4;
        int columns = 3;
        int[,] mtrx = new int[rows, columns];
        string str = "348561792486";
        int sum = 0;

        int index = 0;

        Console.WriteLine("\nМассив: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{str[index]} \t");
                index++;
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(rows, columns, str);
        Console.WriteLine("Сумма четных элементов = " + res);
        Console.ReadKey();
    }
} 

