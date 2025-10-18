using Tyuiu.DolganovAV.Sprint4.Task3.V29.Lib;
namespace Tyuiu.DolganovAV.Sprint4.Task3.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { {9, 9, 8, 6, 9 }, { 5, 8, 8, 8, 7 }, { 6, 5, 9, 7, 9 }, { 7, 7, 9, 7, 8 }, { 8, 5, 8, 5, 5 } };
            int res = ds.Calculate(array);
            int wait = 15120;
            Assert.AreEqual(wait, res);
        }
    }
}
