using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SoftwareI.Classes
{
    internal class InHouse : Part
    {
        public int MachineID { get; set; }

        public InHouse()
        {
            MachineID = 0;
            PartID = 0;
            Name = "Blank";
            Price = 0;
            InStock = 0;
            Min = 0;
            Max = 0;
        }

        public InHouse(int partid,  string name, double price, int instock, int min, int max, int machineid)
        {
            PartID = partid;
            Name = name;
            Price = price;
            InStock = instock;
            Min = min;
            Max = max;
            MachineID = machineid;
        }
    }
}
