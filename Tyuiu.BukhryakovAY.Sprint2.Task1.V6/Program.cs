using Tyuiu.BukhryakovAY.Sprint2.Task1.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int a = 915;
        int b = 169;
        int c = 174;
        int d = 133;
        Console.WriteLine("значение A = " + a);
        Console.WriteLine("значение B = " + b);
        Console.WriteLine("значение C = " + c);
        Console.WriteLine("значение D = " + d);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        bool[] res = ds.GetLogicOperations(a, b, c, d);
        foreach (bool value in res)
        {
            Console.Write(value + " ");
        }
    }
}