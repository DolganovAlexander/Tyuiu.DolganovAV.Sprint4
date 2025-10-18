using Tyuiu.DolganovAV.Sprint4.Task3.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Долганов А. В. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #29                                                             *");
        Console.WriteLine("* Выполнил: Долганов Александр Витальевич | ПИНб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая подсчитывает произведение элементов первого *");
        Console.WriteLine("* столбца в массиве 5 на 5, заполененный значениями от 5 до 9             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] array = new int[5,5] { { 9, 9, 8, 6, 9 }, { 5, 8, 8, 8, 7 }, { 6, 5, 9, 7, 9 }, { 7, 7, 9, 7, 8 }, { 8, 5, 8, 5, 5 } };
        int rows = array.GetUpperBound(0) + 1;
        int cols = array.GetUpperBound(1) + 1;
        Console.WriteLine("Матрица:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{array[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(array);
        Console.WriteLine($"Произведение первого стобца = {res}");
        Console.ReadKey();
    }
}