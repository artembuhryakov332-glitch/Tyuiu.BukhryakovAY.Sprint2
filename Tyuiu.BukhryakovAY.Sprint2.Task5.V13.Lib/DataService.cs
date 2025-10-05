using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BukhryakovAY.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int[] res = [g, m, n];
            switch (res)
            {
                case [>= 1,>=1 and <= 12,>= 1 and < 30]:
                    int[] date = [g, m, n + 1];
                    string stringDate = String.Join(" ", date);
                    return(stringDate);

                case[>= 1, >= 1 and <= 12, 30 or 31]:
                    int[] difDate = [g, m + 1, n = 1];
                    string stringDifDate = String.Join(" ", difDate);
                    return(stringDifDate);
                default:
                    return "неверно заданы параметры";
            }
        }
    }
}
