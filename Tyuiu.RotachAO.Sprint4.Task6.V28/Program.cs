using Tyuiu.RotachAO.Sprint4.Task6.V28.Lib; 
 
namespace Tyuiu.RotachAO.Sprint4.Task6.V28; 
 
class Program 
{ 
    static void Main(string[] args) 
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Ротач. А. О. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #4                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #6                                                           *"); 
        Console.WriteLine("* Вариант #28                                                          *"); 
        Console.WriteLine("* Выполнил: Ротач Анастасия Олеговна  | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        var word = new string[] { "Река", "Озеро", "Болото", "Океан", "Лужа", "Море" };
        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i <= word.Length - 1; i++)
        {
            Console.WriteLine(word[i]);
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Элементы исходного массива, длина которых = 4 ");
        string[] res = ds.Calculate(word);
        for (int i = 0; i <= res.Length - 1; i++)
        {
            Console.WriteLine(res[i]);
        }
        Console.ReadKey();
    } 
} 
