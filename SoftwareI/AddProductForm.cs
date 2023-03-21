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
    public partial class AddProductForm : Form
    {
        BindingList<Part> associatedParts = new BindingList<Part>();
        public AddProductForm()
        {
            InitializeComponent();
            allCandidatePartsDGV.DataSource = GlobalConfig.Inventory.AllParts;
            associatedPartsDGV.DataSource = associatedParts;
            IDTextBox.Text = GlobalConfig.ProductCount.ToString();
            IDTextBox.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SoftwareI.Classes.Validation validator = new SoftwareI.Classes.Validation();
            bool standardCheck = validator.StandardValidation(IDTextBox.Text, productNameTextBox.Text, priceTextBox.Text, inStockTextBox.Text, maxTextBox.Text, minTextBox.Text);
            if (standardCheck != true)
            {
                MessageBox.Show("Please check you entries and ensure that all are filled in and that the ID, price, InStock, Max, and Min options are all numeric. ");
            }
            else
            {
                float price = float.Parse(priceTextBox.Text);
                int inStock = int.Parse(inStockTextBox.Text);
                int max = int.Parse(maxTextBox.Text);
                int min = int.Parse(minTextBox.Text);

                Product product = new Product(GlobalConfig.ProductCount, productNameTextBox.Text, price, inStock, max, min, associatedParts);
                GlobalConfig.Inventory.AllProducts.Add(product);
            }
            GlobalConfig.ProductCount += 1;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
