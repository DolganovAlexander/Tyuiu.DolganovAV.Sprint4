using Tyuiu.DolganovAV.Sprint4.Task0.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Долганов А. В. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Долганов Александр Витальевич | ПИНб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая подсчитывает сумму четных элементов массива *");
        Console.WriteLine("* { 6, 4, 3, 2, 1, 0, 9, 8, 7, 5 }                                        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] array = { 6, 4, 3, 2, 1, 0, 9, 8, 7, 5 };
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.GetSumEvenArrEl(array);
        Console.WriteLine($"Сумма четных элементов = {res}");
        Console.ReadKey();

    }
}