using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareI.Classes
{
    internal abstract class Part
    {
        //Abstract class to force the InHouse and Outsourced Classes to mirror a standard part format. 
        public int PartID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        //Empty default constructor
        public Part() {
            
        }
    }
}
