using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.FrankK.Sprint1.Task3.V3.Lib;
namespace Tyuiu.FrankK.Sprint1.Task3.V3.Lib
{
    public class DataService : ISprint1Task3V3
    {
        public double ParallelepipedVolume(double length, double width, double height)
        {
            double res = length * width * height;
            return Math.Round(res, 3);
        }
    }
}
