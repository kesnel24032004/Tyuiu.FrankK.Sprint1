using System.Diagnostics.CodeAnalysis;
using Tyuiu.FrankK.Sprint1.Task2.V25.Lib;
namespace Tyuiu.FrankK.Sprint1.Task2.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("ВВедите Х: ");
            int x = Convert.ToInt32(Console.ReadLine());
            double res = ds.ConvertRadsToDegrees(x);
            Console.WriteLine(res);
        }
    }
}