
namespace Assignment7part2
{
    partial class CustomerRegistryForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRegistryForm));
            this.lstCustomerRegistry = new System.Windows.Forms.ListBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnChangeCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.btnSaveCustomerRegistry = new System.Windows.Forms.Button();
            this.toolTipCustomer = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lstCustomerRegistry
            // 
            this.lstCustomerRegistry.FormattingEnabled = true;
            this.lstCustomerRegistry.ItemHeight = 16;
            this.lstCustomerRegistry.Location = new System.Drawing.Point(16, 37);
            this.lstCustomerRegistry.Margin = new System.Windows.Forms.Padding(4);
            this.lstCustomerRegistry.Name = "lstCustomerRegistry";
            this.lstCustomerRegistry.Size = new System.Drawing.Size(1033, 420);
            this.lstCustomerRegistry.TabIndex = 0;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(270, 476);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(111, 42);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnChangeCustomer
            // 
            this.btnChangeCustomer.Location = new System.Drawing.Point(477, 476);
            this.btnChangeCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeCustomer.Name = "btnChangeCustomer";
            this.btnChangeCustomer.Size = new System.Drawing.Size(111, 42);
            this.btnChangeCustomer.TabIndex = 2;
            this.btnChangeCustomer.Text = "Change";
            this.btnChangeCustomer.UseVisualStyleBackColor = true;
            this.btnChangeCustomer.Click += new System.EventHandler(this.btnChangeCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(687, 476);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(111, 42);
            this.btnDeleteCustomer.TabIndex = 3;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(22, 17);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(45, 16);
            this.lblCustomerID.TabIndex = 4;
            this.lblCustomerID.Text = "label1";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(73, 17);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(45, 16);
            this.lblCustomerName.TabIndex = 5;
            this.lblCustomerName.Text = "label1";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Location = new System.Drawing.Point(267, 17);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(45, 16);
            this.lblCustomerPhone.TabIndex = 6;
            this.lblCustomerPhone.Text = "label1";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Location = new System.Drawing.Point(486, 17);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(45, 16);
            this.lblCustomerEmail.TabIndex = 7;
            this.lblCustomerEmail.Text = "label1";
            // 
            // btnSaveCustomerRegistry
            // 
            this.btnSaveCustomerRegistry.Location = new System.Drawing.Point(25, 493);
            this.btnSaveCustomerRegistry.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveCustomerRegistry.Name = "btnSaveCustomerRegistry";
            this.btnSaveCustomerRegistry.Size = new System.Drawing.Size(91, 25);
            this.btnSaveCustomerRegistry.TabIndex = 21;
            this.btnSaveCustomerRegistry.Text = "Save";
            this.btnSaveCustomerRegistry.UseVisualStyleBackColor = true;
            this.btnSaveCustomerRegistry.Click += new System.EventHandler(this.btnSaveCustomerRegistry_Click);
            // 
            // CustomerRegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSaveCustomerRegistry);
            this.Controls.Add(this.lblCustomerEmail);
            this.Controls.Add(this.lblCustomerPhone);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnChangeCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lstCustomerRegistry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerRegistryForm";
            this.Text = "CustomerRegistryForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerRegistryForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomerRegistry;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnChangeCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Button btnSaveCustomerRegistry;
        private System.Windows.Forms.ToolTip toolTipCustomer;
    }
}