namespace SoftwareI
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            titleLabel = new Label();
            allPartsLabel = new Label();
            allProductsLabel = new Label();
            addPartButton = new Button();
            addProductButton = new Button();
            deleteProductButton = new Button();
            deletePartButton = new Button();
            updateProductButton = new Button();
            updatePartButton = new Button();
            searchPartButton = new Button();
            searchProductButton = new Button();
            partSearchTextBox = new TextBox();
            productSearchTextBox = new TextBox();
            allPartsDataGridView = new DataGridView();
            allProductsDataGridView = new DataGridView();
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)allPartsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allProductsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(23, 26);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(320, 30);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Inventory Management System";
            // 
            // allPartsLabel
            // 
            allPartsLabel.AutoSize = true;
            allPartsLabel.Location = new Point(28, 105);
            allPartsLabel.Name = "allPartsLabel";
            allPartsLabel.Size = new Size(88, 30);
            allPartsLabel.TabIndex = 1;
            allPartsLabel.Text = "All Parts";
            // 
            // allProductsLabel
            // 
            allProductsLabel.AutoSize = true;
            allProductsLabel.Location = new Point(435, 105);
            allProductsLabel.Name = "allProductsLabel";
            allProductsLabel.Size = new Size(124, 30);
            allProductsLabel.TabIndex = 2;
            allProductsLabel.Text = "All Products";
            // 
            // addPartButton
            // 
            addPartButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            addPartButton.Location = new Point(23, 391);
            addPartButton.Name = "addPartButton";
            addPartButton.Size = new Size(111, 36);
            addPartButton.TabIndex = 3;
            addPartButton.Text = "Add Part";
            addPartButton.UseVisualStyleBackColor = true;
            addPartButton.Click += addPartButton_Click;
            // 
            // addProductButton
            // 
            addProductButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            addProductButton.Location = new Point(435, 391);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(111, 36);
            addProductButton.TabIndex = 4;
            addProductButton.Text = "Add Product";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click;
            // 
            // deleteProductButton
            // 
            deleteProductButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteProductButton.Location = new Point(583, 391);
            deleteProductButton.Name = "deleteProductButton";
            deleteProductButton.Size = new Size(111, 36);
            deleteProductButton.TabIndex = 5;
            deleteProductButton.Text = "Delete Product";
            deleteProductButton.UseVisualStyleBackColor = true;
            // 
            // deletePartButton
            // 
            deletePartButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            deletePartButton.Location = new Point(164, 391);
            deletePartButton.Name = "deletePartButton";
            deletePartButton.Size = new Size(111, 36);
            deletePartButton.TabIndex = 6;
            deletePartButton.Text = "Delete Part";
            deletePartButton.UseVisualStyleBackColor = true;
            // 
            // updateProductButton
            // 
            updateProductButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            updateProductButton.Location = new Point(721, 391);
            updateProductButton.Name = "updateProductButton";
            updateProductButton.Size = new Size(111, 36);
            updateProductButton.TabIndex = 7;
            updateProductButton.Text = "Update Product";
            updateProductButton.UseVisualStyleBackColor = true;
            // 
            // updatePartButton
            // 
            updatePartButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            updatePartButton.Location = new Point(292, 391);
            updatePartButton.Name = "updatePartButton";
            updatePartButton.Size = new Size(111, 36);
            updatePartButton.TabIndex = 8;
            updatePartButton.Text = "Update Part";
            updatePartButton.UseVisualStyleBackColor = true;
            // 
            // searchPartButton
            // 
            searchPartButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchPartButton.Location = new Point(155, 112);
            searchPartButton.Name = "searchPartButton";
            searchPartButton.Size = new Size(75, 23);
            searchPartButton.TabIndex = 9;
            searchPartButton.Text = "Search";
            searchPartButton.UseVisualStyleBackColor = true;
            // 
            // searchProductButton
            // 
            searchProductButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchProductButton.Location = new Point(561, 111);
            searchProductButton.Name = "searchProductButton";
            searchProductButton.Size = new Size(75, 23);
            searchProductButton.TabIndex = 10;
            searchProductButton.Text = "Search";
            searchProductButton.UseVisualStyleBackColor = true;
            // 
            // partSearchTextBox
            // 
            partSearchTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            partSearchTextBox.Location = new Point(236, 112);
            partSearchTextBox.Name = "partSearchTextBox";
            partSearchTextBox.Size = new Size(147, 25);
            partSearchTextBox.TabIndex = 11;
            // 
            // productSearchTextBox
            // 
            productSearchTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            productSearchTextBox.Location = new Point(642, 112);
            productSearchTextBox.Name = "productSearchTextBox";
            productSearchTextBox.Size = new Size(147, 25);
            productSearchTextBox.TabIndex = 12;
            // 
            // allPartsDataGridView
            // 
            allPartsDataGridView.AllowUserToAddRows = false;
            allPartsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            allPartsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            allPartsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            allPartsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            allPartsDataGridView.Location = new Point(13, 143);
            allPartsDataGridView.Name = "allPartsDataGridView";
            allPartsDataGridView.ReadOnly = true;
            allPartsDataGridView.RowHeadersWidth = 20;
            allPartsDataGridView.RowTemplate.Height = 25;
            allPartsDataGridView.Size = new Size(403, 242);
            allPartsDataGridView.TabIndex = 13;
            // 
            // allProductsDataGridView
            // 
            allProductsDataGridView.AllowUserToAddRows = false;
            allProductsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            allProductsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            allProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            allProductsDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            allProductsDataGridView.Location = new Point(435, 143);
            allProductsDataGridView.Name = "allProductsDataGridView";
            allProductsDataGridView.ReadOnly = true;
            allProductsDataGridView.RowHeadersWidth = 20;
            allProductsDataGridView.RowTemplate.Height = 25;
            allProductsDataGridView.Size = new Size(405, 242);
            allProductsDataGridView.TabIndex = 14;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ExitButton.Location = new Point(743, 436);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 15;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 471);
            Controls.Add(ExitButton);
            Controls.Add(allProductsDataGridView);
            Controls.Add(allPartsDataGridView);
            Controls.Add(productSearchTextBox);
            Controls.Add(partSearchTextBox);
            Controls.Add(searchProductButton);
            Controls.Add(searchPartButton);
            Controls.Add(updatePartButton);
            Controls.Add(updateProductButton);
            Controls.Add(deletePartButton);
            Controls.Add(deleteProductButton);
            Controls.Add(addProductButton);
            Controls.Add(addPartButton);
            Controls.Add(allProductsLabel);
            Controls.Add(allPartsLabel);
            Controls.Add(titleLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)allPartsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)allProductsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label allPartsLabel;
        private Label allProductsLabel;
        private Button addPartButton;
        private Button addProductButton;
        private Button deleteProductButton;
        private Button deletePartButton;
        private Button updateProductButton;
        private Button updatePartButton;
        private Button searchPartButton;
        private Button searchProductButton;
        private TextBox partSearchTextBox;
        private TextBox productSearchTextBox;
        private DataGridView allPartsDataGridView;
        private DataGridView allProductsDataGridView;
        private Button ExitButton;
    }
}