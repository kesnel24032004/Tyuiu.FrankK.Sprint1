using Tyuiu.FrankK.Sprint1.Task3.V3.Lib;
namespace Tyuiu.FrankK.Sprint1.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double q = 1;
            double r = 2;
            double s = 3;
            var res = ds.ParallelepipedVolume(q, r, s);
            Assert.AreEqual(6, res);
        }
    }
}
