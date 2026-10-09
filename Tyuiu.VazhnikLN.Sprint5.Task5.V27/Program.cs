using System.IO;
using System;
using Tyuiu.VazhnikLN.Sprint5.Task5.V27.Lib;
namespace Tyuiu.VazhnikLN.Sprint5.Task5.V27

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V27.txt");
            Console.WriteLine($"Файл находится по пути: {path}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Результат = " + res);
        }
    }
}