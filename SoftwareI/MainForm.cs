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
            allPartsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            allPartsDataGridView.MultiSelect = false;
            allProductsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            allProductsDataGridView.MultiSelect = false;
            //Global Config manually input 4 times here as the auto incrementing is captured with the addpart form. 
            // Data to start the application with. 
            GlobalConfig.PartCount += 1;
            Part tire = new InHouse("Tire", 100, 2, 1, 10, 1234);
            GlobalConfig.PartCount += 1;
            Part spoke = new InHouse("Spoke", 10, 3, 1, 10, 1235);
            GlobalConfig.PartCount += 1;
            Part bolt = new Outsourced("bolt", 2, 50, 6, 1000, "Fastener LLC.");
            GlobalConfig.PartCount += 1;
            GlobalConfig.Inventory.AllParts.Add(tire);
            GlobalConfig.Inventory.AllParts.Add(spoke);
            GlobalConfig.Inventory.AllParts.Add(bolt);
            BindingList<Part> parts = new BindingList<Part>();
            BindingList<Part> parts2 = new BindingList<Part>();
            parts.Add(tire);
            parts.Add(spoke);
            parts.Add(bolt);
            parts.Add(bolt);
            parts.Add(bolt);
            parts.Add(bolt);
            parts.Add(bolt);
            parts.Add(bolt);
            parts2.Add(tire);
            parts2.Add(spoke);
            GlobalConfig.ProductCount += 1;
            Product wheel = new Product("wheel", 135, 20, 4, 200, parts);
            GlobalConfig.ProductCount += 1;
            Product bikeWheel = new Product("bike wheel", 25, 10, 2, 100, parts2);
            GlobalConfig.ProductCount += 1;
            GlobalConfig.Inventory.AllProducts.Add(wheel);
            GlobalConfig.Inventory.AllProducts.Add(bikeWheel);
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

        private void updateProductButton_Click(object sender, EventArgs e)
        {
            //Grabs the selected row index within the datagridview
            var selectedRowIndex = (int)(allProductsDataGridView.CurrentCell.RowIndex);

            //Takes the row index and then pulls the ID number from the row. This id number will be passed to the update form.
            var selectedProductID = allProductsDataGridView.Rows[selectedRowIndex].Cells[0].Value;

            if (selectedProductID != null)
            {
                var frmModifyProduct = new ModifyProduct((int)selectedProductID);
                frmModifyProduct.Show();
            }




        }

        private void updatePartButton_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = (int)(allPartsDataGridView.CurrentCell.RowIndex);
            var selectedPartID = allPartsDataGridView.Rows[selectedRowIndex].Cells[0].Value;

            if (selectedPartID != null)
            {
                var frmModifyPart = new ModifyPartForm((int)selectedPartID);
                frmModifyPart.Show();
            }
        }

        private void deletePartButton_Click(object sender, EventArgs e)
        {
            //Grabs the selected row index within the datagridview
            var selectedRowIndex = (int)(allPartsDataGridView.CurrentCell.RowIndex);

            //Takes the row index and then pulls the ID number from the row. This id number will be passed to the update form.
            var selectedPartID = allPartsDataGridView.Rows[selectedRowIndex].Cells[0].Value;
            string type = "Part";
            var confirmForm = new ConfirmForm((int)(selectedPartID), type);
            confirmForm.Show();


        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            // Grabs the selected row index within the datagridview
            var selectedRowIndex = (int)(allProductsDataGridView.CurrentCell.RowIndex);

            //Takes the row index and then pulls the ID number from the row. This id number will be passed to the update form.
            var selectedProductID = allProductsDataGridView.Rows[selectedRowIndex].Cells[0].Value;
            string type = "Product";

            Product selectedProduct = GlobalConfig.Inventory.lookupProduct((int)selectedProductID);
            int count = selectedProduct.AssociatedParts.Count;
            //SMessageBox.Show(count.ToString());
            if (count == 0)
            {
                var confirmForm = new ConfirmForm((int)(selectedProductID), type);
                confirmForm.Show();
            }
            else if (count > 0)
            {
                MessageBox.Show("You cannot delete a product with associated parts. ");
            }
            

        }

        private void searchPartButton_Click(object sender, EventArgs e)
        {
            if (partSearchTextBox.Text == "")
            {
                MessageBox.Show("Please enter an ID number to search!");
                return;
            }

            bool numerical = int.TryParse(partSearchTextBox.Text, out _);
            if (numerical == false)
            {
                MessageBox.Show("Please enter a numerical value to search by product ID.");
            }

            int partID = int.Parse(partSearchTextBox.Text);
            //Running through all of the rows in the datagridview to check for a match. 
            foreach (DataGridViewRow row in allPartsDataGridView.Rows)
            {
                //Ensuring that we are pulling a part from the DataGridView
                if (row.DataBoundItem is Part component)
                {
                    if (component.PartID == partID)
                    {
                        //Zeros out the datagridview
                        allPartsDataGridView.ClearSelection();
                        //This makes that row in the datagrid selected. Since the ID#s are unique it should only pull one back. 
                        row.Selected = true;
                        //The row with the correct ID number is now highlighted blue. 
                        return;
                    }
                }
            }
            MessageBox.Show("Your search term was not located in the database", "Please enter another search term.");
        }

        private void searchProductButton_Click(object sender, EventArgs e)
        {
            if (productSearchTextBox.Text == "")
            {
                MessageBox.Show("Please enter an ID number to search!");
                return;
            }

            bool numerical = int.TryParse(productSearchTextBox.Text, out _);
            if (numerical == false)
            {
                MessageBox.Show("Please enter a numerical value to search by product ID.");
            }

            int productID = int.Parse(productSearchTextBox.Text);
            //Running through all of the rows in the datagridview to check for a match. 
            foreach (DataGridViewRow row in allProductsDataGridView.Rows)
            {
                //Ensuring that we are pulling a part from the DataGridView
                if (row.DataBoundItem is Product product)
                {
                    if (product.ProductID == productID)
                    {
                        //Zeros out the datagridview
                        allProductsDataGridView.ClearSelection();
                        //This makes that row in the datagrid selected. Since the ID#s are unique it should only pull one back. 
                        row.Selected = true;
                        //The row with the correct ID number is now highlighted blue. 
                        return;
                    }
                }
            }
            MessageBox.Show("Your product # was not located in the database", "Please enter another product number.");
        }
        //Could write a function to reduce repetitive code on the search buttons, but that would be for future development. 
    }
}
