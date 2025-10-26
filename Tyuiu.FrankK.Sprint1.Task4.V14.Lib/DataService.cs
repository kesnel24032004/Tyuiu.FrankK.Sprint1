using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.FrankK.Sprint1.Task4.V14.Lib
{
    public class DataService : ISprint1Task4V14
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Sqrt(7 + Math.Abs(x-y))/(3*x*(y*y));
            return Math.Round(res, 3);
        }
    }
}
