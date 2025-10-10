using Tyuiu.BukhryakovAY.Sprint2.Task6.V2.Lib;
namespace Tyuiu.BukhryakovAY.Sprint2.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int value = 4;
            string wait = "Весна";
            string res = dataService.FindMonthSeason(value);
            Assert.AreEqual(wait,res);
        }
    }
}
