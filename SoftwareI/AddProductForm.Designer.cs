namespace SoftwareI
{
    partial class AddProductForm
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
            addProductLabel = new Label();
            IDLabel = new Label();
            label2 = new Label();
            inStockLabel = new Label();
            priceLabel = new Label();
            maxLabel = new Label();
            minLabel = new Label();
            IDTextBox = new TextBox();
            productNameTextBox = new TextBox();
            inStockTextBox = new TextBox();
            priceTextBox = new TextBox();
            minTextBox = new TextBox();
            maxTextBox = new TextBox();
            allCandidatePartsDGV = new DataGridView();
            associatedPartsDGV = new DataGridView();
            candidatePartsLabel = new Label();
            associatedPartsLabel = new Label();
            addCandidatePartButton = new Button();
            deleteAssociatedPartButton = new Button();
            saveButton = new Button();
            cancelButton = new Button();
            searchButton = new Button();
            searchTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)allCandidatePartsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)associatedPartsDGV).BeginInit();
            SuspendLayout();
            // 
            // addProductLabel
            // 
            addProductLabel.AutoSize = true;
            addProductLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addProductLabel.Location = new Point(27, 30);
            addProductLabel.Name = "addProductLabel";
            addProductLabel.Size = new Size(135, 30);
            addProductLabel.TabIndex = 0;
            addProductLabel.Text = "Add Product";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDLabel.Location = new Point(27, 198);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(25, 21);
            IDLabel.TabIndex = 1;
            IDLabel.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 243);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // inStockLabel
            // 
            inStockLabel.AutoSize = true;
            inStockLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inStockLabel.Location = new Point(27, 289);
            inStockLabel.Name = "inStockLabel";
            inStockLabel.Size = new Size(64, 21);
            inStockLabel.TabIndex = 3;
            inStockLabel.Text = "In Stock";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(27, 338);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(44, 21);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Price";
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maxLabel.Location = new Point(27, 386);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(39, 21);
            maxLabel.TabIndex = 5;
            maxLabel.Text = "Max";
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            minLabel.Location = new Point(209, 386);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(37, 21);
            minLabel.TabIndex = 6;
            minLabel.Text = "Min";
            // 
            // IDTextBox
            // 
            IDTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDTextBox.Location = new Point(147, 195);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(187, 29);
            IDTextBox.TabIndex = 7;
            // 
            // productNameTextBox
            // 
            productNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productNameTextBox.Location = new Point(147, 240);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(187, 29);
            productNameTextBox.TabIndex = 8;
            // 
            // inStockTextBox
            // 
            inStockTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inStockTextBox.Location = new Point(147, 286);
            inStockTextBox.Name = "inStockTextBox";
            inStockTextBox.Size = new Size(187, 29);
            inStockTextBox.TabIndex = 9;
            // 
            // priceTextBox
            // 
            priceTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceTextBox.Location = new Point(147, 335);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(187, 29);
            priceTextBox.TabIndex = 10;
            // 
            // minTextBox
            // 
            minTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            minTextBox.Location = new Point(252, 383);
            minTextBox.Name = "minTextBox";
            minTextBox.Size = new Size(103, 29);
            minTextBox.TabIndex = 11;
            // 
            // maxTextBox
            // 
            maxTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maxTextBox.Location = new Point(85, 383);
            maxTextBox.Name = "maxTextBox";
            maxTextBox.Size = new Size(103, 29);
            maxTextBox.TabIndex = 12;
            // 
            // allCandidatePartsDGV
            // 
            allCandidatePartsDGV.AllowUserToAddRows = false;
            allCandidatePartsDGV.AllowUserToDeleteRows = false;
            allCandidatePartsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allCandidatePartsDGV.Location = new Point(423, 90);
            allCandidatePartsDGV.Name = "allCandidatePartsDGV";
            allCandidatePartsDGV.ReadOnly = true;
            allCandidatePartsDGV.RowTemplate.Height = 25;
            allCandidatePartsDGV.Size = new Size(441, 189);
            allCandidatePartsDGV.TabIndex = 13;
            // 
            // associatedPartsDGV
            // 
            associatedPartsDGV.AllowUserToAddRows = false;
            associatedPartsDGV.AllowUserToDeleteRows = false;
            associatedPartsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            associatedPartsDGV.Location = new Point(423, 335);
            associatedPartsDGV.Name = "associatedPartsDGV";
            associatedPartsDGV.ReadOnly = true;
            associatedPartsDGV.RowTemplate.Height = 25;
            associatedPartsDGV.Size = new Size(441, 171);
            associatedPartsDGV.TabIndex = 14;
            // 
            // candidatePartsLabel
            // 
            candidatePartsLabel.AutoSize = true;
            candidatePartsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            candidatePartsLabel.Location = new Point(423, 66);
            candidatePartsLabel.Name = "candidatePartsLabel";
            candidatePartsLabel.Size = new Size(137, 21);
            candidatePartsLabel.TabIndex = 15;
            candidatePartsLabel.Text = "All candidate Parts";
            // 
            // associatedPartsLabel
            // 
            associatedPartsLabel.AutoSize = true;
            associatedPartsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            associatedPartsLabel.Location = new Point(423, 311);
            associatedPartsLabel.Name = "associatedPartsLabel";
            associatedPartsLabel.Size = new Size(240, 21);
            associatedPartsLabel.TabIndex = 16;
            associatedPartsLabel.Text = "Parts Associated with the Product";
            // 
            // addCandidatePartButton
            // 
            addCandidatePartButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            addCandidatePartButton.Location = new Point(782, 285);
            addCandidatePartButton.Name = "addCandidatePartButton";
            addCandidatePartButton.Size = new Size(64, 27);
            addCandidatePartButton.TabIndex = 17;
            addCandidatePartButton.Text = "Add";
            addCandidatePartButton.UseVisualStyleBackColor = true;
            addCandidatePartButton.Click += addCandidatePartButton_Click;
            // 
            // deleteAssociatedPartButton
            // 
            deleteAssociatedPartButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteAssociatedPartButton.Location = new Point(782, 512);
            deleteAssociatedPartButton.Name = "deleteAssociatedPartButton";
            deleteAssociatedPartButton.Size = new Size(64, 27);
            deleteAssociatedPartButton.TabIndex = 18;
            deleteAssociatedPartButton.Text = "Delete";
            deleteAssociatedPartButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(712, 545);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(64, 27);
            saveButton.TabIndex = 19;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(782, 545);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(64, 27);
            cancelButton.TabIndex = 20;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.Location = new Point(599, 60);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(64, 27);
            searchButton.TabIndex = 21;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(669, 60);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(195, 27);
            searchTextBox.TabIndex = 22;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 584);
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
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AddProductForm";
            Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)allCandidatePartsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)associatedPartsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addProductLabel;
        private Label IDLabel;
        private Label label2;
        private Label inStockLabel;
        private Label priceLabel;
        private Label maxLabel;
        private Label minLabel;
        private TextBox IDTextBox;
        private TextBox productNameTextBox;
        private TextBox inStockTextBox;
        private TextBox priceTextBox;
        private TextBox minTextBox;
        private TextBox maxTextBox;
        private DataGridView allCandidatePartsDGV;
        private DataGridView associatedPartsDGV;
        private Label candidatePartsLabel;
        private Label associatedPartsLabel;
        private Button addCandidatePartButton;
        private Button deleteAssociatedPartButton;
        private Button saveButton;
        private Button cancelButton;
        private Button searchButton;
        private TextBox searchTextBox;
    }
}