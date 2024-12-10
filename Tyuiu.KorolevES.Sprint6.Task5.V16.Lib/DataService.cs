using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
using System.Security.Cryptography.X509Certificates;
namespace Tyuiu.KorolevES.Sprint6.Task5.V16.Lib
{
    public class DataService : ISprint6Task5V16
    {
        public int len;
        public double[] LoadFromDataFile(string path)
        {
            len= 0;
            using(StreamReader reader = new StreamReader(path)) 
            {
                string line;
                while ((line = reader.ReadLine()) != null) 
                {
                    len++;
                }
            }

            double[] res = new double[len];
            int i = 0;
            using(StreamReader reader = new StreamReader(path)) 
            {
                string line;
                while ((line = reader.ReadLine()) != null) 
                {
                    res[i]= Math.Round(Convert.ToDouble(line),3);
                    i++;
                }
            }
            res =res.Where(x => x > 0).ToArray();
            return res;
        }
    }
}
