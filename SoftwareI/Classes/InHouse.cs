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

        //Default Constructor
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

        //Constructor with auto-incrementing partID
        public InHouse(string name, double price, int instock, int min, int max, int machineid)
        {
            PartID = GlobalConfig.PartCount;
            Name = name;
            Price = price;
            InStock = instock;
            Min = min;
            Max = max;
            MachineID = machineid;
        }

        //Constructor with hardcoded partID
        public InHouse(int partID, string name, double price, int instock, int min, int max, int machineid)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = instock;
            Min = min;
            Max = max;
            MachineID = machineid;
        }
    }
}
