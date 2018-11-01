using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public interface ISeries
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }
    public interface IIndexable
    {
        double this[int index]
        {
            get;
            set;
        }
    }
}
class Program
{

    static void Main(string[] args)
    {
    }
}

