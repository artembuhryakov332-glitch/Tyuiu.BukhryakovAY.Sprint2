using Tyuiu.BukhryakovAY.Sprint2.Task3.V26.Lib;
namespace Tyuiu.BukhryakovAY.Sprint2.Task3.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double wait = -399.98;
            double x = -50;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
