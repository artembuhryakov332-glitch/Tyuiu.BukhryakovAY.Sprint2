using Tyuiu.BukhryakovAY.Sprint2.Task7.V5.Lib;
namespace Tyuiu.BukhryakovAY.Sprint2.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 1;
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
