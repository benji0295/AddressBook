namespace AddressBook
{
    partial class SearchForm
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
            this.nameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(181, 85);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(285, 31);
            this.nameText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(112, 176);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(137, 64);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(281, 176);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(137, 64);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 252);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameText);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cancelButton;
    }
}