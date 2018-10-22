using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер:");
            string imput = Console.ReadLine();
            int lines = int.Parse(imput);

            for (int i = 1; i <= lines; i++)
            {
               var spaces = lines - i;
               string s = new string('*', i * 2 - 1);
               var s2 = new string(' ',spaces);
               var s3 = s2 + s;
               Console.WriteLine(s3);
            }
            Console.ReadLine();
        }
    }
}

