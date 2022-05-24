
namespace Assignment7part2
{
    partial class MovieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieForm));
            this.btnContactCancel = new System.Windows.Forms.Button();
            this.btnMovieOK = new System.Windows.Forms.Button();
            this.lblMovieRecordType = new System.Windows.Forms.Label();
            this.lblStudioName = new System.Windows.Forms.Label();
            this.lblDirectorName = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.txtStudioName = new System.Windows.Forms.TextBox();
            this.txtDirectorName = new System.Windows.Forms.TextBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.cmbMovieRecordType = new System.Windows.Forms.ComboBox();
            this.lblMovieDate = new System.Windows.Forms.Label();
            this.dateTimePickerMovieDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnContactCancel
            // 
            this.btnContactCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnContactCancel.Location = new System.Drawing.Point(249, 264);
            this.btnContactCancel.Name = "btnContactCancel";
            this.btnContactCancel.Size = new System.Drawing.Size(75, 23);
            this.btnContactCancel.TabIndex = 22;
            this.btnContactCancel.Text = "Cancel";
            this.btnContactCancel.UseVisualStyleBackColor = true;
            this.btnContactCancel.Click += new System.EventHandler(this.btnContactCancel_Click);
            // 
            // btnMovieOK
            // 
            this.btnMovieOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMovieOK.Location = new System.Drawing.Point(95, 264);
            this.btnMovieOK.Name = "btnMovieOK";
            this.btnMovieOK.Size = new System.Drawing.Size(75, 23);
            this.btnMovieOK.TabIndex = 21;
            this.btnMovieOK.Text = "OK";
            this.btnMovieOK.UseVisualStyleBackColor = true;
            this.btnMovieOK.Click += new System.EventHandler(this.btnContactOK_Click);
            // 
            // lblMovieRecordType
            // 
            this.lblMovieRecordType.AutoSize = true;
            this.lblMovieRecordType.Location = new System.Drawing.Point(19, 206);
            this.lblMovieRecordType.Name = "lblMovieRecordType";
            this.lblMovieRecordType.Size = new System.Drawing.Size(76, 15);
            this.lblMovieRecordType.TabIndex = 20;
            this.lblMovieRecordType.Text = "Record Type";
            // 
            // lblStudioName
            // 
            this.lblStudioName.AutoSize = true;
            this.lblStudioName.Location = new System.Drawing.Point(19, 162);
            this.lblStudioName.Name = "lblStudioName";
            this.lblStudioName.Size = new System.Drawing.Size(79, 15);
            this.lblStudioName.TabIndex = 19;
            this.lblStudioName.Text = "Studio Name";
            // 
            // lblDirectorName
            // 
            this.lblDirectorName.AutoSize = true;
            this.lblDirectorName.Location = new System.Drawing.Point(19, 115);
            this.lblDirectorName.Name = "lblDirectorName";
            this.lblDirectorName.Size = new System.Drawing.Size(87, 15);
            this.lblDirectorName.TabIndex = 18;
            this.lblDirectorName.Text = "Director Name";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Location = new System.Drawing.Point(19, 20);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(77, 15);
            this.lblMovieName.TabIndex = 17;
            this.lblMovieName.Text = "Movie Name";
            // 
            // txtStudioName
            // 
            this.txtStudioName.Location = new System.Drawing.Point(159, 162);
            this.txtStudioName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudioName.Name = "txtStudioName";
            this.txtStudioName.Size = new System.Drawing.Size(209, 21);
            this.txtStudioName.TabIndex = 16;
            // 
            // txtDirectorName
            // 
            this.txtDirectorName.Location = new System.Drawing.Point(159, 115);
            this.txtDirectorName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirectorName.Name = "txtDirectorName";
            this.txtDirectorName.Size = new System.Drawing.Size(209, 21);
            this.txtDirectorName.TabIndex = 15;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(159, 20);
            this.txtMovieName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(209, 21);
            this.txtMovieName.TabIndex = 14;
            // 
            // cmbMovieRecordType
            // 
            this.cmbMovieRecordType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMovieRecordType.FormattingEnabled = true;
            this.cmbMovieRecordType.Location = new System.Drawing.Point(159, 206);
            this.cmbMovieRecordType.Name = "cmbMovieRecordType";
            this.cmbMovieRecordType.Size = new System.Drawing.Size(209, 23);
            this.cmbMovieRecordType.TabIndex = 23;
            // 
            // lblMovieDate
            // 
            this.lblMovieDate.AutoSize = true;
            this.lblMovieDate.Location = new System.Drawing.Point(19, 65);
            this.lblMovieDate.Name = "lblMovieDate";
            this.lblMovieDate.Size = new System.Drawing.Size(107, 15);
            this.lblMovieDate.TabIndex = 24;
            this.lblMovieDate.Text = "Date of Publishing";
            // 
            // dateTimePickerMovieDate
            // 
            this.dateTimePickerMovieDate.Location = new System.Drawing.Point(159, 65);
            this.dateTimePickerMovieDate.Name = "dateTimePickerMovieDate";
            this.dateTimePickerMovieDate.Size = new System.Drawing.Size(209, 21);
            this.dateTimePickerMovieDate.TabIndex = 25;
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 307);
            this.Controls.Add(this.dateTimePickerMovieDate);
            this.Controls.Add(this.lblMovieDate);
            this.Controls.Add(this.cmbMovieRecordType);
            this.Controls.Add(this.btnContactCancel);
            this.Controls.Add(this.btnMovieOK);
            this.Controls.Add(this.lblMovieRecordType);
            this.Controls.Add(this.lblStudioName);
            this.Controls.Add(this.lblDirectorName);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.txtStudioName);
            this.Controls.Add(this.txtDirectorName);
            this.Controls.Add(this.txtMovieName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovieForm";
            this.Text = "MovieForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MovieForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContactCancel;
        private System.Windows.Forms.Button btnMovieOK;
        private System.Windows.Forms.Label lblMovieRecordType;
        private System.Windows.Forms.Label lblStudioName;
        private System.Windows.Forms.Label lblDirectorName;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.TextBox txtStudioName;
        private System.Windows.Forms.TextBox txtDirectorName;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.ComboBox cmbMovieRecordType;
        private System.Windows.Forms.Label lblMovieDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerMovieDate;
    }
}