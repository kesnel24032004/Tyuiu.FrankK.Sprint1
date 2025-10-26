using Tyuiu.FrankK.Sprint1.Task1.V6.Lib;

namespace Tyuiu.FrankK.Sprint1.Task1.V6
{
    class Program
    {
        static void Main(string[] args)
        {


            DataService ds = new DataService();
            

            double x, y;
            Console.WriteLine("Введите x, через enter: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y, через enter: ");
            y = Convert.ToDouble(Console.ReadLine());

            
            Console.WriteLine(" РЕЗУЛЬТАТ:  ");
            

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}