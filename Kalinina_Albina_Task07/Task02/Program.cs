﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public interface ISeries
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }
    class Program
    {
        static void Main(string[] args)
        {

            Progression progression = new Progression();
        }
       
      
    }
}