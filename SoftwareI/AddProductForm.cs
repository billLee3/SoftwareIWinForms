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
            allCandidatePartsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            allCandidatePartsDGV.MultiSelect = false;
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
                return;
            }
            else
            {
                float price = float.Parse(priceTextBox.Text);
                int inStock = int.Parse(inStockTextBox.Text);
                int max = int.Parse(maxTextBox.Text);
                int min = int.Parse(minTextBox.Text);

                Product product = new Product(productNameTextBox.Text, price, inStock, max, min, associatedParts);
                GlobalConfig.Inventory.AllProducts.Add(product);
            }
            GlobalConfig.ProductCount += 1;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addCandidatePartButton_Click(object sender, EventArgs e)
        {
            //This works but may need more functionality. 
            if (allCandidatePartsDGV.SelectedRows.Count == 1)
            {
                var selectedRow = allCandidatePartsDGV.SelectedRows[0];
                var part = (Part)selectedRow.DataBoundItem;
                associatedParts.Add(part);
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                MessageBox.Show("Please enter an ID number to search!");
                return;
            }

            bool numerical = int.TryParse(searchTextBox.Text, out _);
            if (numerical == false)
            {
                MessageBox.Show("Please enter a numerical value to search by product ID.");
            }

            int partID = int.Parse(searchTextBox.Text);
            //Running through all of the rows in the datagridview to check for a match. 
            foreach (DataGridViewRow row in allCandidatePartsDGV.Rows)
            {
                //Ensuring that we are pulling a part from the DataGridView
                if (row.DataBoundItem is Part component)
                {
                    if (component.PartID == partID)
                    {
                        //Zeros out the datagridview
                        allCandidatePartsDGV.ClearSelection();
                        //This makes that row in the datagrid selected. Since the ID#s are unique it should only pull one back. 
                        row.Selected = true;
                        //The row with the correct ID number is now highlighted blue. 
                        return;
                    }
                }
            }
            MessageBox.Show("Your search term was not located in the database", "Please enter another search term.");
        }
    }
}
