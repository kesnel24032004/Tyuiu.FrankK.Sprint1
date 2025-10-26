using Tyuiu.FrankK.Sprint1.Task3.V3.Lib;
namespace Tyuiu.FrankK.Sprint1.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Введите длина: ");
            double ч;
            ч = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширина: ");
            double x;
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту: ");
            double q;
            q = Convert.ToDouble(Console.ReadLine());
            double res = ds.ParallelepipedVolume(q, x, ч);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}