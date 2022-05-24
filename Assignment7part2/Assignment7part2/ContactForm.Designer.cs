
namespace Assignment7part2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.txtWorkPhone = new System.Windows.Forms.TextBox();
            this.txtPrivateEmail = new System.Windows.Forms.TextBox();
            this.txtWorkEmail = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.lblWorkPhone = new System.Windows.Forms.Label();
            this.lblPrivateEmail = new System.Windows.Forms.Label();
            this.lblWorkEmail = new System.Windows.Forms.Label();
            this.btnContactOK = new System.Windows.Forms.Button();
            this.btnContactCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(153, 16);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(209, 22);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(153, 63);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(209, 22);
            this.txtLastName.TabIndex = 1;
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(153, 111);
            this.txtHomePhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(209, 22);
            this.txtHomePhone.TabIndex = 2;
            // 
            // txtWorkPhone
            // 
            this.txtWorkPhone.Location = new System.Drawing.Point(153, 158);
            this.txtWorkPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtWorkPhone.Name = "txtWorkPhone";
            this.txtWorkPhone.Size = new System.Drawing.Size(209, 22);
            this.txtWorkPhone.TabIndex = 3;
            // 
            // txtPrivateEmail
            // 
            this.txtPrivateEmail.Location = new System.Drawing.Point(153, 206);
            this.txtPrivateEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrivateEmail.Name = "txtPrivateEmail";
            this.txtPrivateEmail.Size = new System.Drawing.Size(209, 22);
            this.txtPrivateEmail.TabIndex = 4;
            // 
            // txtWorkEmail
            // 
            this.txtWorkEmail.Location = new System.Drawing.Point(153, 254);
            this.txtWorkEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtWorkEmail.Name = "txtWorkEmail";
            this.txtWorkEmail.Size = new System.Drawing.Size(209, 22);
            this.txtWorkEmail.TabIndex = 5;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 16);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 16);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(13, 63);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 16);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(13, 111);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(87, 16);
            this.lblHomePhone.TabIndex = 8;
            this.lblHomePhone.Text = "Home Phone";
            // 
            // lblWorkPhone
            // 
            this.lblWorkPhone.AutoSize = true;
            this.lblWorkPhone.Location = new System.Drawing.Point(13, 158);
            this.lblWorkPhone.Name = "lblWorkPhone";
            this.lblWorkPhone.Size = new System.Drawing.Size(82, 16);
            this.lblWorkPhone.TabIndex = 9;
            this.lblWorkPhone.Text = "Work Phone";
            // 
            // lblPrivateEmail
            // 
            this.lblPrivateEmail.AutoSize = true;
            this.lblPrivateEmail.Location = new System.Drawing.Point(13, 206);
            this.lblPrivateEmail.Name = "lblPrivateEmail";
            this.lblPrivateEmail.Size = new System.Drawing.Size(91, 16);
            this.lblPrivateEmail.TabIndex = 10;
            this.lblPrivateEmail.Text = "Private E-mail";
            // 
            // lblWorkEmail
            // 
            this.lblWorkEmail.AutoSize = true;
            this.lblWorkEmail.Location = new System.Drawing.Point(13, 254);
            this.lblWorkEmail.Name = "lblWorkEmail";
            this.lblWorkEmail.Size = new System.Drawing.Size(81, 16);
            this.lblWorkEmail.TabIndex = 11;
            this.lblWorkEmail.Text = "Work E-mail";
            // 
            // btnContactOK
            // 
            this.btnContactOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnContactOK.Location = new System.Drawing.Point(87, 304);
            this.btnContactOK.Name = "btnContactOK";
            this.btnContactOK.Size = new System.Drawing.Size(75, 23);
            this.btnContactOK.TabIndex = 12;
            this.btnContactOK.Text = "OK";
            this.btnContactOK.UseVisualStyleBackColor = true;
            this.btnContactOK.Click += new System.EventHandler(this.btnContactOK_Click);
            // 
            // btnContactCancel
            // 
            this.btnContactCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnContactCancel.Location = new System.Drawing.Point(242, 304);
            this.btnContactCancel.Name = "btnContactCancel";
            this.btnContactCancel.Size = new System.Drawing.Size(75, 23);
            this.btnContactCancel.TabIndex = 13;
            this.btnContactCancel.Text = "Cancel";
            this.btnContactCancel.UseVisualStyleBackColor = true;
            this.btnContactCancel.Click += new System.EventHandler(this.btnContactCancel_Click);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 351);
            this.Controls.Add(this.btnContactCancel);
            this.Controls.Add(this.btnContactOK);
            this.Controls.Add(this.lblWorkEmail);
            this.Controls.Add(this.lblPrivateEmail);
            this.Controls.Add(this.lblWorkPhone);
            this.Controls.Add(this.lblHomePhone);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtWorkEmail);
            this.Controls.Add(this.txtPrivateEmail);
            this.Controls.Add(this.txtWorkPhone);
            this.Controls.Add(this.txtHomePhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContactForm";
            this.Text = "ContactForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactForm_FormClosing_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.TextBox txtWorkPhone;
        private System.Windows.Forms.TextBox txtPrivateEmail;
        private System.Windows.Forms.TextBox txtWorkEmail;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.Label lblWorkPhone;
        private System.Windows.Forms.Label lblPrivateEmail;
        private System.Windows.Forms.Label lblWorkEmail;
        private System.Windows.Forms.Button btnContactOK;
        private System.Windows.Forms.Button btnContactCancel;
    }
}