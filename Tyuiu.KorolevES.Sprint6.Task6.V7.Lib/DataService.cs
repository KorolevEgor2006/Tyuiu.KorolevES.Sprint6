using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.KorolevES.Sprint6.Task6.V7.Lib
{
    public class DataService : ISprint6Task6V7
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";
            using (StreamReader reader = new StreamReader(path))
            {
                
                string line;
                while ((line = reader.ReadLine()) != null) 
                {
                    string lines = "";
                    int a = 0;
                    for (int i = 0; i < line.Length; i++) 
                    {
                        if ((line[i] != ' ')) a = 1;
                        if(a!=0)lines+= line[i];
                    }
                    string[] strings = lines.Split(' ');
                    if (strings.Length > 1) {
                        if (res != "") res += " ";
                        res += strings[2];
                    }
                }
            }
            return res;
        }
    }
}
