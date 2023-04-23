using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareI.Classes
{
    internal class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(string name, double price, int instock, int min, int max, string companyname)
        {
            PartID = GlobalConfig.PartCount;
            Name = name;
            Price = price;
            InStock = instock;
            Min = min;
            Max = max;
            CompanyName = companyname;
        }

        public Outsourced(int partID, string name, double price, int instock, int min, int max, string companyname)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = instock;
            Min = min;
            Max = max;
            CompanyName = companyname;
        }


    }
}
