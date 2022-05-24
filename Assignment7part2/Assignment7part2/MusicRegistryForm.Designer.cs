
namespace Assignment7part2
{
    partial class MusicRegistryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicRegistryForm));
            this.btnMusicReturn = new System.Windows.Forms.Button();
            this.btnMusicRent = new System.Windows.Forms.Button();
            this.lblMusicRecordType = new System.Windows.Forms.Label();
            this.lblAlbumnYear = new System.Windows.Forms.Label();
            this.lblRecordLabelName = new System.Windows.Forms.Label();
            this.lblAlbumnName = new System.Windows.Forms.Label();
            this.lblBandName = new System.Windows.Forms.Label();
            this.lblMusicID = new System.Windows.Forms.Label();
            this.btnDeleteMusic = new System.Windows.Forms.Button();
            this.btnChangeMusic = new System.Windows.Forms.Button();
            this.btnAddMusic = new System.Windows.Forms.Button();
            this.lstMusicRegistry = new System.Windows.Forms.ListBox();
            this.btnSaveMusicRegistry = new System.Windows.Forms.Button();
            this.toolTipMusic = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnMusicReturn
            // 
            this.btnMusicReturn.Location = new System.Drawing.Point(942, 503);
            this.btnMusicReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusicReturn.Name = "btnMusicReturn";
            this.btnMusicReturn.Size = new System.Drawing.Size(91, 25);
            this.btnMusicReturn.TabIndex = 31;
            this.btnMusicReturn.Text = "Return";
            this.btnMusicReturn.UseVisualStyleBackColor = true;
            this.btnMusicReturn.Click += new System.EventHandler(this.btnMusicReturn_Click);
            // 
            // btnMusicRent
            // 
            this.btnMusicRent.Location = new System.Drawing.Point(26, 503);
            this.btnMusicRent.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusicRent.Name = "btnMusicRent";
            this.btnMusicRent.Size = new System.Drawing.Size(91, 25);
            this.btnMusicRent.TabIndex = 30;
            this.btnMusicRent.Text = "Rent";
            this.btnMusicRent.UseVisualStyleBackColor = true;
            this.btnMusicRent.Click += new System.EventHandler(this.btnMusicRent_Click);
            // 
            // lblMusicRecordType
            // 
            this.lblMusicRecordType.AutoSize = true;
            this.lblMusicRecordType.Location = new System.Drawing.Point(506, 27);
            this.lblMusicRecordType.Name = "lblMusicRecordType";
            this.lblMusicRecordType.Size = new System.Drawing.Size(45, 16);
            this.lblMusicRecordType.TabIndex = 29;
            this.lblMusicRecordType.Text = "label1";
            // 
            // lblAlbumnYear
            // 
            this.lblAlbumnYear.AutoSize = true;
            this.lblAlbumnYear.Location = new System.Drawing.Point(296, 27);
            this.lblAlbumnYear.Name = "lblAlbumnYear";
            this.lblAlbumnYear.Size = new System.Drawing.Size(45, 16);
            this.lblAlbumnYear.TabIndex = 28;
            this.lblAlbumnYear.Text = "label1";
            // 
            // lblRecordLabelName
            // 
            this.lblRecordLabelName.AutoSize = true;
            this.lblRecordLabelName.Location = new System.Drawing.Point(370, 27);
            this.lblRecordLabelName.Name = "lblRecordLabelName";
            this.lblRecordLabelName.Size = new System.Drawing.Size(45, 16);
            this.lblRecordLabelName.TabIndex = 27;
            this.lblRecordLabelName.Text = "label1";
            // 
            // lblAlbumnName
            // 
            this.lblAlbumnName.AutoSize = true;
            this.lblAlbumnName.Location = new System.Drawing.Point(194, 27);
            this.lblAlbumnName.Name = "lblAlbumnName";
            this.lblAlbumnName.Size = new System.Drawing.Size(45, 16);
            this.lblAlbumnName.TabIndex = 26;
            this.lblAlbumnName.Text = "label1";
            // 
            // lblBandName
            // 
            this.lblBandName.AutoSize = true;
            this.lblBandName.Location = new System.Drawing.Point(74, 27);
            this.lblBandName.Name = "lblBandName";
            this.lblBandName.Size = new System.Drawing.Size(45, 16);
            this.lblBandName.TabIndex = 25;
            this.lblBandName.Text = "label1";
            // 
            // lblMusicID
            // 
            this.lblMusicID.AutoSize = true;
            this.lblMusicID.Location = new System.Drawing.Point(23, 27);
            this.lblMusicID.Name = "lblMusicID";
            this.lblMusicID.Size = new System.Drawing.Size(45, 16);
            this.lblMusicID.TabIndex = 24;
            this.lblMusicID.Text = "label1";
            // 
            // btnDeleteMusic
            // 
            this.btnDeleteMusic.Location = new System.Drawing.Point(688, 486);
            this.btnDeleteMusic.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteMusic.Name = "btnDeleteMusic";
            this.btnDeleteMusic.Size = new System.Drawing.Size(111, 42);
            this.btnDeleteMusic.TabIndex = 23;
            this.btnDeleteMusic.Text = "Delete";
            this.btnDeleteMusic.UseVisualStyleBackColor = true;
            this.btnDeleteMusic.Click += new System.EventHandler(this.btnDeleteMusic_Click);
            // 
            // btnChangeMusic
            // 
            this.btnChangeMusic.Location = new System.Drawing.Point(478, 486);
            this.btnChangeMusic.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeMusic.Name = "btnChangeMusic";
            this.btnChangeMusic.Size = new System.Drawing.Size(111, 42);
            this.btnChangeMusic.TabIndex = 22;
            this.btnChangeMusic.Text = "Change";
            this.btnChangeMusic.UseVisualStyleBackColor = true;
            this.btnChangeMusic.Click += new System.EventHandler(this.btnChangeMusic_Click);
            // 
            // btnAddMusic
            // 
            this.btnAddMusic.Location = new System.Drawing.Point(271, 486);
            this.btnAddMusic.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMusic.Name = "btnAddMusic";
            this.btnAddMusic.Size = new System.Drawing.Size(111, 42);
            this.btnAddMusic.TabIndex = 21;
            this.btnAddMusic.Text = "Add";
            this.btnAddMusic.UseVisualStyleBackColor = true;
            this.btnAddMusic.Click += new System.EventHandler(this.btnAddMusic_Click);
            // 
            // lstMusicRegistry
            // 
            this.lstMusicRegistry.FormattingEnabled = true;
            this.lstMusicRegistry.ItemHeight = 16;
            this.lstMusicRegistry.Location = new System.Drawing.Point(17, 47);
            this.lstMusicRegistry.Margin = new System.Windows.Forms.Padding(4);
            this.lstMusicRegistry.Name = "lstMusicRegistry";
            this.lstMusicRegistry.Size = new System.Drawing.Size(1033, 420);
            this.lstMusicRegistry.TabIndex = 20;
            // 
            // btnSaveMusicRegistry
            // 
            this.btnSaveMusicRegistry.Location = new System.Drawing.Point(942, 14);
            this.btnSaveMusicRegistry.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveMusicRegistry.Name = "btnSaveMusicRegistry";
            this.btnSaveMusicRegistry.Size = new System.Drawing.Size(91, 25);
            this.btnSaveMusicRegistry.TabIndex = 32;
            this.btnSaveMusicRegistry.Text = "Save";
            this.btnSaveMusicRegistry.UseVisualStyleBackColor = true;
            this.btnSaveMusicRegistry.Click += new System.EventHandler(this.btnSaveMusicRegistry_Click);
            // 
            // MusicRegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSaveMusicRegistry);
            this.Controls.Add(this.btnMusicReturn);
            this.Controls.Add(this.btnMusicRent);
            this.Controls.Add(this.lblMusicRecordType);
            this.Controls.Add(this.lblAlbumnYear);
            this.Controls.Add(this.lblRecordLabelName);
            this.Controls.Add(this.lblAlbumnName);
            this.Controls.Add(this.lblBandName);
            this.Controls.Add(this.lblMusicID);
            this.Controls.Add(this.btnDeleteMusic);
            this.Controls.Add(this.btnChangeMusic);
            this.Controls.Add(this.btnAddMusic);
            this.Controls.Add(this.lstMusicRegistry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MusicRegistryForm";
            this.Text = "MusicForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MusicRegistryForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMusicReturn;
        private System.Windows.Forms.Button btnMusicRent;
        private System.Windows.Forms.Label lblMusicRecordType;
        private System.Windows.Forms.Label lblAlbumnYear;
        private System.Windows.Forms.Label lblRecordLabelName;
        private System.Windows.Forms.Label lblAlbumnName;
        private System.Windows.Forms.Label lblBandName;
        private System.Windows.Forms.Label lblMusicID;
        private System.Windows.Forms.Button btnDeleteMusic;
        private System.Windows.Forms.Button btnChangeMusic;
        private System.Windows.Forms.Button btnAddMusic;
        private System.Windows.Forms.ListBox lstMusicRegistry;
        private System.Windows.Forms.Button btnSaveMusicRegistry;
        private System.Windows.Forms.ToolTip toolTipMusic;
    }
}