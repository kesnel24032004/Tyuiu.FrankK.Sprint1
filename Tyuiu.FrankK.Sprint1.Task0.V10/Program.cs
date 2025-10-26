using Tyuiu.FrankK.Sprint1.Task0.V10.Lib;



namespace Tyuiu.FrankK.Sprint1.Task0.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            

            Console.WriteLine(" 3*(4+1)                             ");

            
            Console.WriteLine(" РЕЗУЛЬТАТ:                       ");
            

            Console.WriteLine(ds.Calculate());


            Console.ReadKey();
        }
    }
}