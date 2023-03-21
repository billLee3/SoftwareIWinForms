namespace SoftwareI
{
    partial class ModifyPartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            InHouseRadioButton = new RadioButton();
            outsourcedRadioButton = new RadioButton();
            partIDLabel = new Label();
            partNameLabel = new Label();
            inStockLabel = new Label();
            priceLabel = new Label();
            maxLabel = new Label();
            minLabel = new Label();
            objectAttributeSwitchLabel = new Label();
            IDTextBox = new TextBox();
            partNameTextBox = new TextBox();
            instockTextBox = new TextBox();
            priceTextBox = new TextBox();
            maxTextBox = new TextBox();
            minTextBox = new TextBox();
            objSpecificTextBox = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 14);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 0;
            label1.Text = "Add Part";
            // 
            // InHouseRadioButton
            // 
            InHouseRadioButton.AutoSize = true;
            InHouseRadioButton.Location = new Point(146, 20);
            InHouseRadioButton.Name = "InHouseRadioButton";
            InHouseRadioButton.Size = new Size(74, 19);
            InHouseRadioButton.TabIndex = 1;
            InHouseRadioButton.TabStop = true;
            InHouseRadioButton.Text = "In-House";
            InHouseRadioButton.UseVisualStyleBackColor = true;
            InHouseRadioButton.CheckedChanged += InHouseRadioButton_CheckedChanged;
            // 
            // outsourcedRadioButton
            // 
            outsourcedRadioButton.AutoSize = true;
            outsourcedRadioButton.Location = new Point(261, 20);
            outsourcedRadioButton.Name = "outsourcedRadioButton";
            outsourcedRadioButton.Size = new Size(87, 19);
            outsourcedRadioButton.TabIndex = 2;
            outsourcedRadioButton.TabStop = true;
            outsourcedRadioButton.Text = "Outsourced";
            outsourcedRadioButton.UseVisualStyleBackColor = true;
            outsourcedRadioButton.CheckedChanged += outsourcedRadioButton_CheckedChanged;
            // 
            // partIDLabel
            // 
            partIDLabel.AutoSize = true;
            partIDLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            partIDLabel.Location = new Point(146, 74);
            partIDLabel.Name = "partIDLabel";
            partIDLabel.Size = new Size(24, 20);
            partIDLabel.TabIndex = 3;
            partIDLabel.Text = "ID";
            // 
            // partNameLabel
            // 
            partNameLabel.AutoSize = true;
            partNameLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            partNameLabel.Location = new Point(121, 119);
            partNameLabel.Name = "partNameLabel";
            partNameLabel.Size = new Size(49, 20);
            partNameLabel.TabIndex = 4;
            partNameLabel.Text = "Name";
            // 
            // inStockLabel
            // 
            inStockLabel.AutoSize = true;
            inStockLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            inStockLabel.Location = new Point(109, 169);
            inStockLabel.Name = "inStockLabel";
            inStockLabel.Size = new Size(61, 20);
            inStockLabel.TabIndex = 5;
            inStockLabel.Text = "In Stock";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(94, 213);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(76, 20);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "Price/Cost";
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            maxLabel.Location = new Point(133, 259);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(37, 20);
            maxLabel.TabIndex = 7;
            maxLabel.Text = "Max";
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            minLabel.Location = new Point(133, 304);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(34, 20);
            minLabel.TabIndex = 8;
            minLabel.Text = "Min";
            // 
            // objectAttributeSwitchLabel
            // 
            objectAttributeSwitchLabel.AutoSize = true;
            objectAttributeSwitchLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            objectAttributeSwitchLabel.Location = new Point(94, 346);
            objectAttributeSwitchLabel.Name = "objectAttributeSwitchLabel";
            objectAttributeSwitchLabel.Size = new Size(37, 20);
            objectAttributeSwitchLabel.TabIndex = 9;
            objectAttributeSwitchLabel.Text = "TBD";
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(176, 74);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(157, 23);
            IDTextBox.TabIndex = 10;
            // 
            // partNameTextBox
            // 
            partNameTextBox.Location = new Point(176, 120);
            partNameTextBox.Name = "partNameTextBox";
            partNameTextBox.Size = new Size(157, 23);
            partNameTextBox.TabIndex = 11;
            // 
            // instockTextBox
            // 
            instockTextBox.Location = new Point(176, 170);
            instockTextBox.Name = "instockTextBox";
            instockTextBox.Size = new Size(157, 23);
            instockTextBox.TabIndex = 12;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(176, 214);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(157, 23);
            priceTextBox.TabIndex = 13;
            // 
            // maxTextBox
            // 
            maxTextBox.Location = new Point(176, 259);
            maxTextBox.Name = "maxTextBox";
            maxTextBox.Size = new Size(157, 23);
            maxTextBox.TabIndex = 14;
            // 
            // minTextBox
            // 
            minTextBox.Location = new Point(173, 301);
            minTextBox.Name = "minTextBox";
            minTextBox.Size = new Size(160, 23);
            minTextBox.TabIndex = 15;
            // 
            // objSpecificTextBox
            // 
            objSpecificTextBox.Location = new Point(173, 343);
            objSpecificTextBox.Name = "objSpecificTextBox";
            objSpecificTextBox.Size = new Size(160, 23);
            objSpecificTextBox.TabIndex = 16;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(173, 397);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 17;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(258, 397);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // AddPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 484);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(objSpecificTextBox);
            Controls.Add(minTextBox);
            Controls.Add(maxTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(instockTextBox);
            Controls.Add(partNameTextBox);
            Controls.Add(IDTextBox);
            Controls.Add(objectAttributeSwitchLabel);
            Controls.Add(minLabel);
            Controls.Add(maxLabel);
            Controls.Add(priceLabel);
            Controls.Add(inStockLabel);
            Controls.Add(partNameLabel);
            Controls.Add(partIDLabel);
            Controls.Add(outsourcedRadioButton);
            Controls.Add(InHouseRadioButton);
            Controls.Add(label1);
            Name = "AddPartForm";
            Text = "AddPartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton InHouseRadioButton;
        private RadioButton outsourcedRadioButton;
        private Label partIDLabel;
        private Label partNameLabel;
        private Label inStockLabel;
        private Label priceLabel;
        private Label maxLabel;
        private Label minLabel;
        private Label objectAttributeSwitchLabel;
        private TextBox IDTextBox;
        private TextBox partNameTextBox;
        private TextBox instockTextBox;
        private TextBox priceTextBox;
        private TextBox maxTextBox;
        private TextBox minTextBox;
        private TextBox objSpecificTextBox;
        private Button saveButton;
        private Button cancelButton;
    }
}