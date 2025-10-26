using Tyuiu.FrankK.Sprint1.Task2.V25.Lib;

namespace Tyuiu.FrankK.Sprint1.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 17;
            var res = ds.ConvertRadsToDegrees(a);
            Assert.AreEqual(974,029, res);
        }
    }
}