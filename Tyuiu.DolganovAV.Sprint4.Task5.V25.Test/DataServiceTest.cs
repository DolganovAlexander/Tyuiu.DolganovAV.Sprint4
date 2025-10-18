using Tyuiu.DolganovAV.Sprint4.Task5.V25.Lib;
namespace Tyuiu.DolganovAV.Sprint4.Task5.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] {
                { -3, -2, 0, 3, 2},
                { 2, -2, -4, -2, 1},
                { 3, -2, -3, -1, -4},
                { 3, -2, 1, 2, -3},
                { 0, 0, 1, 3, 2},
            };
            int res = ds.Calculate(matrix);
            Assert.AreEqual(23, res);
        }
    }
}
