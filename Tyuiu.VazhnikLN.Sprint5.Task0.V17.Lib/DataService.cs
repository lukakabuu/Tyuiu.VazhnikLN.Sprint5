using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VazhnikLN.Sprint5.Task0.V17.Lib
{
    public class DataService : ISprint5Task0V17
    {
        public string SaveToFileTextData(int x)
        {
            string c = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            File.SetAttributes(c, FileAttributes.Normal);
            double z = 2.4 * Math.Pow(x, 3) + 0.4 * Math.Pow(x, 2) - 1.4 * x + 4.1;
            File.WriteAllText(c, Convert.ToString(z));
            File.SetAttributes(c, FileAttributes.Normal);
            Math.Round(z, 2);
            return c;
        }
    }
}
