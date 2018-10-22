using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    abstract class Figure 
    {
        public int x { get; set; }
        public int y { get; set; }

        public void Draw()
        {
        }
        abstract public void Show();

   
          
    }

}