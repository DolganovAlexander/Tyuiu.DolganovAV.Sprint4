using Tyuiu.DolganovAV.Sprint4.Task4.V2.Lib;
namespace Tyuiu.DolganovAV.Sprint4.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { 
                { 2, 2, 5, 5, 9 }, 
                { 7, 3, 8, 8, 9 }, 
                { 6, 7, 9, 3, 5 }, 
                { 7, 5, 7, 7, 8 }, 
                { 2, 2, 4, 7, 9 } 
            };
            var res = ds.Calculate(matrix);

            int[,] wait = new int[,] {
                { 2, 2, 0, 0, 0 },
                { 0, 0, 8, 8, 0 },
                { 6, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 8 },
                { 2, 2, 4, 0, 0 }
            };

            bool matricesEqual = true;
            for (int i = 0; i < wait.GetLength(0); i++)
            {
                for (int j = 0;  j < wait.GetLength(1); j++)
                {
                    if (res[i, j] != wait[i, j]) matricesEqual = false; break;
                }
            }

            Assert.AreEqual(true, matricesEqual);
        }
    }
}
