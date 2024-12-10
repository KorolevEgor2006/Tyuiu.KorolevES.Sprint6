using Tyuiu.KorolevES.Sprint6.Task4.V3.Lib;
namespace Tyuiu.KorolevES.Sprint6.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMassFunction()
        {
            DataService ds = new DataService();
            int start =-1, end =1;
            double[] wait = new double[] {2.93,2.5,0.71 };
            double[] res = new double[ds.GetMassFunction(start,end).Length];
            res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(wait, res); 
        }
    }
}