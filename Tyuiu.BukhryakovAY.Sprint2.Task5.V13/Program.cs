using Tyuiu.BukhryakovAY.Sprint2.Task5.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите год: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите месяц: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите день: ");
        int g = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.FindDateOfNextDay(n, m, g);
        Console.WriteLine("Следующий день: " + res);
    }
}