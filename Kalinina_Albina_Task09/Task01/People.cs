using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class People
    {
        public People(int sequenceNumber)
        {
            SequenceNumber = sequenceNumber;
        }

        public int SequenceNumber { get; set; }

        public People NextPeople { get; set; }
    }
}
