
namespace Assignment7part2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuMainForm = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerRegistryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearNewRegistryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieRegistryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearNewInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearNewInventoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCustomerRegistry = new System.Windows.Forms.Button();
            this.btnMovieRegistry = new System.Windows.Forms.Button();
            this.btnMusicRegistry = new System.Windows.Forms.Button();
            this.picMainMenuLogo = new System.Windows.Forms.PictureBox();
            this.toolTipMainForm = new System.Windows.Forms.ToolTip(this.components);
            this.menuMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenuLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMainForm
            // 
            this.menuMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuMainForm.Name = "menuMainForm";
            this.menuMainForm.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuMainForm.Size = new System.Drawing.Size(453, 24);
            this.menuMainForm.TabIndex = 0;
            this.menuMainForm.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerRegistryToolStripMenuItem,
            this.movieRegistryToolStripMenuItem,
            this.musicInventoryToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // customerRegistryToolStripMenuItem
            // 
            this.customerRegistryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearNewRegistryToolStripMenuItem});
            this.customerRegistryToolStripMenuItem.Name = "customerRegistryToolStripMenuItem";
            this.customerRegistryToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.customerRegistryToolStripMenuItem.Text = "Customer Registry";
            // 
            // clearNewRegistryToolStripMenuItem
            // 
            this.clearNewRegistryToolStripMenuItem.Name = "clearNewRegistryToolStripMenuItem";
            this.clearNewRegistryToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.clearNewRegistryToolStripMenuItem.Text = "Clear/New Registry";
            this.clearNewRegistryToolStripMenuItem.Click += new System.EventHandler(this.clearNewRegistryToolStripMenuItem_Click);
            // 
            // movieRegistryToolStripMenuItem
            // 
            this.movieRegistryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearNewInventoryToolStripMenuItem});
            this.movieRegistryToolStripMenuItem.Name = "movieRegistryToolStripMenuItem";
            this.movieRegistryToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.movieRegistryToolStripMenuItem.Text = "Movie Inventory";
            // 
            // clearNewInventoryToolStripMenuItem
            // 
            this.clearNewInventoryToolStripMenuItem.Name = "clearNewInventoryToolStripMenuItem";
            this.clearNewInventoryToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.clearNewInventoryToolStripMenuItem.Text = "Clear/New Inventory";
            this.clearNewInventoryToolStripMenuItem.Click += new System.EventHandler(this.clearNewInventoryToolStripMenuItem_Click);
            // 
            // musicInventoryToolStripMenuItem
            // 
            this.musicInventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearNewInventoryToolStripMenuItem1});
            this.musicInventoryToolStripMenuItem.Name = "musicInventoryToolStripMenuItem";
            this.musicInventoryToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.musicInventoryToolStripMenuItem.Text = "Music Inventory";
            // 
            // clearNewInventoryToolStripMenuItem1
            // 
            this.clearNewInventoryToolStripMenuItem1.Name = "clearNewInventoryToolStripMenuItem1";
            this.clearNewInventoryToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.clearNewInventoryToolStripMenuItem1.Text = "Clear/New Inventory";
            this.clearNewInventoryToolStripMenuItem1.Click += new System.EventHandler(this.clearNewInventoryToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveToolStripMenuItem.Text = "Save ";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnCustomerRegistry
            // 
            this.btnCustomerRegistry.Location = new System.Drawing.Point(132, 193);
            this.btnCustomerRegistry.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomerRegistry.Name = "btnCustomerRegistry";
            this.btnCustomerRegistry.Size = new System.Drawing.Size(197, 71);
            this.btnCustomerRegistry.TabIndex = 2;
            this.btnCustomerRegistry.Text = "Customer Registry";
            this.btnCustomerRegistry.UseVisualStyleBackColor = true;
            this.btnCustomerRegistry.Click += new System.EventHandler(this.btnCustomerRegistry_Click);
            // 
            // btnMovieRegistry
            // 
            this.btnMovieRegistry.Location = new System.Drawing.Point(132, 304);
            this.btnMovieRegistry.Name = "btnMovieRegistry";
            this.btnMovieRegistry.Size = new System.Drawing.Size(197, 71);
            this.btnMovieRegistry.TabIndex = 3;
            this.btnMovieRegistry.Text = "Movie Database";
            this.btnMovieRegistry.UseVisualStyleBackColor = true;
            this.btnMovieRegistry.Click += new System.EventHandler(this.btnMovieRegistry_Click);
            // 
            // btnMusicRegistry
            // 
            this.btnMusicRegistry.Location = new System.Drawing.Point(132, 410);
            this.btnMusicRegistry.Name = "btnMusicRegistry";
            this.btnMusicRegistry.Size = new System.Drawing.Size(197, 71);
            this.btnMusicRegistry.TabIndex = 4;
            this.btnMusicRegistry.Text = "Music Database";
            this.btnMusicRegistry.UseVisualStyleBackColor = true;
            this.btnMusicRegistry.Click += new System.EventHandler(this.btnMusicRegistry_Click);
            // 
            // picMainMenuLogo
            // 
            this.picMainMenuLogo.Image = global::Assignment7part2.Properties.Resources.kontroll_store_name_logo;
            this.picMainMenuLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picMainMenuLogo.InitialImage")));
            this.picMainMenuLogo.Location = new System.Drawing.Point(16, 33);
            this.picMainMenuLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picMainMenuLogo.Name = "picMainMenuLogo";
            this.picMainMenuLogo.Size = new System.Drawing.Size(420, 134);
            this.picMainMenuLogo.TabIndex = 1;
            this.picMainMenuLogo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 512);
            this.Controls.Add(this.btnMusicRegistry);
            this.Controls.Add(this.btnMovieRegistry);
            this.Controls.Add(this.btnCustomerRegistry);
            this.Controls.Add(this.picMainMenuLogo);
            this.Controls.Add(this.menuMainForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMainForm;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "text";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuMainForm.ResumeLayout(false);
            this.menuMainForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenuLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMainForm;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerRegistryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearNewRegistryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieRegistryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearNewInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearNewInventoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox picMainMenuLogo;
        private System.Windows.Forms.Button btnCustomerRegistry;
        private System.Windows.Forms.Button btnMovieRegistry;
        private System.Windows.Forms.Button btnMusicRegistry;
        private System.Windows.Forms.ToolTip toolTipMainForm;
    }
}

