using System.IO;
using System;
using Tyuiu.VazhnikLN.Sprint5.Task6.V9.Lib;
namespace Tyuiu.VazhnikLN.Sprint5.Task6.V9

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V9.txt");
            Console.WriteLine($"Файл находится по пути: {path}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Результат = " + res);
        }
    }
}
