using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Text
    {
        static void Main(string[] args)
        {

            int a = 0;
            int b = 0;
            bool repeat = true;
            while (repeat)
            {
                do
                {
                    Console.WriteLine("Введите сторону a: ");
                }
                while (!int.TryParse(Console.ReadLine(), out a));


                do
                {
                    Console.WriteLine("Введите сторону b: ");
                }
                while (!int.TryParse(Console.ReadLine(), out b));
                if (a <= 0 || b <= 0)
                {
                    Console.WriteLine("ОШИБКА! Введите любое число кроме НУЛЯ!");
                    var i = Console.ReadKey(true);
                    if (i.Key != ConsoleKey.I)
                        repeat = false;
                    continue;
                }


                Console.WriteLine("A: {0}, B: {1}, Площадь: {2}", a, b, a * b);
                repeat = false;
                Console.ReadKey();
            }



        }
    }
}
