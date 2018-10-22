using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Triangle
    {
        public double A;
        public double B;
        public double C;

        private double _h;
        public double H
        {
            get
            {
                return _h = (A + B + C) / 2; ;
            }
            set
            {
                if (value >= 0)
                {
                    _h = value;
                }
                else
                {
                    throw new Exception("Can't be zero!");
                }
            }

        }

        public bool CheckTriangle()
        {
            if (((A + B > C) && (B + C > A) && (C + A > B)) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public double GetArea()
        {
            return Math.Sqrt(H * (H - A) * (H - B) * (H - C));

        }

        public double GetPerimeter()
        {
            return A + B + C;
        }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

        }

    }

}

