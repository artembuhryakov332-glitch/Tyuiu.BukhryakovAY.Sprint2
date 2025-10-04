using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BukhryakovAY.Sprint2.Task3.V26.Lib
{
    public class DataService : ISprint2Task3V26
    {
        public double Calculate(double x)
        {
            double y = 0;
            if ( x > 0)
            {
                y = x + Math.Pow((x + 1) / Math.Cos(x * x),x);
            }
            else
            {
                if (x == 0)
                {
                    y = (15 + x) / (9 - Math.Sin(x * x));
                }
                else
                {
                    if ( x > -30 && x < 0)
                    {
                        y = Math.Pow(Math.Sin(x * x * x) / (x + 5), x);
                    }
                    else
                    {
                        if (x < -30)
                        {
                            y = x + 7 * x - (1 / x);
                        }
                    }
                }
            }
            return Math.Round(y, 3);
        }
    }
}
