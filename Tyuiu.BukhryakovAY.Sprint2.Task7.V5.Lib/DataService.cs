using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BukhryakovAY.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((Math.Pow(Math.E,x) >= y && Math.Pow(Math.E, -x) <= y && Math.Pow(x,2) <= y) || (x >= 0 && (y >= 0 && y<= 1) ))
            {
                if ( (x >= 0 && x<= 1) && (x <= 0 && x >= -1) && (y >= 0 && y <= 1))
                {
                    return true;
                }
            }
            return false;   
        }
    }
}
