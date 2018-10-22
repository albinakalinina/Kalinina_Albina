using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] a = CreateRandom3Array(10, 10, 10);

            ReplaceToZero(a);
            Console.ReadLine();
        }
        public static int[,,] CreateRandom3Array(int length1, int length2, int length3)
        {
            int[,,] array = new int[length1, length2, length3];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = random.Next(-10, 10);
                    }
                }
            }
            return array;

        }

        public static void ReplaceToZero(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {

                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j, k] > 0)
                        {
                            array[i, j, k] = 0;


                        }
                        Console.WriteLine(array[i, j, k]);
                    }
                }


            }
        }
    }
}
