using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.DolganovAV.Sprint4.Task7.V29.Lib
{
    public class DataService : ISprint4Task7V29
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }

            int res = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 == 0) res += matrix[i, j];
                }
            }
            return res;
        }
    }
}