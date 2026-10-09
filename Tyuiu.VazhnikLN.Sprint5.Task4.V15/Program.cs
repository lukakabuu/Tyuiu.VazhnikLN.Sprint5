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
            string path1 = @"DataSprint5";
            string path2 = @"InPutDataFileTask4V15.txt";
            string path = Path.Combine("C:", path1, path2);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(path);
            double c = ds.LoadFromDataFile(path);
            Console.WriteLine(c);





        }
    }
}
