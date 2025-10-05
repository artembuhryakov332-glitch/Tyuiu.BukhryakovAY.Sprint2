using Tyuiu.BukhryakovAY.Sprint2.Task4.V9.Lib;
namespace Tyuiu.BukhryakovAY.Sprint2.Task4.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double y = 1;
            double x = -6;
            double wait = 7.028;
            double res = ds.Calculate(x,y);
            Assert.AreEqual(wait,res); 
        }
    }
}
