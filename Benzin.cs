using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Benzin
    {
        public Benzin(string name, double sum)
        {
            Name = name;
            Sum = sum;
        }

        public string Name { get; set; }
        public double Sum { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
