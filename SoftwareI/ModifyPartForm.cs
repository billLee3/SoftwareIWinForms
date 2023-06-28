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
    public partial class ModifyPartForm : Form
    {
        public ModifyPartForm()
        {
            InitializeComponent();
        }

        public ModifyPartForm(int partID)
        {
            InitializeComponent();
            IDTextBox.Enabled = false;
            IDTextBox.Text = partID.ToString();

            Part objPart = GlobalConfig.Inventory.LookupPart(partID);
            string type = objPart.GetType().Name;

            //Ensuring that the correct part object is updated. 
            if (type == "InHouse")
            {
                InHouse objInHouse = (InHouse)(objPart);
                partNameTextBox.Text = objInHouse.Name;
                priceTextBox.Text = objInHouse.Price.ToString();
                instockTextBox.Text = objInHouse.InStock.ToString();
                maxTextBox.Text = objInHouse.Max.ToString();
                minTextBox.Text = objInHouse.Min.ToString();
                objectAttributeSwitchLabel.Text = "Machine ID";
                objSpecificTextBox.Text = objInHouse.MachineID.ToString();



            }
            else if (type == "Outsourced")
            {
                Outsourced objOutsourced = (Outsourced)(objPart);
                outsourcedRadioButton.Checked = true;
                partNameTextBox.Text = objOutsourced.Name;
                priceTextBox.Text = objOutsourced.Price.ToString();
                instockTextBox.Text = objOutsourced.InStock.ToString();
                maxTextBox.Text = objOutsourced.Max.ToString();
                minTextBox.Text = objOutsourced.Min.ToString();
                objectAttributeSwitchLabel.Text = "Company";
                objSpecificTextBox.Text = objOutsourced.CompanyName;
            }



        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SoftwareI.Classes.Validation validator = new SoftwareI.Classes.Validation();
            bool standardCheck = validator.StandardValidation(IDTextBox.Text, partNameTextBox.Text, priceTextBox.Text, instockTextBox.Text, maxTextBox.Text, minTextBox.Text);
            if (standardCheck != true)
            {
                return;
            }
            else
            {
                bool partCheck = validator.PartValidation(InHouseRadioButton.Checked, outsourcedRadioButton.Checked, objSpecificTextBox.Text);
                if (partCheck == true)
                {
                    if (InHouseRadioButton.Checked == true)
                    {
                        InHouse updatedPart = new InHouse(int.Parse(IDTextBox.Text), partNameTextBox.Text, float.Parse(priceTextBox.Text), int.Parse(instockTextBox.Text), int.Parse(minTextBox.Text), int.Parse(maxTextBox.Text), int.Parse(objSpecificTextBox.Text));
                        GlobalConfig.Inventory.updatePart(int.Parse(IDTextBox.Text), updatedPart);
                        MessageBox.Show("The part has been updated");
                        Close();
                    }
                    else if (outsourcedRadioButton.Checked == true)
                    {
                        Outsourced updatedPart = new Outsourced(int.Parse(IDTextBox.Text), partNameTextBox.Text, float.Parse(priceTextBox.Text), int.Parse(instockTextBox.Text), int.Parse(minTextBox.Text), int.Parse(maxTextBox.Text), objSpecificTextBox.Text);
                        GlobalConfig.Inventory.updatePart(int.Parse(IDTextBox.Text), updatedPart);
                        Close();
                    }


                }

            }

        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            objectAttributeSwitchLabel.Text = "Machine ID";
        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            objectAttributeSwitchLabel.Text = "Company";
        }
    }
}
