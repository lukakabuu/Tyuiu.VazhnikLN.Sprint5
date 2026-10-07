using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VazhnikLN.Sprint5.Task1.V14.Lib
{
    public class DataService : ISprint5Task1V14
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists) File.Delete(path);
            for (int i = startValue; i <= stopValue; i++)
            {
                double f = Math.Round((Math.Sin(i) / (i + 1.7) - Math.Cos(i) * 4 * i - 6), 2);
                string f1 = Convert.ToString(f);
                if (i != stopValue) File.AppendAllText(path, f1 + Environment.NewLine);
                else File.AppendAllText(path, f1);
            }
            return path;
        }
    }
}
