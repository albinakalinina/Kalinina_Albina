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
            int[] a = CreateRandomArray(10);

            Sum(a);

        }
        public static int[] CreateRandomArray(int length)
        {
            int[] array = new int[length];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);
            }
            return array;

        }
        public static void Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i]>= 0)
                {
                    sum += array[i];
                }
                Console.Write(sum);
                Console.ReadKey();
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                Console.ReadLine();
            }
        }
    }

}


