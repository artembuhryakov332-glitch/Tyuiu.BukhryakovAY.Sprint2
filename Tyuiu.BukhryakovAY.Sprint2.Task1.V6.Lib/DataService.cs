
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BukhryakovAY.Sprint2.Task1.V6.Lib
{
    public class DataService : ISprint2Task1V6
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];
            result[0] = (b > a)|(d == c);
            result[1] = (b!=c)&(a <= d);
            result[2] = (c > d)||(c >= b);
            result[3] = (a < d)&&( a == d);
            result[4] = !result[0];
            result[5] = (a!=d)^( b == c - 5);
            
            return result;
       
        }
    }
}
