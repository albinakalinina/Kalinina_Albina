using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class PrintSeries
    {
        public static void Print1Series(ISeries series)
        {
            series.Reset();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }
    }
}
