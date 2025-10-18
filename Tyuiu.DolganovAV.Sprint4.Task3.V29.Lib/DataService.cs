using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.DolganovAV.Sprint4.Task3.V29.Lib
{
    public class DataService : ISprint4Task3V29
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int cols = array.GetUpperBound(1) + 1;

            int res = 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j == 0) res *= array[i, j];
                }
            }
            return res;
        }
    }
}
