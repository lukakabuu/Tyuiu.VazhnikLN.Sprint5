using System.IO;
using System;
using Tyuiu.VazhnikLN.Sprint5.Task4.V15.Lib;
namespace Tyuiu.VazhnikLN.Sprint5.Task4.V15

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V15.txt");
            double x = 3.54;
            Console.WriteLine("x = " + x);
            Console.WriteLine($"Файл находится по пути: {path}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Результат = " + res);
        }
    }
}
