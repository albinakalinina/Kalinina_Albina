using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] a = CreateRandomArray(10);
           // MinValueArray(a);
            //MaxValueArray(a);
            Sort(a);
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

        public static void MinValueArray(int[] array)
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    Console.WriteLine(min);
                }
            }
        }
        public static void MaxValueArray(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    Console.WriteLine(max);
                }
            }
        }

        public static void Sort(int[] array)
        {
            int sort;
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        sort = array[i];
                        array[i] = array[j];
                        array[j] = sort;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                    Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}