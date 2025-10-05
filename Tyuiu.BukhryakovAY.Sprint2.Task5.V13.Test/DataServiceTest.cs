using Tyuiu.BukhryakovAY.Sprint2.Task5.V13.Lib;
namespace Tyuiu.BukhryakovAY.Sprint2.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2007;
            int m = 11;
            int n = 30;
            string wait = "30.11.2007";
            string res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(res, wait);
        }
    }
}
