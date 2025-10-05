using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BukhryakovAY.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            if (g >= 1 && g < 30 && m >= 1 && m <= 12)
            {
                g++;
                string[] date = [g.ToString("00"), m.ToString("00"), n.ToString()];
                return string.Join(".", date);
            }
            else if(g == 30 || g == 31)
            {
                g = 1;
                m++;
                string[] date = [g.ToString("00"), m.ToString("00"), n.ToString()];
                return string.Join(".", date);
            }
            else
            {
                return "ошибка ввода";
            }
            
        }
    }
}
