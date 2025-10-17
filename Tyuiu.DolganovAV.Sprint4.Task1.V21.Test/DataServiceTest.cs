using Tyuiu.DolganovAV.Sprint4.Task1.V21.Lib;
namespace Tyuiu.DolganovAV.Sprint4.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] nums = { 2, 4, 8, 5, 2, 6, 5, 8, 8, 6, 6 };
            Assert.AreEqual(1769472, ds.Calculate(nums));
        }
    }
}
