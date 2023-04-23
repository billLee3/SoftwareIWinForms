using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareI
{
    public partial class ConfirmForm : Form
    {

        public static int ObjID { get; set; }
        public static string Type { get; set; }
        //public ConfirmForm()
        //{
        // InitializeComponent();
        //}

        public ConfirmForm(int iD, string type)
        {
            InitializeComponent();
            ObjID = iD;
            Type = type;
        }

        private void yesButton_Click_1(object sender, EventArgs e)
        {
            if (Type == "Part")
            {
                GlobalConfig.Inventory.deletePart(ObjID);
                MessageBox.Show("Your part has successfully been deleted. ");
                Close();
            }
            else if (Type == "Product")
            {
                GlobalConfig.Inventory.deleteProduct(ObjID);
                MessageBox.Show("Your product has successfully been deleted. ");
                Close();
            }

        }

        private void noButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
