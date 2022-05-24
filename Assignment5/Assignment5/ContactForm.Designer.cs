
namespace Assignment5
{
    partial class ContactForm
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
            this.grbName = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grbEmailPhone = new System.Windows.Forms.GroupBox();
            this.lblPrivateEmail = new System.Windows.Forms.Label();
            this.lblWorkEmail = new System.Windows.Forms.Label();
            this.lblOtherPhone = new System.Windows.Forms.Label();
            this.lblWorkPhone = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.txtPrivateEmail = new System.Windows.Forms.TextBox();
            this.txtWorkEmail = new System.Windows.Forms.TextBox();
            this.txtOtherPhone = new System.Windows.Forms.TextBox();
            this.txtWorkPhone = new System.Windows.Forms.TextBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.grbAddress = new System.Windows.Forms.GroupBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.btnCFormOK = new System.Windows.Forms.Button();
            this.btnCFormCancel = new System.Windows.Forms.Button();
            this.grbName.SuspendLayout();
            this.grbEmailPhone.SuspendLayout();
            this.grbAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbName
            // 
            this.grbName.Controls.Add(this.txtLastName);
            this.grbName.Controls.Add(this.txtFirstName);
            this.grbName.Controls.Add(this.lblLastName);
            this.grbName.Controls.Add(this.lblFirstName);
            this.grbName.Location = new System.Drawing.Point(14, 12);
            this.grbName.Margin = new System.Windows.Forms.Padding(4);
            this.grbName.Name = "grbName";
            this.grbName.Padding = new System.Windows.Forms.Padding(4);
            this.grbName.Size = new System.Drawing.Size(460, 103);
            this.grbName.TabIndex = 0;
            this.grbName.TabStop = false;
            this.grbName.Text = "Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(169, 69);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(280, 21);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(169, 19);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(280, 21);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(10, 69);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(67, 15);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(10, 19);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(67, 15);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // grbEmailPhone
            // 
            this.grbEmailPhone.Controls.Add(this.lblPrivateEmail);
            this.grbEmailPhone.Controls.Add(this.lblWorkEmail);
            this.grbEmailPhone.Controls.Add(this.lblOtherPhone);
            this.grbEmailPhone.Controls.Add(this.lblWorkPhone);
            this.grbEmailPhone.Controls.Add(this.lblHomePhone);
            this.grbEmailPhone.Controls.Add(this.txtPrivateEmail);
            this.grbEmailPhone.Controls.Add(this.txtWorkEmail);
            this.grbEmailPhone.Controls.Add(this.txtOtherPhone);
            this.grbEmailPhone.Controls.Add(this.txtWorkPhone);
            this.grbEmailPhone.Controls.Add(this.txtHomePhone);
            this.grbEmailPhone.Location = new System.Drawing.Point(14, 123);
            this.grbEmailPhone.Margin = new System.Windows.Forms.Padding(4);
            this.grbEmailPhone.Name = "grbEmailPhone";
            this.grbEmailPhone.Padding = new System.Windows.Forms.Padding(4);
            this.grbEmailPhone.Size = new System.Drawing.Size(460, 240);
            this.grbEmailPhone.TabIndex = 1;
            this.grbEmailPhone.TabStop = false;
            this.grbEmailPhone.Text = "Email and Phones";
            // 
            // lblPrivateEmail
            // 
            this.lblPrivateEmail.AutoSize = true;
            this.lblPrivateEmail.Location = new System.Drawing.Point(13, 203);
            this.lblPrivateEmail.Name = "lblPrivateEmail";
            this.lblPrivateEmail.Size = new System.Drawing.Size(85, 15);
            this.lblPrivateEmail.TabIndex = 9;
            this.lblPrivateEmail.Text = "E-Mail, private";
            // 
            // lblWorkEmail
            // 
            this.lblWorkEmail.AutoSize = true;
            this.lblWorkEmail.Location = new System.Drawing.Point(12, 154);
            this.lblWorkEmail.Name = "lblWorkEmail";
            this.lblWorkEmail.Size = new System.Drawing.Size(98, 15);
            this.lblWorkEmail.TabIndex = 8;
            this.lblWorkEmail.Text = "E-Mail, business";
            // 
            // lblOtherPhone
            // 
            this.lblOtherPhone.AutoSize = true;
            this.lblOtherPhone.Location = new System.Drawing.Point(12, 106);
            this.lblOtherPhone.Name = "lblOtherPhone";
            this.lblOtherPhone.Size = new System.Drawing.Size(76, 15);
            this.lblOtherPhone.TabIndex = 7;
            this.lblOtherPhone.Text = "Other Phone";
            // 
            // lblWorkPhone
            // 
            this.lblWorkPhone.AutoSize = true;
            this.lblWorkPhone.Location = new System.Drawing.Point(13, 65);
            this.lblWorkPhone.Name = "lblWorkPhone";
            this.lblWorkPhone.Size = new System.Drawing.Size(74, 15);
            this.lblWorkPhone.TabIndex = 6;
            this.lblWorkPhone.Text = "Work Phone";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(10, 23);
            this.lblHomePhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(80, 15);
            this.lblHomePhone.TabIndex = 5;
            this.lblHomePhone.Text = "Home Phone";
            // 
            // txtPrivateEmail
            // 
            this.txtPrivateEmail.Location = new System.Drawing.Point(168, 203);
            this.txtPrivateEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrivateEmail.Name = "txtPrivateEmail";
            this.txtPrivateEmail.Size = new System.Drawing.Size(281, 21);
            this.txtPrivateEmail.TabIndex = 4;
            // 
            // txtWorkEmail
            // 
            this.txtWorkEmail.Location = new System.Drawing.Point(168, 154);
            this.txtWorkEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtWorkEmail.Name = "txtWorkEmail";
            this.txtWorkEmail.Size = new System.Drawing.Size(281, 21);
            this.txtWorkEmail.TabIndex = 3;
            // 
            // txtOtherPhone
            // 
            this.txtOtherPhone.Location = new System.Drawing.Point(168, 106);
            this.txtOtherPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtOtherPhone.Name = "txtOtherPhone";
            this.txtOtherPhone.Size = new System.Drawing.Size(281, 21);
            this.txtOtherPhone.TabIndex = 2;
            // 
            // txtWorkPhone
            // 
            this.txtWorkPhone.Location = new System.Drawing.Point(168, 65);
            this.txtWorkPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtWorkPhone.Name = "txtWorkPhone";
            this.txtWorkPhone.Size = new System.Drawing.Size(281, 21);
            this.txtWorkPhone.TabIndex = 1;
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(168, 23);
            this.txtHomePhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(281, 21);
            this.txtHomePhone.TabIndex = 0;
            // 
            // grbAddress
            // 
            this.grbAddress.Controls.Add(this.lblCountry);
            this.grbAddress.Controls.Add(this.lblZipCode);
            this.grbAddress.Controls.Add(this.lblCity);
            this.grbAddress.Controls.Add(this.lblStreet);
            this.grbAddress.Controls.Add(this.cmbCountry);
            this.grbAddress.Controls.Add(this.txtZipCode);
            this.grbAddress.Controls.Add(this.txtCity);
            this.grbAddress.Controls.Add(this.txtStreet);
            this.grbAddress.Location = new System.Drawing.Point(14, 379);
            this.grbAddress.Name = "grbAddress";
            this.grbAddress.Size = new System.Drawing.Size(460, 160);
            this.grbAddress.TabIndex = 2;
            this.grbAddress.TabStop = false;
            this.grbAddress.Text = "Address";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(10, 128);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(48, 15);
            this.lblCountry.TabIndex = 7;
            this.lblCountry.Text = "Country";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(13, 93);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(56, 15);
            this.lblZipCode.TabIndex = 6;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(10, 59);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(26, 15);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "City";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(10, 21);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(39, 15);
            this.lblStreet.TabIndex = 4;
            this.lblStreet.Text = "Street";
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(165, 128);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(282, 23);
            this.cmbCountry.TabIndex = 3;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(166, 93);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(281, 21);
            this.txtZipCode.TabIndex = 2;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(165, 59);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(282, 21);
            this.txtCity.TabIndex = 1;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(166, 21);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(281, 21);
            this.txtStreet.TabIndex = 0;
            // 
            // btnCFormOK
            // 
            this.btnCFormOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCFormOK.Location = new System.Drawing.Point(125, 566);
            this.btnCFormOK.Name = "btnCFormOK";
            this.btnCFormOK.Size = new System.Drawing.Size(75, 23);
            this.btnCFormOK.TabIndex = 3;
            this.btnCFormOK.Text = "OK";
            this.btnCFormOK.UseVisualStyleBackColor = true;
            this.btnCFormOK.Click += new System.EventHandler(this.btnCFormOK_Click);
            // 
            // btnCFormCancel
            // 
            this.btnCFormCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCFormCancel.Location = new System.Drawing.Point(250, 566);
            this.btnCFormCancel.Name = "btnCFormCancel";
            this.btnCFormCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCFormCancel.TabIndex = 4;
            this.btnCFormCancel.Text = "Cancel";
            this.btnCFormCancel.UseVisualStyleBackColor = true;
            this.btnCFormCancel.Click += new System.EventHandler(this.btnCFormCancel_Click);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 601);
            this.Controls.Add(this.btnCFormCancel);
            this.Controls.Add(this.btnCFormOK);
            this.Controls.Add(this.grbAddress);
            this.Controls.Add(this.grbEmailPhone);
            this.Controls.Add(this.grbName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContactForm";
            this.Text = "Register contact data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactForm_FormClosing);
            this.grbName.ResumeLayout(false);
            this.grbName.PerformLayout();
            this.grbEmailPhone.ResumeLayout(false);
            this.grbEmailPhone.PerformLayout();
            this.grbAddress.ResumeLayout(false);
            this.grbAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox grbEmailPhone;
        private System.Windows.Forms.Label lblPrivateEmail;
        private System.Windows.Forms.Label lblWorkEmail;
        private System.Windows.Forms.Label lblOtherPhone;
        private System.Windows.Forms.Label lblWorkPhone;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.TextBox txtPrivateEmail;
        private System.Windows.Forms.TextBox txtWorkEmail;
        private System.Windows.Forms.TextBox txtOtherPhone;
        private System.Windows.Forms.TextBox txtWorkPhone;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.GroupBox grbAddress;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Button btnCFormOK;
        private System.Windows.Forms.Button btnCFormCancel;
    }
}