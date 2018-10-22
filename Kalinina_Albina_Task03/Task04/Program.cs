using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = CreateRandom2dArray(10, 10);

            Sum(a);
        }
        public static int[,] CreateRandom2dArray(int demension1, int demension2)
        {
            int[,] array = new int[demension1, demension2];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-10, 10);
                }
            }
            return array;

        }
        public static void Sum(int[,] array)
        {
            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j > array.GetLength(1); j++)
                {
                    if ((i + j)%2 == 0)
                    {
                        sum += array[i, j];
                    }
                    Console.Write(sum);

                }
            }
        }
    }
}
