using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
   

    class Progression : ISeries
    {
        public Progression(double a, double b, int n)
        {
            double k, sum = 0;
            k = b / a;

            if (k <= 1)
            {
                sum = (a * (Math.Pow(k, n) - 1)) / (k - 1);
            }

            else
            {
                throw new Exception("'k' can't be empty!");

            }
            

        }
        private double[] series;
        private int sum;

        public Progression(double[] series)
        {
            this.series = series;
            sum = 0;
        }
        public double GetCurrent()
        {
            return sum;
        }

        public bool MoveNext()
        {
            sum = sum < series.Length - 1 ? sum + 1 : 0;
            return true;
        }
        public void Reset()
        {
            sum = 0;
        }
    }
}

