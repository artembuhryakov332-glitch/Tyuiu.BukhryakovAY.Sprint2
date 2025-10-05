using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BukhryakovAY.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            if (n >= 1 && n < 30 && m >= 1 && m <= 12)
            {
                n++;
                string[] date = [n.ToString("00"), m.ToString("00"), g.ToString()];
                return string.Join(".", date);
            }
            else if(g == 30 || g == 31)
            {
                n = 1;
                m++;
                string[] date = [n.ToString("00"), m.ToString("00"), g.ToString()];
                return string.Join(".", date);
            }
            else
            {
                return "ошибка ввода";
            }
            
        }
    }
}
