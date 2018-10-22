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
            Figure[] Fg = new Figure[5];
                                           
            Fg[0] = new Round("Round");
            Fg[1] = new Ring("Ring");
            Fg[2] = new Line("Line");
            Fg[3] = new Circle ("Circle");
            Fg[4] = new Rectangle("Rectangle");

            foreach (Figure a in Fg)
            {

                a.Show();

            }

        }
    }
}
