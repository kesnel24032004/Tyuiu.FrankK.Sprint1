using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FrankK.Sprint1.Task1.V6.Lib
{
    public class DataService : ISprint1Task1V6
    {
        public double Calculate(double x, double y)
        {
            double res = ((x+y)/(3.0*y));
            return res;
        }
    }
}
