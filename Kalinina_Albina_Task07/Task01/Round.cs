using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Round : Figure
    {
       

        public int R { get; set; }
        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(R, 2);
            }

        }
        new public void Draw()
        {
            Console.WriteLine("Round");
        }

    }
}
