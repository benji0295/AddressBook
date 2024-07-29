namespace AddressBook
{
    partial class AddForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.cellPhoneText = new System.Windows.Forms.TextBox();
            this.workPhoneText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(93, 387);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(126, 73);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(265, 387);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(126, 73);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(213, 46);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(234, 31);
            this.firstNameText.TabIndex = 2;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(213, 110);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(234, 31);
            this.lastNameText.TabIndex = 3;
            // 
            // cellPhoneText
            // 
            this.cellPhoneText.Location = new System.Drawing.Point(213, 175);
            this.cellPhoneText.Name = "cellPhoneText";
            this.cellPhoneText.Size = new System.Drawing.Size(234, 31);
            this.cellPhoneText.TabIndex = 4;
            // 
            // workPhoneText
            // 
            this.workPhoneText.Location = new System.Drawing.Point(213, 247);
            this.workPhoneText.Name = "workPhoneText";
            this.workPhoneText.Size = new System.Drawing.Size(234, 31);
            this.workPhoneText.TabIndex = 5;
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(213, 319);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(234, 31);
            this.addressText.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cell Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Work Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 495);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.workPhoneText);
            this.Controls.Add(this.cellPhoneText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox cellPhoneText;
        private System.Windows.Forms.TextBox workPhoneText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}