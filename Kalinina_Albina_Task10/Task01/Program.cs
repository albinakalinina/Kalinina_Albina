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
            
        }
        public delegate void ArraySortDelegate<T>(string[] arr);
        public void Sort()
        {
            string[] arr = { };
            Array.Sort(arr, (x, y) => x.Length.CompareTo(y.Length));
           

        }
    }
}
