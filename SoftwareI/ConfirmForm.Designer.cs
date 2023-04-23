namespace SoftwareI
{
    partial class ConfirmForm
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
            disclaimerTextBox = new Label();
            yesButton = new Button();
            noButton = new Button();
            SuspendLayout();
            // 
            // disclaimerTextBox
            // 
            disclaimerTextBox.AutoSize = true;
            disclaimerTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            disclaimerTextBox.Location = new Point(9, 44);
            disclaimerTextBox.Name = "disclaimerTextBox";
            disclaimerTextBox.Size = new Size(253, 17);
            disclaimerTextBox.TabIndex = 0;
            disclaimerTextBox.Text = "Are you sure you want to delete this item?";
            // 
            // yesButton
            // 
            yesButton.Location = new Point(47, 87);
            yesButton.Name = "yesButton";
            yesButton.Size = new Size(75, 23);
            yesButton.TabIndex = 1;
            yesButton.Text = "Yes";
            yesButton.UseVisualStyleBackColor = true;
            yesButton.Click += yesButton_Click_1;
            // 
            // noButton
            // 
            noButton.Location = new Point(151, 87);
            noButton.Name = "noButton";
            noButton.Size = new Size(75, 23);
            noButton.TabIndex = 2;
            noButton.Text = "No";
            noButton.UseVisualStyleBackColor = true;
            noButton.Click += noButton_Click_1;
            // 
            // ConfirmForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 159);
            Controls.Add(noButton);
            Controls.Add(yesButton);
            Controls.Add(disclaimerTextBox);
            Name = "ConfirmForm";
            Text = "Confirm Deletion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label disclaimerTextBox;
        private Button yesButton;
        private Button noButton;
    }
}