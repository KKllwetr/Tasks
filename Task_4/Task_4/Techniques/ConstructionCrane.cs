using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.Techniques
{
    public class ConstructionCrane : IConstructionEquipments
    {
        bool open;
        uint speed;
        double productivity= 3;

        public bool OpenTo() => open;
        public uint Speed { get {return speed; } set { if (value>0) speed = value; } }
        public double Productivity { get { return productivity; } set { if (value > 0) productivity = value; } } 
    }
}
