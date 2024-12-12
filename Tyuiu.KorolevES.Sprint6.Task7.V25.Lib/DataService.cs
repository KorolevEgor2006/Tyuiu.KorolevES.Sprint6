using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.KorolevES.Sprint6.Task7.V25.Lib
{
    public class DataService : ISprint6Task7V25
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    matrix[r, c] = Convert.ToInt32(line[c]);
                }
            }
            for(int j = 0; j < matrix.GetLength(0); j++) 
            {
                if (matrix[j, 6] % 5 == 0) matrix[j, 6] = 2;
            }
            return matrix;
        }
    }
}
