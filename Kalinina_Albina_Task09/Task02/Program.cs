using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
   public interface ICollection<T> : IEnumerable<T>
    {
        int count { get; }
        void Add(T elem);
        void RemoveAt(int index);
        bool Remove(T elem, int index);
        void Insert(T elem, int index);
        int Capacity { get; }
        int Length { get; }
        IEnumerator<T> GetEnumerator();
    }
   

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
