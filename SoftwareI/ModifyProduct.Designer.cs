namespace SoftwareI
{
    partial class ModifyProduct
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
            searchTextBox = new TextBox();
            searchButton = new Button();
            cancelButton = new Button();
            saveButton = new Button();
            deleteAssociatedPartButton = new Button();
            addCandidatePartButton = new Button();
            associatedPartsLabel = new Label();
            candidatePartsLabel = new Label();
            associatedPartsDGV = new DataGridView();
            allCandidatePartsDGV = new DataGridView();
            maxTextBox = new TextBox();
            minTextBox = new TextBox();
            priceTextBox = new TextBox();
            inStockTextBox = new TextBox();
            productNameTextBox = new TextBox();
            IDTextBox = new TextBox();
            minLabel = new Label();
            maxLabel = new Label();
            priceLabel = new Label();
            inStockLabel = new Label();
            label2 = new Label();
            IDLabel = new Label();
            addProductLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)associatedPartsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allCandidatePartsDGV).BeginInit();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(673, 28);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(195, 27);
            searchTextBox.TabIndex = 45;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.Location = new Point(603, 28);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(64, 27);
            searchButton.TabIndex = 44;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(786, 513);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(64, 27);
            cancelButton.TabIndex = 43;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(716, 513);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(64, 27);
            saveButton.TabIndex = 42;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteAssociatedPartButton
            // 
            deleteAssociatedPartButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteAssociatedPartButton.Location = new Point(786, 480);
            deleteAssociatedPartButton.Name = "deleteAssociatedPartButton";
            deleteAssociatedPartButton.Size = new Size(64, 27);
            deleteAssociatedPartButton.TabIndex = 41;
            deleteAssociatedPartButton.Text = "Delete";
            deleteAssociatedPartButton.UseVisualStyleBackColor = true;
            deleteAssociatedPartButton.Click += deleteAssociatedPartButton_Click;
            // 
            // addCandidatePartButton
            // 
            addCandidatePartButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            addCandidatePartButton.Location = new Point(786, 253);
            addCandidatePartButton.Name = "addCandidatePartButton";
            addCandidatePartButton.Size = new Size(64, 27);
            addCandidatePartButton.TabIndex = 40;
            addCandidatePartButton.Text = "Add";
            addCandidatePartButton.UseVisualStyleBackColor = true;
            addCandidatePartButton.Click += addCandidatePartButton_Click;
            // 
            // associatedPartsLabel
            // 
            associatedPartsLabel.AutoSize = true;
            associatedPartsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            associatedPartsLabel.Location = new Point(427, 279);
            associatedPartsLabel.Name = "associatedPartsLabel";
            associatedPartsLabel.Size = new Size(240, 21);
            associatedPartsLabel.TabIndex = 39;
            associatedPartsLabel.Text = "Parts Associated with the Product";
            // 
            // candidatePartsLabel
            // 
            candidatePartsLabel.AutoSize = true;
            candidatePartsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            candidatePartsLabel.Location = new Point(427, 34);
            candidatePartsLabel.Name = "candidatePartsLabel";
            candidatePartsLabel.Size = new Size(137, 21);
            candidatePartsLabel.TabIndex = 38;
            candidatePartsLabel.Text = "All candidate Parts";
            // 
            // associatedPartsDGV
            // 
            associatedPartsDGV.AllowUserToAddRows = false;
            associatedPartsDGV.AllowUserToDeleteRows = false;
            associatedPartsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            associatedPartsDGV.Location = new Point(427, 303);
            associatedPartsDGV.Name = "associatedPartsDGV";
            associatedPartsDGV.ReadOnly = true;
            associatedPartsDGV.RowTemplate.Height = 25;
            associatedPartsDGV.Size = new Size(441, 171);
            associatedPartsDGV.TabIndex = 37;
            // 
            // allCandidatePartsDGV
            // 
            allCandidatePartsDGV.AllowUserToAddRows = false;
            allCandidatePartsDGV.AllowUserToDeleteRows = false;
            allCandidatePartsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allCandidatePartsDGV.Location = new Point(427, 58);
            allCandidatePartsDGV.Name = "allCandidatePartsDGV";
            allCandidatePartsDGV.ReadOnly = true;
            allCandidatePartsDGV.RowTemplate.Height = 25;
            allCandidatePartsDGV.Size = new Size(441, 189);
            allCandidatePartsDGV.TabIndex = 36;
            // 
            // maxTextBox
            // 
            maxTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maxTextBox.Location = new Point(89, 351);
            maxTextBox.Name = "maxTextBox";
            maxTextBox.Size = new Size(103, 29);
            maxTextBox.TabIndex = 35;
            // 
            // minTextBox
            // 
            minTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            minTextBox.Location = new Point(256, 351);
            minTextBox.Name = "minTextBox";
            minTextBox.Size = new Size(103, 29);
            minTextBox.TabIndex = 34;
            // 
            // priceTextBox
            // 
            priceTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceTextBox.Location = new Point(151, 303);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(187, 29);
            priceTextBox.TabIndex = 33;
            // 
            // inStockTextBox
            // 
            inStockTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inStockTextBox.Location = new Point(151, 254);
            inStockTextBox.Name = "inStockTextBox";
            inStockTextBox.Size = new Size(187, 29);
            inStockTextBox.TabIndex = 32;
            // 
            // productNameTextBox
            // 
            productNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productNameTextBox.Location = new Point(151, 208);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(187, 29);
            productNameTextBox.TabIndex = 31;
            // 
            // IDTextBox
            // 
            IDTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDTextBox.Location = new Point(151, 163);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(187, 29);
            IDTextBox.TabIndex = 30;
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            minLabel.Location = new Point(213, 354);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(37, 21);
            minLabel.TabIndex = 29;
            minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maxLabel.Location = new Point(31, 354);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(39, 21);
            maxLabel.TabIndex = 28;
            maxLabel.Text = "Max";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(31, 306);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(44, 21);
            priceLabel.TabIndex = 27;
            priceLabel.Text = "Price";
            // 
            // inStockLabel
            // 
            inStockLabel.AutoSize = true;
            inStockLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inStockLabel.Location = new Point(31, 257);
            inStockLabel.Name = "inStockLabel";
            inStockLabel.Size = new Size(64, 21);
            inStockLabel.TabIndex = 26;
            inStockLabel.Text = "In Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 211);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 25;
            label2.Text = "Name";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDLabel.Location = new Point(31, 166);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(25, 21);
            IDLabel.TabIndex = 24;
            IDLabel.Text = "ID";
            // 
            // addProductLabel
            // 
            addProductLabel.AutoSize = true;
            addProductLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addProductLabel.Location = new Point(-18, -46);
            addProductLabel.Name = "addProductLabel";
            addProductLabel.Size = new Size(135, 30);
            addProductLabel.TabIndex = 23;
            addProductLabel.Text = "Add Product";
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 554);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(deleteAssociatedPartButton);
            Controls.Add(addCandidatePartButton);
            Controls.Add(associatedPartsLabel);
            Controls.Add(candidatePartsLabel);
            Controls.Add(associatedPartsDGV);
            Controls.Add(allCandidatePartsDGV);
            Controls.Add(maxTextBox);
            Controls.Add(minTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(inStockTextBox);
            Controls.Add(productNameTextBox);
            Controls.Add(IDTextBox);
            Controls.Add(minLabel);
            Controls.Add(maxLabel);
            Controls.Add(priceLabel);
            Controls.Add(inStockLabel);
            Controls.Add(label2);
            Controls.Add(IDLabel);
            Controls.Add(addProductLabel);
            Name = "ModifyProduct";
            Text = "ModifyProduct";
            ((System.ComponentModel.ISupportInitialize)associatedPartsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)allCandidatePartsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchTextBox;
        private Button searchButton;
        private Button cancelButton;
        private Button saveButton;
        private Button deleteAssociatedPartButton;
        private Button addCandidatePartButton;
        private Label associatedPartsLabel;
        private Label candidatePartsLabel;
        private DataGridView associatedPartsDGV;
        private DataGridView allCandidatePartsDGV;
        private TextBox maxTextBox;
        private TextBox minTextBox;
        private TextBox priceTextBox;
        private TextBox inStockTextBox;
        private TextBox productNameTextBox;
        private TextBox IDTextBox;
        private Label minLabel;
        private Label maxLabel;
        private Label priceLabel;
        private Label inStockLabel;
        private Label label2;
        private Label IDLabel;
        private Label addProductLabel;
    }
}