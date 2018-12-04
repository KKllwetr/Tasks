using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public interface IConstructionEquipments
    {
        uint Speed { get; set; }
        double Productivity { get; set; }
        bool OpenTo();
    }
}
