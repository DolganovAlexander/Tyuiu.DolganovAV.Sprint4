using Tyuiu.DolganovAV.Sprint4.Task0.V1.Lib;
namespace Tyuiu.DolganovAV.Sprint4.Task0.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();
            int[] array = { 6, 4, 3, 2, 1, 0, 9, 8, 7, 5 };
            int waitRes = 20;
            Assert.AreEqual(waitRes, ds.GetSumEvenArrEl(array));
        }
    }
}
