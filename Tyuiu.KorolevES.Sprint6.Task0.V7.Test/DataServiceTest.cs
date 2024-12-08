using Tyuiu.KorolevES.Sprint6.Task0.V7.Lib;
namespace Tyuiu.KorolevES.Sprint6.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            double wait = 0.211;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}