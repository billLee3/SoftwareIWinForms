using SoftwareI.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareI
{
    internal class GlobalConfig
    {
        private static Inventory inventory = new Inventory();
        public static Inventory Inventory { get { return inventory; } }
        //Starting this after the generic examples hardcoded in
        private static int partCount = 1; 
        public static int PartCount { get; set; }
        //Starting this after the generic examples hardcoded in
        private static int productCount = 1;
        public static int ProductCount { get; set; }
    }
}
