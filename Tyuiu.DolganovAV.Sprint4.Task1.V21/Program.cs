using Tyuiu.DolganovAV.Sprint4.Task1.V21.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Долганов А. В. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнил: Долганов Александр Витальевич | ПИНб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая подсчитывает произведение четных элементов  *");
        Console.WriteLine("* массива  {2, 4, 8, 5, 2, 6, 5, 8, 8, 6, 6}                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        
        int len;
        Console.Write("Введите количество элементов массива: ");
        len = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[len];

        for (int i = 0; i < len; i++)
        {
            Console.Write($"Введите значение {i} элемента массива");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Массив:");
        for (int i = 0; i < len; i++)
        {
            Console.Write(array[i] + "\t");
        }


        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(array);
        Console.WriteLine($"Произведение четных элементов = {res}");
        Console.ReadKey();

    }
}