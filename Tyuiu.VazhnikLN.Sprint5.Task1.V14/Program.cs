using System.IO;
using System;
using Tyuiu.VazhnikLN.Sprint5.Task1.V14.Lib;
namespace Tyuiu.VazhnikLN.Sprint5.Task1.V14

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startvalue = -5;
            int stopvalue = 5;
            Console.WriteLine("Начало шага = " + startvalue);
            Console.WriteLine("Конец шага = " + stopvalue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string c = ds.SaveToFileTextData(startvalue, stopvalue);
            Console.WriteLine(c);
            string res = File.ReadAllText("OutPutFileTask1.txt");
            Console.WriteLine($"Фай: {res}");





        }
    }
}
