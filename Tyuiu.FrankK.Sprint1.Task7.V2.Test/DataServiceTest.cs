using Tyuiu.FrankK.Sprint1.Task7.V2.Lib;
namespace Tyuiu.FrankK.Sprint1.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2.519, res);
        }
    }
}
