using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T
{
    class Program
    {
        static void Main(string[] args)
        {
            string StringLine = "";
            string SecondLine = "";
            string SummaryLine = "";
            Console.WriteLine("Введите первую строку:");
            StringLine = Console.ReadLine();
            Console.WriteLine("Введите вторую строку:");
            SecondLine = Console.ReadLine();
            foreach(char ch in StringLine)
                if (!SecondLine.Contains(ch))
                {
                    SummaryLine += ch;
                }
                else
                {
                    SummaryLine += ch;
                    SummaryLine += ch;
                }
            Console.WriteLine(SummaryLine);
            Console.ReadKey();
        }
    }
}
