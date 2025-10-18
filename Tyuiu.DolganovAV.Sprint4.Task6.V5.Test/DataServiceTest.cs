using Tyuiu.DolganovAV.Sprint4.Task5.V5.Lib;
namespace Tyuiu.DolganovAV.Sprint4.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string[] array = { "Меркурий", "Венера", "Земля", "Марс", "Юпитер", "Сатурн", "Уран", "Нептун" };
            int res = ds.Calculate(array);
            Assert.AreEqual(1, res);
        }
    }
}
