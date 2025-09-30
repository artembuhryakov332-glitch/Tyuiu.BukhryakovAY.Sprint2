using Tyuiu.BukhryakovAY.Sprint2.Task2.V3.Lib;

namespace Tyuiu.BukhryakovAY.Sprint2.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 13;
            int y = 9;
            bool wait = false;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
