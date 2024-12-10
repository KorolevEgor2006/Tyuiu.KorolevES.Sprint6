using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KorolevES.Sprint6.Task4.V3.Lib
{
    public class DataService : ISprint6Task4V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len =stopValue - startValue+1;
            double[] result = new double[len];
            int count = 0;
            double res;
            for (int i = startValue; i <= stopValue; i++) 
            {
                if ((Math.Sin(i) - 3 + i) != 0) 
                {
                    res = (3 * i - 1.5) / (Math.Sin(i) - 3 + i) + 2;
                    result[count] = Math.Round(res, 2);
                }
                else 
                {
                    result[count] = 0;
                }
                count++;
            }
            return result;
            
        }
    }
}
