using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Task01
{
    class Program
    {
        public static System.Type[] FigureList = { typeof(Round), typeof(Ring), typeof(Line), typeof(Circle), typeof(Rectangle) };

        public static void Main(string[] args)
        {
            Figure Fg = Activator.CreateInstance(FigureList[0]) as Figure;
           
            foreach(var i in FigureList)
            {
                System.Console.Write("{0}", i);
            }

        }
    }
}
