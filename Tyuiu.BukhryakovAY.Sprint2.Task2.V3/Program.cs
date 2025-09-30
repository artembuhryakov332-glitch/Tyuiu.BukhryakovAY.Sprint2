
using Tyuiu.BukhryakovAY.Sprint2.Task2.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Введите значение X: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Введите значение Y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        bool res = ds.CheckDotInShadedArea(x, y);
        Console.WriteLine(res);
    }
}