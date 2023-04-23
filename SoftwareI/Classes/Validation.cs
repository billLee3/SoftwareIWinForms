using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftwareI.Classes
{
    internal class Validation
    {
        //Product Validation only requires standard. 
        public bool StandardValidation(string id, string name, string price, string inStock, string max, string min)
        {
            //List<string> inputs = new List<string> { IDTextBox.Text, priceTextBox.Text, instockTextBox.Text, minTextBox.Text, maxTextBox.Text };
            List<string> numericEntries = new List<string> { id, price, inStock, max, min };
            foreach( string entry in numericEntries)
            {
                bool canConvert = float.TryParse(entry, out _);
                if (canConvert != true) {
                    MessageBox.Show("Ensure that you are using the correct data types");
                    return false;
                }
            }
            if (name == "") {
                MessageBox.Show("Ensure that you entered a name for your part/product");
                return false;
            }
            if (int.Parse(min) > int.Parse(max)) {
                MessageBox.Show("The minimum value must be less than the maximum value");
                return false;
            }
            if (int.Parse(min) > int.Parse(inStock) | int.Parse(max) < int.Parse(inStock)) {
                MessageBox.Show("The instock amount must fall between the minimum and maximum values.");
                return false;
            }
            return true;
        }

        public bool PartValidation(bool inHouseChecked, bool outsourcedChecked, string objTextBox)
        {
            if (inHouseChecked != true & outsourcedChecked != true) 
            {
                Console.WriteLine("Select either InHouse or Outsourced");
                return false; 
            }
            
            if (inHouseChecked == true)
            {
                bool canCovert2 = float.TryParse(objTextBox, out _);
                if (canCovert2 == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            //Any entry into Outsourced will work here. No check needed for numeric value. 
            return true;
        }
    }
}
