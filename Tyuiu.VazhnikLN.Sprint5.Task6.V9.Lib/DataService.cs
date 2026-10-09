using System.ComponentModel.Design.Serialization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VazhnikLN.Sprint5.Task6.V9.Lib
{
    public class DataService : ISprint5Task6V9
    {
        public int LoadFromDataFile(string path)
        {
            int s = 0;
            int m = 0;
            int s1 = 0;
            using (StreamReader Reader = new StreamReader(path))
            {
                string line = Reader.ReadLine();
                for (int i = 0; i < line.Length; i++)
                {
                    if (char.IsLetter(line[i]))
                    {
                        m++;
                    }
                    else
                    {
                        if (m == 3) s++;
                        m = 0;
                    }
                }
            }
            return s;
        }
    }
}
