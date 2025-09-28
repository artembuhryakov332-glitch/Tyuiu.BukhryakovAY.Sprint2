using Tyuiu.BukhryakovAY.Sprint2.Task0.V27.Lib;
namespace Tyuiu.BukhryakovAY.Sprint2.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service = new DataService();
            int x = 1305;
            int y = 275;
            bool[] wait = new bool[6] { true, false, true, false, false, true };
            bool[] res = service.GetCompareOperations(x, y);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
int x = 1305;
int y = 275;
DataService ds = new DataService();
bool[] res = ds.GetCompareOperations(x, y);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("значение X = " + x);
Console.WriteLine("значение Y = " + y);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
foreach (bool value in res)
{
    Console.WriteLine(value);
}
