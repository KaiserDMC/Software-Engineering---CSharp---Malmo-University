
namespace Assignment7part2
{
    partial class MusicForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicForm));
            this.dateTimePickerMusicDate = new System.Windows.Forms.DateTimePicker();
            this.lblMusicDate = new System.Windows.Forms.Label();
            this.cmbMusicRecordType = new System.Windows.Forms.ComboBox();
            this.btnMusicCancel = new System.Windows.Forms.Button();
            this.btnMusicOK = new System.Windows.Forms.Button();
            this.lblMusicRecordType = new System.Windows.Forms.Label();
            this.lblRecordLabel = new System.Windows.Forms.Label();
            this.lblAlbumnName = new System.Windows.Forms.Label();
            this.lblBandName = new System.Windows.Forms.Label();
            this.txtRecordLabelName = new System.Windows.Forms.TextBox();
            this.txtAlbumnName = new System.Windows.Forms.TextBox();
            this.txtBandName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePickerMusicDate
            // 
            this.dateTimePickerMusicDate.Location = new System.Drawing.Point(159, 115);
            this.dateTimePickerMusicDate.Name = "dateTimePickerMusicDate";
            this.dateTimePickerMusicDate.Size = new System.Drawing.Size(209, 20);
            this.dateTimePickerMusicDate.TabIndex = 37;
            // 
            // lblMusicDate
            // 
            this.lblMusicDate.AutoSize = true;
            this.lblMusicDate.Location = new System.Drawing.Point(19, 115);
            this.lblMusicDate.Name = "lblMusicDate";
            this.lblMusicDate.Size = new System.Drawing.Size(93, 13);
            this.lblMusicDate.TabIndex = 36;
            this.lblMusicDate.Text = "Date of Publishing";
            // 
            // cmbMusicRecordType
            // 
            this.cmbMusicRecordType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusicRecordType.FormattingEnabled = true;
            this.cmbMusicRecordType.Location = new System.Drawing.Point(159, 206);
            this.cmbMusicRecordType.Name = "cmbMusicRecordType";
            this.cmbMusicRecordType.Size = new System.Drawing.Size(209, 21);
            this.cmbMusicRecordType.TabIndex = 35;
            // 
            // btnMusicCancel
            // 
            this.btnMusicCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMusicCancel.Location = new System.Drawing.Point(249, 264);
            this.btnMusicCancel.Name = "btnMusicCancel";
            this.btnMusicCancel.Size = new System.Drawing.Size(75, 23);
            this.btnMusicCancel.TabIndex = 34;
            this.btnMusicCancel.Text = "Cancel";
            this.btnMusicCancel.UseVisualStyleBackColor = true;
            this.btnMusicCancel.Click += new System.EventHandler(this.btnContactCancel_Click);
            // 
            // btnMusicOK
            // 
            this.btnMusicOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMusicOK.Location = new System.Drawing.Point(95, 264);
            this.btnMusicOK.Name = "btnMusicOK";
            this.btnMusicOK.Size = new System.Drawing.Size(75, 23);
            this.btnMusicOK.TabIndex = 33;
            this.btnMusicOK.Text = "OK";
            this.btnMusicOK.UseVisualStyleBackColor = true;
            this.btnMusicOK.Click += new System.EventHandler(this.btnContactOK_Click);
            // 
            // lblMusicRecordType
            // 
            this.lblMusicRecordType.AutoSize = true;
            this.lblMusicRecordType.Location = new System.Drawing.Point(19, 206);
            this.lblMusicRecordType.Name = "lblMusicRecordType";
            this.lblMusicRecordType.Size = new System.Drawing.Size(69, 13);
            this.lblMusicRecordType.TabIndex = 32;
            this.lblMusicRecordType.Text = "Record Type";
            // 
            // lblRecordLabel
            // 
            this.lblRecordLabel.AutoSize = true;
            this.lblRecordLabel.Location = new System.Drawing.Point(19, 162);
            this.lblRecordLabel.Name = "lblRecordLabel";
            this.lblRecordLabel.Size = new System.Drawing.Size(71, 13);
            this.lblRecordLabel.TabIndex = 31;
            this.lblRecordLabel.Text = "Record Label";
            // 
            // lblAlbumnName
            // 
            this.lblAlbumnName.AutoSize = true;
            this.lblAlbumnName.Location = new System.Drawing.Point(19, 65);
            this.lblAlbumnName.Name = "lblAlbumnName";
            this.lblAlbumnName.Size = new System.Drawing.Size(73, 13);
            this.lblAlbumnName.TabIndex = 30;
            this.lblAlbumnName.Text = "Albumn Name";
            // 
            // lblBandName
            // 
            this.lblBandName.AutoSize = true;
            this.lblBandName.Location = new System.Drawing.Point(19, 20);
            this.lblBandName.Name = "lblBandName";
            this.lblBandName.Size = new System.Drawing.Size(63, 13);
            this.lblBandName.TabIndex = 29;
            this.lblBandName.Text = "Band Name";
            // 
            // txtRecordLabelName
            // 
            this.txtRecordLabelName.Location = new System.Drawing.Point(159, 162);
            this.txtRecordLabelName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecordLabelName.Name = "txtRecordLabelName";
            this.txtRecordLabelName.Size = new System.Drawing.Size(209, 20);
            this.txtRecordLabelName.TabIndex = 28;
            // 
            // txtAlbumnName
            // 
            this.txtAlbumnName.Location = new System.Drawing.Point(159, 65);
            this.txtAlbumnName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlbumnName.Name = "txtAlbumnName";
            this.txtAlbumnName.Size = new System.Drawing.Size(209, 20);
            this.txtAlbumnName.TabIndex = 27;
            // 
            // txtBandName
            // 
            this.txtBandName.Location = new System.Drawing.Point(159, 20);
            this.txtBandName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBandName.Name = "txtBandName";
            this.txtBandName.Size = new System.Drawing.Size(209, 20);
            this.txtBandName.TabIndex = 26;
            // 
            // MusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 307);
            this.Controls.Add(this.dateTimePickerMusicDate);
            this.Controls.Add(this.lblMusicDate);
            this.Controls.Add(this.cmbMusicRecordType);
            this.Controls.Add(this.btnMusicCancel);
            this.Controls.Add(this.btnMusicOK);
            this.Controls.Add(this.lblMusicRecordType);
            this.Controls.Add(this.lblRecordLabel);
            this.Controls.Add(this.lblAlbumnName);
            this.Controls.Add(this.lblBandName);
            this.Controls.Add(this.txtRecordLabelName);
            this.Controls.Add(this.txtAlbumnName);
            this.Controls.Add(this.txtBandName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusicForm";
            this.Text = "MusicForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MusicForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerMusicDate;
        private System.Windows.Forms.Label lblMusicDate;
        private System.Windows.Forms.ComboBox cmbMusicRecordType;
        private System.Windows.Forms.Button btnMusicCancel;
        private System.Windows.Forms.Button btnMusicOK;
        private System.Windows.Forms.Label lblMusicRecordType;
        private System.Windows.Forms.Label lblRecordLabel;
        private System.Windows.Forms.Label lblAlbumnName;
        private System.Windows.Forms.Label lblBandName;
        private System.Windows.Forms.TextBox txtRecordLabelName;
        private System.Windows.Forms.TextBox txtAlbumnName;
        private System.Windows.Forms.TextBox txtBandName;
    }
}