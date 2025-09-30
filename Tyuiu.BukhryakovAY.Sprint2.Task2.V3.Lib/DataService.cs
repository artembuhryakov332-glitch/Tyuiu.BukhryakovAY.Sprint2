using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BukhryakovAY.Sprint2.Task2.V3.Lib
{
    public class DataService : ISprint2Task2V3
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x >= 3 && x <= 13) && (y >= 3 && y <= 13))
            {

                if ((x >= 6 && x <= 8) && (y >= 3 && y <= 6))
                {
                    return false;
                }
                if (((x >= 9 && x <= 10) || (x >= 12 && x <= 13)) && (y == 3))
                {
                    return false;
                }
                if ((x >= 10 && x <= 13) && (y >= 5 && y <= 6))
                {
                    return false;
                }
                if ((x >= 10 && x <= 13) && (y >= 5 && y <= 6))
                {
                    return false;
                }
                if ((x == 13) && (y == 8))
                {
                    return false;
                }
                if ((x >= 9 && x <= 13) && (y >= 9 && y <= 10))
                {
                    return false;
                }
                if ((x >= 9 && x <= 10) && (y == 13))
                {
                    return false;
                }
                if ((x == 3) && (y == 13))
                {
                    return false;
                }
                if ((x >= 4 && x <= 5) && (y >= 11 && y <= 13))
                {
                    return false;
                }
                if ((x >= 3 && x <= 4) && (y >= 6 && y <= 8))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            return false;
        }
    }
}
