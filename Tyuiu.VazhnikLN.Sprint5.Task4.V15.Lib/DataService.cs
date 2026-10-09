using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VazhnikLN.Sprint5.Task4.V15.Lib
{
    public class DataService : ISprint5Task4V15
    {
        public double LoadFromDataFile(string path)
        {
            double x = double.Parse(File.ReadAllText(path).Trim(), System.Globalization.CultureInfo.InvariantCulture);
            double y = Math.Round(Math.Sin(x) + x * x / 2, 3);
            return y;
        }
    }
}
