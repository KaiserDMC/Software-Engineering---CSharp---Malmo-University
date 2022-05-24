namespace Assignment4
{
    partial class FormIngredients
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
            this.lblIngredietns = new System.Windows.Forms.Label();
            this.lblMaxNumber = new System.Windows.Forms.Label();
            this.grboxIngredient = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstIngredient = new System.Windows.Forms.ListBox();
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSaveChngIngredient = new System.Windows.Forms.Button();
            this.grboxIngredient.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIngredietns
            // 
            this.lblIngredietns.AutoSize = true;
            this.lblIngredietns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredietns.Location = new System.Drawing.Point(12, 9);
            this.lblIngredietns.Name = "lblIngredietns";
            this.lblIngredietns.Size = new System.Drawing.Size(119, 16);
            this.lblIngredietns.TabIndex = 0;
            this.lblIngredietns.Text = "Num of ingredients";
            // 
            // lblMaxNumber
            // 
            this.lblMaxNumber.AutoSize = true;
            this.lblMaxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxNumber.Location = new System.Drawing.Point(442, 9);
            this.lblMaxNumber.Name = "lblMaxNumber";
            this.lblMaxNumber.Size = new System.Drawing.Size(40, 16);
            this.lblMaxNumber.TabIndex = 1;
            this.lblMaxNumber.Text = "result";
            // 
            // grboxIngredient
            // 
            this.grboxIngredient.Controls.Add(this.btnDelete);
            this.grboxIngredient.Controls.Add(this.btnEdit);
            this.grboxIngredient.Controls.Add(this.btnAdd);
            this.grboxIngredient.Controls.Add(this.lstIngredient);
            this.grboxIngredient.Controls.Add(this.txtIngredient);
            this.grboxIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxIngredient.Location = new System.Drawing.Point(15, 44);
            this.grboxIngredient.Name = "grboxIngredient";
            this.grboxIngredient.Size = new System.Drawing.Size(523, 364);
            this.grboxIngredient.TabIndex = 2;
            this.grboxIngredient.TabStop = false;
            this.grboxIngredient.Text = "Ingredient";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(430, 150);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(430, 104);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(430, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstIngredient
            // 
            this.lstIngredient.FormattingEnabled = true;
            this.lstIngredient.ItemHeight = 16;
            this.lstIngredient.Location = new System.Drawing.Point(7, 51);
            this.lstIngredient.Name = "lstIngredient";
            this.lstIngredient.Size = new System.Drawing.Size(408, 292);
            this.lstIngredient.TabIndex = 1;
            // 
            // txtIngredient
            // 
            this.txtIngredient.Location = new System.Drawing.Point(7, 22);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(408, 22);
            this.txtIngredient.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(22, 422);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 34);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(397, 422);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSaveChngIngredient
            // 
            this.btnSaveChngIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChngIngredient.Location = new System.Drawing.Point(209, 422);
            this.btnSaveChngIngredient.Name = "btnSaveChngIngredient";
            this.btnSaveChngIngredient.Size = new System.Drawing.Size(119, 34);
            this.btnSaveChngIngredient.TabIndex = 5;
            this.btnSaveChngIngredient.Text = "Confirm Edit";
            this.btnSaveChngIngredient.UseVisualStyleBackColor = true;
            this.btnSaveChngIngredient.Click += new System.EventHandler(this.btnSaveChngIngredient_Click);
            // 
            // FormIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 486);
            this.Controls.Add(this.btnSaveChngIngredient);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grboxIngredient);
            this.Controls.Add(this.lblMaxNumber);
            this.Controls.Add(this.lblIngredietns);
            this.Name = "FormIngredients";
            this.Text = "FormIngredients";
            this.grboxIngredient.ResumeLayout(false);
            this.grboxIngredient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngredietns;
        private System.Windows.Forms.Label lblMaxNumber;
        private System.Windows.Forms.GroupBox grboxIngredient;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstIngredient;
        private System.Windows.Forms.TextBox txtIngredient;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSaveChngIngredient;
    }
}