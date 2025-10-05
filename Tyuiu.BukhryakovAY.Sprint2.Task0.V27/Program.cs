using Tyuiu.BukhryakovAY.Sprint2.Task0.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
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

    }
}