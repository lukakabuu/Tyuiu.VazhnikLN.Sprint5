using System.IO;
using System;
using Tyuiu.VazhnikLN.Sprint5.Task7.V19.Lib;
namespace Tyuiu.VazhnikLN.Sprint5.Task7.V19

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
            Console.WriteLine($"Файл с исходными данными находится по пути: {path}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.LoadDataAndSave(path);
            Console.WriteLine("Файл с конечными данными находится по пути: " + res);
            Console.ReadKey();
        }
    }
}
