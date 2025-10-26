using Tyuiu.FrankK.Sprint1.Task1.V6.Lib;

namespace Tyuiu.FrankK.Sprint1.Task1.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3.0, 3.0);

            Assert.AreEqual(0.6666666666666666, res);
        }
    }
}