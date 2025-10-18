using Tyuiu.DolganovAV.Sprint4.Task5.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Долганов А. В. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел)                     *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнил: Долганов Александр Витальевич | ПИНб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая подсчитывает сумму положительных элементов  *");
        Console.WriteLine("* массива 5 на 5 со случайными значениями в диапазоне от -4 до 3          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int rows; int cols;
        Console.Write("Введите количество столбцов в массиве: ");
        cols = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество строк в массиве: ");
        rows = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        for (int i = 0;  i < rows; i++)
        {
            for (int j = 0;  j < cols; j++)
            {
                matrix[i, j] = rnd.Next(-4, 3);
            }
        }

        Console.WriteLine("Массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0;j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        var res = ds.Calculate(matrix);
        Console.WriteLine($"Сумма всех положительных элементов массива: {res}");
        Console.ReadLine();
    }
}