using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Ring
    {
        public double X1;
        public double Y1;
        public double X2;
        public double Y2;
        private double _r1;
        public double R1
        {
            get
            {
                return _r1;
            }
            set
            {
                if (value >= 0)
                {
                    _r1 = value;
                }
                else
                {
                    throw new Exception("Can't be zero!");
                }
            }

        }
        private double _r2;
        public double R2
        {
            get
            {
                return _r2;
            }
            set
            {
                if (value >= 0)
                {
                    _r2 = value;
                }
                else
                {
                    throw new Exception("Can't be zero!");
                }
            }

        }

        public double GetAreaRing()
        {
            return Math.PI * (Math.Pow(R2, 2)-Math.Pow(R1, 2));
        }
        public double GetLengthRing()
        {
            return (2 * Math.PI * R1 + 2 * Math.PI * R1);
        }

        public Ring(double x1, double x2, double y1, double y2, double r1, double r2)
        {
            X1 = x1;
            X2 = x2;
            Y1 = y1;
            Y2 = y2;
            R1 = r1;
            R2 = r2;

        }
    }
}
