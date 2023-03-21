using SoftwareI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareI
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            //SoftwareI.Classes.Inventory inventory = new SoftwareI.Classes.Inventory();
            InitializeComponent();
            allPartsDataGridView.DataSource = GlobalConfig.Inventory.AllParts;
            allProductsDataGridView.DataSource = GlobalConfig.Inventory.AllProducts;

        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            //Call the AddPart Form
            AddPartForm addPartForm = new AddPartForm();
            //Shows the AddPart Form
            addPartForm.Show();
            //Makes MainForm invisible.
            //Visible = false;
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
