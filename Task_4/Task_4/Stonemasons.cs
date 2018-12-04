using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Stonemasons
    {
        double productivity; //продуктивность бригады рабочих
        uint count;// кол-во рабочих
        
        public Stonemasons(double productivity, uint count)
        {
            this.count = count;
            this.productivity = productivity;
        }

        public double Productivity { get { return productivity; } }
        public uint Count { get { return count; } }
    }
}
