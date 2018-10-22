using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Line : Figure 
    {
        new public void Draw()
        {
            Console.WriteLine("Line");
        }

       new public void Show()
        {
            Console.WriteLine("");
        }
    }
}
