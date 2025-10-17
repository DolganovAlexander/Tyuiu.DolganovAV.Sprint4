using Tyuiu.DolganovAV.Sprint4.Task2.V3.Lib;
namespace Tyuiu.DolganovAV.Sprint4.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 2, 4, 5, 2, 7, 4, 5, 6, 3, 4, 2, 5 };
            Assert.AreEqual(24, ds.Calculate(array));
        }
    }
}
