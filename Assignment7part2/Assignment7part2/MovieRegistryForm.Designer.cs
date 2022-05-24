
namespace Assignment7part2
{
    partial class MovieRegistryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieRegistryForm));
            this.lblMovieDirector = new System.Windows.Forms.Label();
            this.lblMovieYear = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnChangeMovie = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.lstMovieRegistry = new System.Windows.Forms.ListBox();
            this.lblMovieStudio = new System.Windows.Forms.Label();
            this.lblMovieRecordType = new System.Windows.Forms.Label();
            this.btnMovieRent = new System.Windows.Forms.Button();
            this.btnMovieReturn = new System.Windows.Forms.Button();
            this.btnSaveMovieRegistry = new System.Windows.Forms.Button();
            this.toolTipMovie = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblMovieDirector
            // 
            this.lblMovieDirector.AutoSize = true;
            this.lblMovieDirector.Location = new System.Drawing.Point(365, 27);
            this.lblMovieDirector.Name = "lblMovieDirector";
            this.lblMovieDirector.Size = new System.Drawing.Size(45, 16);
            this.lblMovieDirector.TabIndex = 15;
            this.lblMovieDirector.Text = "label1";
            // 
            // lblMovieYear
            // 
            this.lblMovieYear.AutoSize = true;
            this.lblMovieYear.Location = new System.Drawing.Point(268, 27);
            this.lblMovieYear.Name = "lblMovieYear";
            this.lblMovieYear.Size = new System.Drawing.Size(45, 16);
            this.lblMovieYear.TabIndex = 14;
            this.lblMovieYear.Text = "label1";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Location = new System.Drawing.Point(74, 27);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(45, 16);
            this.lblMovieName.TabIndex = 13;
            this.lblMovieName.Text = "label1";
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Location = new System.Drawing.Point(23, 27);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(45, 16);
            this.lblMovieID.TabIndex = 12;
            this.lblMovieID.Text = "label1";
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(688, 486);
            this.btnDeleteMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(111, 42);
            this.btnDeleteMovie.TabIndex = 11;
            this.btnDeleteMovie.Text = "Delete";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnChangeMovie
            // 
            this.btnChangeMovie.Location = new System.Drawing.Point(478, 486);
            this.btnChangeMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeMovie.Name = "btnChangeMovie";
            this.btnChangeMovie.Size = new System.Drawing.Size(111, 42);
            this.btnChangeMovie.TabIndex = 10;
            this.btnChangeMovie.Text = "Change";
            this.btnChangeMovie.UseVisualStyleBackColor = true;
            this.btnChangeMovie.Click += new System.EventHandler(this.btnChangeMovie_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(271, 486);
            this.btnAddMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(111, 42);
            this.btnAddMovie.TabIndex = 9;
            this.btnAddMovie.Text = "Add";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // lstMovieRegistry
            // 
            this.lstMovieRegistry.FormattingEnabled = true;
            this.lstMovieRegistry.ItemHeight = 16;
            this.lstMovieRegistry.Location = new System.Drawing.Point(17, 47);
            this.lstMovieRegistry.Margin = new System.Windows.Forms.Padding(4);
            this.lstMovieRegistry.Name = "lstMovieRegistry";
            this.lstMovieRegistry.Size = new System.Drawing.Size(1033, 420);
            this.lstMovieRegistry.TabIndex = 8;
            // 
            // lblMovieStudio
            // 
            this.lblMovieStudio.AutoSize = true;
            this.lblMovieStudio.Location = new System.Drawing.Point(526, 27);
            this.lblMovieStudio.Name = "lblMovieStudio";
            this.lblMovieStudio.Size = new System.Drawing.Size(45, 16);
            this.lblMovieStudio.TabIndex = 16;
            this.lblMovieStudio.Text = "label1";
            // 
            // lblMovieRecordType
            // 
            this.lblMovieRecordType.AutoSize = true;
            this.lblMovieRecordType.Location = new System.Drawing.Point(685, 27);
            this.lblMovieRecordType.Name = "lblMovieRecordType";
            this.lblMovieRecordType.Size = new System.Drawing.Size(45, 16);
            this.lblMovieRecordType.TabIndex = 17;
            this.lblMovieRecordType.Text = "label1";
            // 
            // btnMovieRent
            // 
            this.btnMovieRent.Location = new System.Drawing.Point(26, 503);
            this.btnMovieRent.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovieRent.Name = "btnMovieRent";
            this.btnMovieRent.Size = new System.Drawing.Size(91, 25);
            this.btnMovieRent.TabIndex = 18;
            this.btnMovieRent.Text = "Rent";
            this.btnMovieRent.UseVisualStyleBackColor = true;
            this.btnMovieRent.Click += new System.EventHandler(this.btnMovieRent_Click);
            // 
            // btnMovieReturn
            // 
            this.btnMovieReturn.Location = new System.Drawing.Point(942, 503);
            this.btnMovieReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovieReturn.Name = "btnMovieReturn";
            this.btnMovieReturn.Size = new System.Drawing.Size(91, 25);
            this.btnMovieReturn.TabIndex = 19;
            this.btnMovieReturn.Text = "Return";
            this.btnMovieReturn.UseVisualStyleBackColor = true;
            this.btnMovieReturn.Click += new System.EventHandler(this.btnMovieReturn_Click);
            // 
            // btnSaveMovieRegistry
            // 
            this.btnSaveMovieRegistry.Location = new System.Drawing.Point(942, 14);
            this.btnSaveMovieRegistry.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveMovieRegistry.Name = "btnSaveMovieRegistry";
            this.btnSaveMovieRegistry.Size = new System.Drawing.Size(91, 25);
            this.btnSaveMovieRegistry.TabIndex = 20;
            this.btnSaveMovieRegistry.Text = "Save";
            this.btnSaveMovieRegistry.UseVisualStyleBackColor = true;
            this.btnSaveMovieRegistry.Click += new System.EventHandler(this.btnSaveMovieRegistry_Click);
            // 
            // MovieRegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSaveMovieRegistry);
            this.Controls.Add(this.btnMovieReturn);
            this.Controls.Add(this.btnMovieRent);
            this.Controls.Add(this.lblMovieRecordType);
            this.Controls.Add(this.lblMovieStudio);
            this.Controls.Add(this.lblMovieDirector);
            this.Controls.Add(this.lblMovieYear);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.lblMovieID);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnChangeMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.lstMovieRegistry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MovieRegistryForm";
            this.Text = "MovieRegistryForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MovieRegistryForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovieDirector;
        private System.Windows.Forms.Label lblMovieYear;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnChangeMovie;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.ListBox lstMovieRegistry;
        private System.Windows.Forms.Label lblMovieStudio;
        private System.Windows.Forms.Label lblMovieRecordType;
        private System.Windows.Forms.Button btnMovieRent;
        private System.Windows.Forms.Button btnMovieReturn;
        private System.Windows.Forms.Button btnSaveMovieRegistry;
        private System.Windows.Forms.ToolTip toolTipMovie;
    }
}