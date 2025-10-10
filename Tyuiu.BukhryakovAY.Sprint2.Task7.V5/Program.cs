using Tyuiu.BukhryakovAY.Sprint2.Task7.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Введите значение X: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(" Введите значение Y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        bool res = ds.CheckDotInShadedArea(x, y);
        if (res)
        {
            Console.WriteLine("точка находится в заштрихованной области");
        }
        else
        {
            Console.WriteLine("точка не находится в заштрихованной области");
        }
    }
}