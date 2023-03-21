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
    public partial class AddPartForm : Form
    {
        
        public AddPartForm()
        {
            InitializeComponent();
            IDTextBox.Text = GlobalConfig.PartCount.ToString();
            IDTextBox.Enabled = false;
        }

        private void InHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            objectAttributeSwitchLabel.Text = "Machine ID";
        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            objectAttributeSwitchLabel.Text = "Company";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SoftwareI.Classes.Validation validator = new SoftwareI.Classes.Validation();
            bool standardCheck = validator.StandardValidation(IDTextBox.Text, partNameTextBox.Text, priceTextBox.Text, instockTextBox.Text, maxTextBox.Text, minTextBox.Text);
            if (standardCheck != true) 
            {
                MessageBox.Show("Please check you entries and ensure that all are filled in and that the ID, price, InStock, Max, and Min options are all numeric. ");
            }
            else
            {
                bool partCheck = validator.PartValidation(InHouseRadioButton.Checked, outsourcedRadioButton.Checked, objSpecificTextBox.Text);
                if (partCheck != true)
                {
                    MessageBox.Show("Ensure that you've picked between Inhouse and Outsourced. That the last entry is saved, and that the last entry is numeric if you selected InHouse");
                }
                else
                {
                    if (InHouseRadioButton.Checked == true)
                    {
                        SoftwareI.Classes.Part part = new SoftwareI.Classes.InHouse(GlobalConfig.PartCount, partNameTextBox.Text, float.Parse(priceTextBox.Text), int.Parse(instockTextBox.Text), int.Parse(maxTextBox.Text), int.Parse(minTextBox.Text), int.Parse(objSpecificTextBox.Text));
                        //Need to figure out Global Configuration to save to the BindingList in the MainForm
                        GlobalConfig.Inventory.AllParts.Add(part);
                    }

                    if (outsourcedRadioButton.Checked == true)
                    {
                        SoftwareI.Classes.Part part = new SoftwareI.Classes.Outsourced(GlobalConfig.PartCount, partNameTextBox.Text, float.Parse(priceTextBox.Text), int.Parse(instockTextBox.Text), int.Parse(maxTextBox.Text), int.Parse(minTextBox.Text), objSpecificTextBox.Text);
                        GlobalConfig.Inventory.AllParts.Add(part); 
                    }
                        
                }
            }
            GlobalConfig.PartCount += 1;
            Close();


        }
    }
}
