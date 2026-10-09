using System.Reflection.PortableExecutable;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VazhnikLN.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {
            double s = 0;
            double m = 0;
            using (StreamReader Reader = new StreamReader(path))
            {
                string line = Reader.ReadLine();
                string[] numbers = line.Split(' ');
                foreach (string num in numbers)
                {
                    double double_num = Convert.ToDouble(num, System.Globalization.CultureInfo.InvariantCulture);
                    if (double_num % 5 == 0)
                    {
                        s += double_num;
                        m++;
                    }
                }
            }
            return s / m;
        }
    }
}
