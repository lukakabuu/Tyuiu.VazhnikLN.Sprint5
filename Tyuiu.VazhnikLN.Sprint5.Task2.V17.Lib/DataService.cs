using System.Data;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VazhnikLN.Sprint5.Task2.V17.Lib
{
    public class DataService : ISprint5Task2V17
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists) File.Delete(path);
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            for (int i = 0; i <  rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if ((matrix[i, j] % 2) != 0) matrix[i, j] = 0;
                }
            }
            string n = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1) n = n + matrix[i, j] + ";";
                    else n = n + matrix[i, j];
                }
                if (i != rows - 1) File.AppendAllText(path, n + Environment.NewLine);
                else File.AppendAllText(path, n);
                n = "";
            }
            return path;
            
        }
    }
}
