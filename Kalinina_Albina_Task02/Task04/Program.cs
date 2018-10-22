using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер:");
            string imput = Console.ReadLine();
            int lines = int.Parse(imput);

            for (int i = 0; i <= lines; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.WriteLine("{0}{1}", new string(' ', lines - j), new string('*', 2 * j + 1));
                }
            }
            Console.ReadLine(); 
        }
    }
}





