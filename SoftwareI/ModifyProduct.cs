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
    public partial class ModifyProduct : Form
    {
        BindingList<Part> associatedParts = new BindingList<Part>();
        BindingList<Part> finalizedParts = new BindingList<Part>();
        public ModifyProduct()
        {
            InitializeComponent();

        }

        public ModifyProduct(int productID)
        {
            InitializeComponent();
            allCandidatePartsDGV.DataSource = GlobalConfig.Inventory.AllParts;
            allCandidatePartsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            allCandidatePartsDGV.MultiSelect = false;
            associatedPartsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            associatedPartsDGV.MultiSelect = false;
            associatedPartsDGV.DataSource = associatedParts;
            IDTextBox.Enabled = false;
            if (productID != -1)
            {
                IDTextBox.Text = Convert.ToString(productID);
                IDTextBox.Enabled = false;
                //Grabing the associated product from the global Product list
                var objProduct = GlobalConfig.Inventory.lookupProduct(productID);
                productNameTextBox.Text = objProduct.ProductName.ToString();
                inStockTextBox.Text = objProduct.ProductInStock.ToString();
                priceTextBox.Text = objProduct.ProductPrice.ToString();
                minTextBox.Text = objProduct.ProductMin.ToString();
                maxTextBox.Text = objProduct.ProductMax.ToString();
                //Grabbing all of the parts in case some need to be added. 
                allCandidatePartsDGV.DataSource = GlobalConfig.Inventory.AllParts;
                //Makes the associated bindinglist equal to the objProducts associated part list
                associatedParts = objProduct.AssociatedParts;
                //Makes the DGV datasource the newly updated associatedParts binding list
                associatedPartsDGV.DataSource = associatedParts;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
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
    

        private void addCandidatePartButton_Click(object sender, EventArgs e)
        {
            if (allCandidatePartsDGV.SelectedRows.Count == 1)
            {
                var selectedRow = allCandidatePartsDGV.SelectedRows[0];
                var part = (Part)selectedRow.DataBoundItem;
                associatedParts.Add(part);
            }
        }

        private void deleteAssociatedPartButton_Click(object sender, EventArgs e)
        {
            //Grabs the selected row index within the datagridview
            var selectedRowIndex = (int)(associatedPartsDGV.CurrentCell.RowIndex);

            //Takes the row index and then pulls the ID number from the row. This id number will be passed to the update form.
            foreach(DataGridViewRow row in associatedPartsDGV.SelectedRows)
            {
                associatedPartsDGV.Rows.RemoveAt(selectedRowIndex);
            }
            
        }

        
        private void saveButton_Click(object sender, EventArgs e)
        {
            SoftwareI.Classes.Validation validator = new SoftwareI.Classes.Validation();
            bool standardCheck = validator.StandardValidation(IDTextBox.Text, productNameTextBox.Text, priceTextBox.Text, inStockTextBox.Text, maxTextBox.Text, minTextBox.Text);
            if (standardCheck != true)
            {
                return;
            }
            int productID = int.Parse(IDTextBox.Text);

            foreach (DataGridViewRow row in associatedPartsDGV.Rows)
            {
                //Ensuring that we are pulling a part from the DataGridView
                if (row.DataBoundItem is Part component)
                {
                    finalizedParts.Add(component);
                }
            }

            associatedParts = finalizedParts;
            Product updatedProduct = new Product(productID, productNameTextBox.Text, float.Parse(priceTextBox.Text), int.Parse(inStockTextBox.Text), int.Parse(maxTextBox.Text), int.Parse(minTextBox.Text), associatedParts);
            GlobalConfig.Inventory.updateProduct(productID, updatedProduct);
            MessageBox.Show("You've updated the product. ");
            Close();
        }   
    }
}
