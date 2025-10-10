using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BukhryakovAY.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((Math.Pow(Math.E,x) >= y && Math.Pow(Math.E, -x) >= y && Math.Pow(x,2) <= y))
            {
                return true;
            }
            return false;   
        }
    }
}
