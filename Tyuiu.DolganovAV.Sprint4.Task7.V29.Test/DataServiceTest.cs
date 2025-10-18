using Tyuiu.DolganovAV.Sprint4.Task7.V29.Lib;
namespace Tyuiu.DolganovAV.Sprint4.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int n = 4;
            int m = 3;
            string value = "983157642891";
            Assert.AreEqual(28, ds.Calculate(n, m, value));
        }
    }
}
