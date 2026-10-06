using System.IO;
using System;
using Tyuiu.VazhnikLN.Sprint5.Task0.V17.Lib;
namespace Tyuiu.VazhnikLN.Sprint5.Task0.V17

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
            string res = File.ReadAllText("OutPutFileTask0.txt");
            foreach (var c in File.ReadLines("OutPutFileTask0.txt"))
            {
                Console.WriteLine(c);
            }
            
        }
    }
}