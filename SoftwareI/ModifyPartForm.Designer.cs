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
            cancelButton = new Button();
            saveButton = new Button();
            objSpecificTextBox = new TextBox();
            minTextBox = new TextBox();
            maxTextBox = new TextBox();
            priceTextBox = new TextBox();
            instockTextBox = new TextBox();
            partNameTextBox = new TextBox();
            IDTextBox = new TextBox();
            objectAttributeSwitchLabel = new Label();
            minLabel = new Label();
            maxLabel = new Label();
            priceLabel = new Label();
            inStockLabel = new Label();
            partNameLabel = new Label();
            partIDLabel = new Label();
            outsourcedRadioButton = new RadioButton();
            InHouseRadioButton = new RadioButton();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(199, 405);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 37;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(114, 405);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 36;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // objSpecificTextBox
            // 
            objSpecificTextBox.Location = new Point(114, 351);
            objSpecificTextBox.Name = "objSpecificTextBox";
            objSpecificTextBox.Size = new Size(160, 23);
            objSpecificTextBox.TabIndex = 35;
            // 
            // minTextBox
            // 
            minTextBox.Location = new Point(114, 309);
            minTextBox.Name = "minTextBox";
            minTextBox.Size = new Size(160, 23);
            minTextBox.TabIndex = 34;
            // 
            // maxTextBox
            // 
            maxTextBox.Location = new Point(117, 267);
            maxTextBox.Name = "maxTextBox";
            maxTextBox.Size = new Size(157, 23);
            maxTextBox.TabIndex = 33;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(117, 222);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(157, 23);
            priceTextBox.TabIndex = 32;
            // 
            // instockTextBox
            // 
            instockTextBox.Location = new Point(117, 178);
            instockTextBox.Name = "instockTextBox";
            instockTextBox.Size = new Size(157, 23);
            instockTextBox.TabIndex = 31;
            // 
            // partNameTextBox
            // 
            partNameTextBox.Location = new Point(117, 128);
            partNameTextBox.Name = "partNameTextBox";
            partNameTextBox.Size = new Size(157, 23);
            partNameTextBox.TabIndex = 30;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(117, 82);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(157, 23);
            IDTextBox.TabIndex = 29;
            // 
            // objectAttributeSwitchLabel
            // 
            objectAttributeSwitchLabel.AutoSize = true;
            objectAttributeSwitchLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            objectAttributeSwitchLabel.Location = new Point(35, 354);
            objectAttributeSwitchLabel.Name = "objectAttributeSwitchLabel";
            objectAttributeSwitchLabel.Size = new Size(37, 20);
            objectAttributeSwitchLabel.TabIndex = 28;
            objectAttributeSwitchLabel.Text = "TBD";
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            minLabel.Location = new Point(74, 312);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(34, 20);
            minLabel.TabIndex = 27;
            minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            maxLabel.Location = new Point(74, 267);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(37, 20);
            maxLabel.TabIndex = 26;
            maxLabel.Text = "Max";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(35, 221);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(76, 20);
            priceLabel.TabIndex = 25;
            priceLabel.Text = "Price/Cost";
            // 
            // inStockLabel
            // 
            inStockLabel.AutoSize = true;
            inStockLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            inStockLabel.Location = new Point(50, 177);
            inStockLabel.Name = "inStockLabel";
            inStockLabel.Size = new Size(61, 20);
            inStockLabel.TabIndex = 24;
            inStockLabel.Text = "In Stock";
            // 
            // partNameLabel
            // 
            partNameLabel.AutoSize = true;
            partNameLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            partNameLabel.Location = new Point(62, 127);
            partNameLabel.Name = "partNameLabel";
            partNameLabel.Size = new Size(49, 20);
            partNameLabel.TabIndex = 23;
            partNameLabel.Text = "Name";
            // 
            // partIDLabel
            // 
            partIDLabel.AutoSize = true;
            partIDLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            partIDLabel.Location = new Point(87, 82);
            partIDLabel.Name = "partIDLabel";
            partIDLabel.Size = new Size(24, 20);
            partIDLabel.TabIndex = 22;
            partIDLabel.Text = "ID";
            // 
            // outsourcedRadioButton
            // 
            outsourcedRadioButton.AutoSize = true;
            outsourcedRadioButton.Location = new Point(202, 28);
            outsourcedRadioButton.Name = "outsourcedRadioButton";
            outsourcedRadioButton.Size = new Size(87, 19);
            outsourcedRadioButton.TabIndex = 21;
            outsourcedRadioButton.TabStop = true;
            outsourcedRadioButton.Text = "Outsourced";
            outsourcedRadioButton.UseVisualStyleBackColor = true;
            outsourcedRadioButton.CheckedChanged += outsourcedRadioButton_CheckedChanged;
            // 
            // InHouseRadioButton
            // 
            InHouseRadioButton.AutoSize = true;
            InHouseRadioButton.Location = new Point(87, 28);
            InHouseRadioButton.Name = "InHouseRadioButton";
            InHouseRadioButton.Size = new Size(74, 19);
            InHouseRadioButton.TabIndex = 20;
            InHouseRadioButton.TabStop = true;
            InHouseRadioButton.Text = "In-House";
            InHouseRadioButton.UseVisualStyleBackColor = true;
            InHouseRadioButton.CheckedChanged += InHouseRadioButton_CheckedChanged;
            // 
            // ModifyPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 463);
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
            Name = "ModifyPartForm";
            Text = "ModifyPartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button saveButton;
        private TextBox objSpecificTextBox;
        private TextBox minTextBox;
        private TextBox maxTextBox;
        private TextBox priceTextBox;
        private TextBox instockTextBox;
        private TextBox partNameTextBox;
        private TextBox IDTextBox;
        private Label objectAttributeSwitchLabel;
        private Label minLabel;
        private Label maxLabel;
        private Label priceLabel;
        private Label inStockLabel;
        private Label partNameLabel;
        private Label partIDLabel;
        private RadioButton outsourcedRadioButton;
        private RadioButton InHouseRadioButton;
    }
}