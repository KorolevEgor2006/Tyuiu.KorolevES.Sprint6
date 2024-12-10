using Tyuiu.KorolevES.Sprint6.Task5.V16.Lib;
namespace Tyuiu.KorolevES.Sprint6.Task5.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestReadFile()
        {
            string path = $@"C:\DataSprint6\InPutDataFileTask5V16.txt";
            DataService ds = new DataService();
            double[] wait = new double[] {12,5,12.89,35,13.83,12.76,8.86};
            double[] res = new double[ds.LoadFromDataFile(path).Length];
            res =ds.LoadFromDataFile(path);
            CollectionAssert.AreEqual(wait,res);
        }
    }
}