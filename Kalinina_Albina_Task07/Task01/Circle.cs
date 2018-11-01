using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Circle : Round
    {

        new public void Draw()
        {
            Console.WriteLine("Circle");
        }
    }
}
