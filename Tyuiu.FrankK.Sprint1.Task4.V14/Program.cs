using Tyuiu.FrankK.Sprint1.Task4.V14.Lib;
namespace Tyuiu.FrankK.Sprint1.Task4.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Введите X: ");
            double x;
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y: ");
            double y;
            y = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x, y);
            Console.WriteLine(res);
        }
    }
}