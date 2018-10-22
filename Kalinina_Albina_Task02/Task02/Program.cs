using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер:");
            string imput = Console.ReadLine();
            int number = int.Parse(imput);
            string s = string.Empty;

            for (int i = 0; i < number; i++)
            {
                s = s + "*";
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }

    }
}
