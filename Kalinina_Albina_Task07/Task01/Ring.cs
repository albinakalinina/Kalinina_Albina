using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Ring : Round
    {
        new int R { get; set; }
        new double Area
        {
            get
            {
                return base.Area - Math.Pow(R, 2);
            }
        }
        new public void Draw()
        {
            Console.WriteLine("Ring");
        }


    }
}
