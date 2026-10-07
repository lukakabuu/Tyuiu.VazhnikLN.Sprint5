using System.IO;
using System;
using Tyuiu.VazhnikLN.Sprint5.Task3.V6.Lib;
namespace Tyuiu.VazhnikLN.Sprint5.Task3.V6

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 3;
            Console.WriteLine("x = " + x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string c = ds.SaveToFileTextData(x);
            Console.WriteLine($"Файл: {c}" + " создан!");





        }
    }
}