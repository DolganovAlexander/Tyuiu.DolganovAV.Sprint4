using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.DolganovAV.Sprint4.Task5.V25.Lib
{
    public class DataService : ISprint4Task5V25
    {
        public int Calculate(int[,] matrix)
        {
            int res = 0;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0) res += matrix[i, j];
                }
            }
            return res;
        }
    }
}
