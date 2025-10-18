using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.DolganovAV.Sprint4.Task5.V5.Lib
{
    public class DataService : ISprint4Task6V5
    {
        public int Calculate(string[] array)
        {
            string[] res = Array.FindAll(array, x => x.Length == 5);
            int ans = res.Length;
            return ans;
        }
    }
}
