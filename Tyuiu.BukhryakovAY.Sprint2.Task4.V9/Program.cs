using Tyuiu.BukhryakovAY.Sprint2.Task4.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите значение X: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение Y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        double res = ds.Calculate(x,y);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(res);
    }
}