namespace Assignment3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grboxFuel = new System.Windows.Forms.GroupBox();
            this.txtPriceFuel = new System.Windows.Forms.TextBox();
            this.txtCurrFuel = new System.Windows.Forms.TextBox();
            this.txtPrevReading = new System.Windows.Forms.TextBox();
            this.txtCurrReading = new System.Windows.Forms.TextBox();
            this.btnFuelCalc = new System.Windows.Forms.Button();
            this.lblPriceFuel = new System.Windows.Forms.Label();
            this.lblCurrFuel = new System.Windows.Forms.Label();
            this.lblPrevReading = new System.Windows.Forms.Label();
            this.lblCurrReading = new System.Windows.Forms.Label();
            this.grboxFuelResults = new System.Windows.Forms.GroupBox();
            this.lblCostKMOUT = new System.Windows.Forms.Label();
            this.lblFuelConsLSMOUT = new System.Windows.Forms.Label();
            this.lblFuelConsLMMOUT = new System.Windows.Forms.Label();
            this.lblFuelConsLKOUT = new System.Windows.Forms.Label();
            this.lblFuelConsKLOUT = new System.Windows.Forms.Label();
            this.lblCostKM = new System.Windows.Forms.Label();
            this.lblFuelConsLSM = new System.Windows.Forms.Label();
            this.lblFuelConsLMM = new System.Windows.Forms.Label();
            this.lblFuelConsLK = new System.Windows.Forms.Label();
            this.lblFuelConsKL = new System.Windows.Forms.Label();
            this.grboxBMI = new System.Windows.Forms.GroupBox();
            this.btnBMICalc = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.rbtnImperial = new System.Windows.Forms.RadioButton();
            this.rbtnMetric = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grboxResultsBMI = new System.Windows.Forms.GroupBox();
            this.lblNormalBMI = new System.Windows.Forms.Label();
            this.lblWCategoryOUT = new System.Windows.Forms.Label();
            this.lblBMIOUT = new System.Windows.Forms.Label();
            this.lblWCategory = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.grboxBMR = new System.Windows.Forms.GroupBox();
            this.lblListBoxItem = new System.Windows.Forms.Label();
            this.lboxBMR = new System.Windows.Forms.ListBox();
            this.btnUnselect = new System.Windows.Forms.Button();
            this.btnBMRCalc = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.grboxActivityBMR = new System.Windows.Forms.GroupBox();
            this.rbtnExtraActive = new System.Windows.Forms.RadioButton();
            this.rbtnVeryActive = new System.Windows.Forms.RadioButton();
            this.rbtnModerately = new System.Windows.Forms.RadioButton();
            this.rbtnLightly = new System.Windows.Forms.RadioButton();
            this.rbtnSedetary = new System.Windows.Forms.RadioButton();
            this.grboxFuel.SuspendLayout();
            this.grboxFuelResults.SuspendLayout();
            this.grboxBMI.SuspendLayout();
            this.grboxResultsBMI.SuspendLayout();
            this.grboxBMR.SuspendLayout();
            this.grboxActivityBMR.SuspendLayout();
            this.SuspendLayout();
            // 
            // grboxFuel
            // 
            this.grboxFuel.Controls.Add(this.txtPriceFuel);
            this.grboxFuel.Controls.Add(this.txtCurrFuel);
            this.grboxFuel.Controls.Add(this.txtPrevReading);
            this.grboxFuel.Controls.Add(this.txtCurrReading);
            this.grboxFuel.Controls.Add(this.btnFuelCalc);
            this.grboxFuel.Controls.Add(this.lblPriceFuel);
            this.grboxFuel.Controls.Add(this.lblCurrFuel);
            this.grboxFuel.Controls.Add(this.lblPrevReading);
            this.grboxFuel.Controls.Add(this.lblCurrReading);
            this.grboxFuel.Controls.Add(this.grboxFuelResults);
            this.grboxFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxFuel.ForeColor = System.Drawing.Color.Blue;
            this.grboxFuel.Location = new System.Drawing.Point(12, 12);
            this.grboxFuel.Name = "grboxFuel";
            this.grboxFuel.Size = new System.Drawing.Size(409, 478);
            this.grboxFuel.TabIndex = 0;
            this.grboxFuel.TabStop = false;
            this.grboxFuel.Text = "Fuel";
            // 
            // txtPriceFuel
            // 
            this.txtPriceFuel.Location = new System.Drawing.Point(303, 126);
            this.txtPriceFuel.Name = "txtPriceFuel";
            this.txtPriceFuel.Size = new System.Drawing.Size(100, 26);
            this.txtPriceFuel.TabIndex = 10;
            this.txtPriceFuel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCurrFuel
            // 
            this.txtCurrFuel.Location = new System.Drawing.Point(303, 94);
            this.txtCurrFuel.Name = "txtCurrFuel";
            this.txtCurrFuel.Size = new System.Drawing.Size(100, 26);
            this.txtCurrFuel.TabIndex = 9;
            this.txtCurrFuel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrevReading
            // 
            this.txtPrevReading.Location = new System.Drawing.Point(303, 62);
            this.txtPrevReading.Name = "txtPrevReading";
            this.txtPrevReading.Size = new System.Drawing.Size(100, 26);
            this.txtPrevReading.TabIndex = 8;
            this.txtPrevReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCurrReading
            // 
            this.txtCurrReading.Location = new System.Drawing.Point(303, 30);
            this.txtCurrReading.Name = "txtCurrReading";
            this.txtCurrReading.Size = new System.Drawing.Size(100, 26);
            this.txtCurrReading.TabIndex = 7;
            this.txtCurrReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnFuelCalc
            // 
            this.btnFuelCalc.BackColor = System.Drawing.Color.Silver;
            this.btnFuelCalc.ForeColor = System.Drawing.Color.Blue;
            this.btnFuelCalc.Location = new System.Drawing.Point(133, 176);
            this.btnFuelCalc.Name = "btnFuelCalc";
            this.btnFuelCalc.Size = new System.Drawing.Size(106, 33);
            this.btnFuelCalc.TabIndex = 6;
            this.btnFuelCalc.Text = "Calculate";
            this.btnFuelCalc.UseVisualStyleBackColor = false;
            this.btnFuelCalc.Click += new System.EventHandler(this.btnFuelCalc_Click);
            // 
            // lblPriceFuel
            // 
            this.lblPriceFuel.AutoSize = true;
            this.lblPriceFuel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPriceFuel.Location = new System.Drawing.Point(6, 126);
            this.lblPriceFuel.Name = "lblPriceFuel";
            this.lblPriceFuel.Size = new System.Drawing.Size(100, 20);
            this.lblPriceFuel.TabIndex = 5;
            this.lblPriceFuel.Text = "Price per liter";
            // 
            // lblCurrFuel
            // 
            this.lblCurrFuel.AutoSize = true;
            this.lblCurrFuel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCurrFuel.Location = new System.Drawing.Point(6, 97);
            this.lblCurrFuel.Name = "lblCurrFuel";
            this.lblCurrFuel.Size = new System.Drawing.Size(259, 20);
            this.lblCurrFuel.TabIndex = 4;
            this.lblCurrFuel.Text = "Current amout of fuel tanked (liters)";
            // 
            // lblPrevReading
            // 
            this.lblPrevReading.AutoSize = true;
            this.lblPrevReading.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrevReading.Location = new System.Drawing.Point(6, 66);
            this.lblPrevReading.Name = "lblPrevReading";
            this.lblPrevReading.Size = new System.Drawing.Size(233, 20);
            this.lblPrevReading.TabIndex = 3;
            this.lblPrevReading.Text = "Previous odometer reading (km)";
            // 
            // lblCurrReading
            // 
            this.lblCurrReading.AutoSize = true;
            this.lblCurrReading.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCurrReading.Location = new System.Drawing.Point(6, 33);
            this.lblCurrReading.Name = "lblCurrReading";
            this.lblCurrReading.Size = new System.Drawing.Size(226, 20);
            this.lblCurrReading.TabIndex = 2;
            this.lblCurrReading.Text = "Current odometer reading (km)";
            // 
            // grboxFuelResults
            // 
            this.grboxFuelResults.Controls.Add(this.lblCostKMOUT);
            this.grboxFuelResults.Controls.Add(this.lblFuelConsLSMOUT);
            this.grboxFuelResults.Controls.Add(this.lblFuelConsLMMOUT);
            this.grboxFuelResults.Controls.Add(this.lblFuelConsLKOUT);
            this.grboxFuelResults.Controls.Add(this.lblFuelConsKLOUT);
            this.grboxFuelResults.Controls.Add(this.lblCostKM);
            this.grboxFuelResults.Controls.Add(this.lblFuelConsLSM);
            this.grboxFuelResults.Controls.Add(this.lblFuelConsLMM);
            this.grboxFuelResults.Controls.Add(this.lblFuelConsLK);
            this.grboxFuelResults.Controls.Add(this.lblFuelConsKL);
            this.grboxFuelResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxFuelResults.Location = new System.Drawing.Point(6, 256);
            this.grboxFuelResults.Name = "grboxFuelResults";
            this.grboxFuelResults.Size = new System.Drawing.Size(397, 213);
            this.grboxFuelResults.TabIndex = 1;
            this.grboxFuelResults.TabStop = false;
            this.grboxFuelResults.Text = "Results";
            // 
            // lblCostKMOUT
            // 
            this.lblCostKMOUT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCostKMOUT.Location = new System.Drawing.Point(297, 153);
            this.lblCostKMOUT.Name = "lblCostKMOUT";
            this.lblCostKMOUT.Size = new System.Drawing.Size(94, 27);
            this.lblCostKMOUT.TabIndex = 9;
            this.lblCostKMOUT.Text = "Out";
            this.lblCostKMOUT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFuelConsLSMOUT
            // 
            this.lblFuelConsLSMOUT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelConsLSMOUT.Location = new System.Drawing.Point(297, 123);
            this.lblFuelConsLSMOUT.Name = "lblFuelConsLSMOUT";
            this.lblFuelConsLSMOUT.Size = new System.Drawing.Size(94, 27);
            this.lblFuelConsLSMOUT.TabIndex = 8;
            this.lblFuelConsLSMOUT.Text = "Out";
            this.lblFuelConsLSMOUT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFuelConsLMMOUT
            // 
            this.lblFuelConsLMMOUT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelConsLMMOUT.Location = new System.Drawing.Point(297, 94);
            this.lblFuelConsLMMOUT.Name = "lblFuelConsLMMOUT";
            this.lblFuelConsLMMOUT.Size = new System.Drawing.Size(94, 27);
            this.lblFuelConsLMMOUT.TabIndex = 7;
            this.lblFuelConsLMMOUT.Text = "Out";
            this.lblFuelConsLMMOUT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFuelConsLKOUT
            // 
            this.lblFuelConsLKOUT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelConsLKOUT.Location = new System.Drawing.Point(297, 65);
            this.lblFuelConsLKOUT.Name = "lblFuelConsLKOUT";
            this.lblFuelConsLKOUT.Size = new System.Drawing.Size(94, 27);
            this.lblFuelConsLKOUT.TabIndex = 6;
            this.lblFuelConsLKOUT.Text = "Out";
            this.lblFuelConsLKOUT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFuelConsKLOUT
            // 
            this.lblFuelConsKLOUT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelConsKLOUT.Location = new System.Drawing.Point(297, 33);
            this.lblFuelConsKLOUT.Name = "lblFuelConsKLOUT";
            this.lblFuelConsKLOUT.Size = new System.Drawing.Size(94, 27);
            this.lblFuelConsKLOUT.TabIndex = 5;
            this.lblFuelConsKLOUT.Text = "Out";
            this.lblFuelConsKLOUT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCostKM
            // 
            this.lblCostKM.AutoSize = true;
            this.lblCostKM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCostKM.Location = new System.Drawing.Point(6, 160);
            this.lblCostKM.Name = "lblCostKM";
            this.lblCostKM.Size = new System.Drawing.Size(137, 20);
            this.lblCostKM.TabIndex = 4;
            this.lblCostKM.Text = "Cost per kilometer";
            // 
            // lblFuelConsLSM
            // 
            this.lblFuelConsLSM.AutoSize = true;
            this.lblFuelConsLSM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFuelConsLSM.Location = new System.Drawing.Point(6, 130);
            this.lblFuelConsLSM.Name = "lblFuelConsLSM";
            this.lblFuelConsLSM.Size = new System.Drawing.Size(247, 20);
            this.lblFuelConsLSM.TabIndex = 3;
            this.lblFuelConsLSM.Text = "Fuel consumption (lit/Swedish mil)";
            // 
            // lblFuelConsLMM
            // 
            this.lblFuelConsLMM.AutoSize = true;
            this.lblFuelConsLMM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFuelConsLMM.Location = new System.Drawing.Point(6, 101);
            this.lblFuelConsLMM.Name = "lblFuelConsLMM";
            this.lblFuelConsLMM.Size = new System.Drawing.Size(239, 20);
            this.lblFuelConsLMM.TabIndex = 2;
            this.lblFuelConsLMM.Text = "Fuel consumption (lit/metric mile)";
            // 
            // lblFuelConsLK
            // 
            this.lblFuelConsLK.AutoSize = true;
            this.lblFuelConsLK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFuelConsLK.Location = new System.Drawing.Point(6, 72);
            this.lblFuelConsLK.Name = "lblFuelConsLK";
            this.lblFuelConsLK.Size = new System.Drawing.Size(185, 20);
            this.lblFuelConsLK.TabIndex = 1;
            this.lblFuelConsLK.Text = "Fuel consumption (lit/km)";
            // 
            // lblFuelConsKL
            // 
            this.lblFuelConsKL.AutoSize = true;
            this.lblFuelConsKL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFuelConsKL.Location = new System.Drawing.Point(6, 40);
            this.lblFuelConsKL.Name = "lblFuelConsKL";
            this.lblFuelConsKL.Size = new System.Drawing.Size(185, 20);
            this.lblFuelConsKL.TabIndex = 0;
            this.lblFuelConsKL.Text = "Fuel consumption (km/lit)";
            // 
            // grboxBMI
            // 
            this.grboxBMI.Controls.Add(this.btnBMICalc);
            this.grboxBMI.Controls.Add(this.txtWeight);
            this.grboxBMI.Controls.Add(this.txtHeight);
            this.grboxBMI.Controls.Add(this.rbtnImperial);
            this.grboxBMI.Controls.Add(this.rbtnMetric);
            this.grboxBMI.Controls.Add(this.txtName);
            this.grboxBMI.Controls.Add(this.lblWeight);
            this.grboxBMI.Controls.Add(this.lblHeight);
            this.grboxBMI.Controls.Add(this.lblName);
            this.grboxBMI.Controls.Add(this.grboxResultsBMI);
            this.grboxBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxBMI.ForeColor = System.Drawing.Color.Blue;
            this.grboxBMI.Location = new System.Drawing.Point(444, 12);
            this.grboxBMI.Name = "grboxBMI";
            this.grboxBMI.Size = new System.Drawing.Size(558, 478);
            this.grboxBMI.TabIndex = 2;
            this.grboxBMI.TabStop = false;
            this.grboxBMI.Text = "BMI";
            // 
            // btnBMICalc
            // 
            this.btnBMICalc.BackColor = System.Drawing.Color.Silver;
            this.btnBMICalc.ForeColor = System.Drawing.Color.Blue;
            this.btnBMICalc.Location = new System.Drawing.Point(215, 176);
            this.btnBMICalc.Name = "btnBMICalc";
            this.btnBMICalc.Size = new System.Drawing.Size(156, 33);
            this.btnBMICalc.TabIndex = 11;
            this.btnBMICalc.Text = "Calculate";
            this.btnBMICalc.UseVisualStyleBackColor = false;
            this.btnBMICalc.Click += new System.EventHandler(this.btnBMICalc_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(132, 94);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 26);
            this.txtWeight.TabIndex = 10;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(132, 63);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 26);
            this.txtHeight.TabIndex = 9;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rbtnImperial
            // 
            this.rbtnImperial.AutoSize = true;
            this.rbtnImperial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnImperial.Location = new System.Drawing.Point(389, 97);
            this.rbtnImperial.Name = "rbtnImperial";
            this.rbtnImperial.Size = new System.Drawing.Size(146, 24);
            this.rbtnImperial.TabIndex = 8;
            this.rbtnImperial.TabStop = true;
            this.rbtnImperial.Text = "US Unit (lb, inch)";
            this.rbtnImperial.UseVisualStyleBackColor = true;
            // 
            // rbtnMetric
            // 
            this.rbtnMetric.AutoSize = true;
            this.rbtnMetric.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnMetric.Location = new System.Drawing.Point(389, 66);
            this.rbtnMetric.Name = "rbtnMetric";
            this.rbtnMetric.Size = new System.Drawing.Size(163, 24);
            this.rbtnMetric.TabIndex = 7;
            this.rbtnMetric.TabStop = true;
            this.rbtnMetric.Text = "Metric Unit (kg, cm)";
            this.rbtnMetric.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(420, 26);
            this.txtName.TabIndex = 6;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWeight.Location = new System.Drawing.Point(6, 97);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(59, 20);
            this.lblWeight.TabIndex = 5;
            this.lblWeight.Text = "Weight";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHeight.Location = new System.Drawing.Point(6, 66);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(56, 20);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(6, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Your name";
            // 
            // grboxResultsBMI
            // 
            this.grboxResultsBMI.Controls.Add(this.lblNormalBMI);
            this.grboxResultsBMI.Controls.Add(this.lblWCategoryOUT);
            this.grboxResultsBMI.Controls.Add(this.lblBMIOUT);
            this.grboxResultsBMI.Controls.Add(this.lblWCategory);
            this.grboxResultsBMI.Controls.Add(this.lblBMI);
            this.grboxResultsBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxResultsBMI.Location = new System.Drawing.Point(6, 256);
            this.grboxResultsBMI.Name = "grboxResultsBMI";
            this.grboxResultsBMI.Size = new System.Drawing.Size(546, 213);
            this.grboxResultsBMI.TabIndex = 2;
            this.grboxResultsBMI.TabStop = false;
            this.grboxResultsBMI.Text = "Results";
            // 
            // lblNormalBMI
            // 
            this.lblNormalBMI.Location = new System.Drawing.Point(126, 130);
            this.lblNormalBMI.Name = "lblNormalBMI";
            this.lblNormalBMI.Size = new System.Drawing.Size(414, 27);
            this.lblNormalBMI.TabIndex = 12;
            this.lblNormalBMI.Text = "Out";
            this.lblNormalBMI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWCategoryOUT
            // 
            this.lblWCategoryOUT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWCategoryOUT.Location = new System.Drawing.Point(294, 72);
            this.lblWCategoryOUT.Name = "lblWCategoryOUT";
            this.lblWCategoryOUT.Size = new System.Drawing.Size(246, 27);
            this.lblWCategoryOUT.TabIndex = 11;
            this.lblWCategoryOUT.Text = "Out";
            this.lblWCategoryOUT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBMIOUT
            // 
            this.lblBMIOUT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBMIOUT.Location = new System.Drawing.Point(446, 33);
            this.lblBMIOUT.Name = "lblBMIOUT";
            this.lblBMIOUT.Size = new System.Drawing.Size(94, 27);
            this.lblBMIOUT.TabIndex = 10;
            this.lblBMIOUT.Text = "Out";
            this.lblBMIOUT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWCategory
            // 
            this.lblWCategory.AutoSize = true;
            this.lblWCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWCategory.Location = new System.Drawing.Point(6, 72);
            this.lblWCategory.Name = "lblWCategory";
            this.lblWCategory.Size = new System.Drawing.Size(127, 20);
            this.lblWCategory.TabIndex = 1;
            this.lblWCategory.Text = "Weight Category";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBMI.Location = new System.Drawing.Point(6, 36);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(76, 20);
            this.lblBMI.TabIndex = 0;
            this.lblBMI.Text = "Your BMI";
            // 
            // grboxBMR
            // 
            this.grboxBMR.Controls.Add(this.lblListBoxItem);
            this.grboxBMR.Controls.Add(this.lboxBMR);
            this.grboxBMR.Controls.Add(this.btnUnselect);
            this.grboxBMR.Controls.Add(this.btnBMRCalc);
            this.grboxBMR.Controls.Add(this.txtAge);
            this.grboxBMR.Controls.Add(this.lblAge);
            this.grboxBMR.Controls.Add(this.rbtnMale);
            this.grboxBMR.Controls.Add(this.rbtnFemale);
            this.grboxBMR.Controls.Add(this.grboxActivityBMR);
            this.grboxBMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxBMR.ForeColor = System.Drawing.Color.Blue;
            this.grboxBMR.Location = new System.Drawing.Point(12, 518);
            this.grboxBMR.Name = "grboxBMR";
            this.grboxBMR.Size = new System.Drawing.Size(990, 438);
            this.grboxBMR.TabIndex = 3;
            this.grboxBMR.TabStop = false;
            this.grboxBMR.Text = "BMR";
            // 
            // lblListBoxItem
            // 
            this.lblListBoxItem.AutoSize = true;
            this.lblListBoxItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListBoxItem.ForeColor = System.Drawing.Color.Blue;
            this.lblListBoxItem.Location = new System.Drawing.Point(419, 408);
            this.lblListBoxItem.Name = "lblListBoxItem";
            this.lblListBoxItem.Size = new System.Drawing.Size(28, 16);
            this.lblListBoxItem.TabIndex = 9;
            this.lblListBoxItem.Text = "Out";
            // 
            // lboxBMR
            // 
            this.lboxBMR.ForeColor = System.Drawing.Color.Blue;
            this.lboxBMR.FormattingEnabled = true;
            this.lboxBMR.ItemHeight = 20;
            this.lboxBMR.Location = new System.Drawing.Point(422, 16);
            this.lboxBMR.Name = "lboxBMR";
            this.lboxBMR.Size = new System.Drawing.Size(562, 384);
            this.lboxBMR.TabIndex = 8;
            this.lboxBMR.SelectedIndexChanged += new System.EventHandler(this.lboxBMR_SelectedIndexChanged);
            // 
            // btnUnselect
            // 
            this.btnUnselect.BackColor = System.Drawing.Color.Silver;
            this.btnUnselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnselect.ForeColor = System.Drawing.Color.Blue;
            this.btnUnselect.Location = new System.Drawing.Point(909, 402);
            this.btnUnselect.Name = "btnUnselect";
            this.btnUnselect.Size = new System.Drawing.Size(75, 28);
            this.btnUnselect.TabIndex = 7;
            this.btnUnselect.Text = "Unselect";
            this.btnUnselect.UseVisualStyleBackColor = false;
            this.btnUnselect.Click += new System.EventHandler(this.btnUnselect_Click);
            // 
            // btnBMRCalc
            // 
            this.btnBMRCalc.BackColor = System.Drawing.Color.Silver;
            this.btnBMRCalc.ForeColor = System.Drawing.Color.Blue;
            this.btnBMRCalc.Location = new System.Drawing.Point(128, 397);
            this.btnBMRCalc.Name = "btnBMRCalc";
            this.btnBMRCalc.Size = new System.Drawing.Size(111, 33);
            this.btnBMRCalc.TabIndex = 6;
            this.btnBMRCalc.Text = "Calculate";
            this.btnBMRCalc.UseVisualStyleBackColor = false;
            this.btnBMRCalc.Click += new System.EventHandler(this.btnBMRCalc_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(356, 100);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(47, 26);
            this.txtAge.TabIndex = 5;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAge.Location = new System.Drawing.Point(16, 100);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 20);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnMale.Location = new System.Drawing.Point(203, 48);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(61, 24);
            this.rbtnMale.TabIndex = 3;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            this.rbtnMale.CheckedChanged += new System.EventHandler(this.btnBMRCalc_Click);
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnFemale.Location = new System.Drawing.Point(16, 48);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(80, 24);
            this.rbtnFemale.TabIndex = 2;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // grboxActivityBMR
            // 
            this.grboxActivityBMR.Controls.Add(this.rbtnExtraActive);
            this.grboxActivityBMR.Controls.Add(this.rbtnVeryActive);
            this.grboxActivityBMR.Controls.Add(this.rbtnModerately);
            this.grboxActivityBMR.Controls.Add(this.rbtnLightly);
            this.grboxActivityBMR.Controls.Add(this.rbtnSedetary);
            this.grboxActivityBMR.Location = new System.Drawing.Point(6, 172);
            this.grboxActivityBMR.Name = "grboxActivityBMR";
            this.grboxActivityBMR.Size = new System.Drawing.Size(397, 219);
            this.grboxActivityBMR.TabIndex = 0;
            this.grboxActivityBMR.TabStop = false;
            this.grboxActivityBMR.Text = "Activity lever per week";
            // 
            // rbtnExtraActive
            // 
            this.rbtnExtraActive.AutoSize = true;
            this.rbtnExtraActive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnExtraActive.Location = new System.Drawing.Point(10, 161);
            this.rbtnExtraActive.Name = "rbtnExtraActive";
            this.rbtnExtraActive.Size = new System.Drawing.Size(262, 24);
            this.rbtnExtraActive.TabIndex = 4;
            this.rbtnExtraActive.TabStop = true;
            this.rbtnExtraActive.Text = "Extra active, hard exercises or job";
            this.rbtnExtraActive.UseVisualStyleBackColor = true;
            // 
            // rbtnVeryActive
            // 
            this.rbtnVeryActive.AutoSize = true;
            this.rbtnVeryActive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnVeryActive.Location = new System.Drawing.Point(10, 130);
            this.rbtnVeryActive.Name = "rbtnVeryActive";
            this.rbtnVeryActive.Size = new System.Drawing.Size(200, 24);
            this.rbtnVeryActive.TabIndex = 3;
            this.rbtnVeryActive.TabStop = true;
            this.rbtnVeryActive.Text = "Very active (6 to 7 times)";
            this.rbtnVeryActive.UseVisualStyleBackColor = true;
            // 
            // rbtnModerately
            // 
            this.rbtnModerately.AutoSize = true;
            this.rbtnModerately.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnModerately.Location = new System.Drawing.Point(10, 99);
            this.rbtnModerately.Name = "rbtnModerately";
            this.rbtnModerately.Size = new System.Drawing.Size(246, 24);
            this.rbtnModerately.TabIndex = 2;
            this.rbtnModerately.TabStop = true;
            this.rbtnModerately.Text = "Moderately active (3 to 5 times)";
            this.rbtnModerately.UseVisualStyleBackColor = true;
            // 
            // rbtnLightly
            // 
            this.rbtnLightly.AutoSize = true;
            this.rbtnLightly.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnLightly.Location = new System.Drawing.Point(10, 68);
            this.rbtnLightly.Name = "rbtnLightly";
            this.rbtnLightly.Size = new System.Drawing.Size(213, 24);
            this.rbtnLightly.TabIndex = 1;
            this.rbtnLightly.TabStop = true;
            this.rbtnLightly.Text = "Lightly active (1 to 3 times)";
            this.rbtnLightly.UseVisualStyleBackColor = true;
            // 
            // rbtnSedetary
            // 
            this.rbtnSedetary.AutoSize = true;
            this.rbtnSedetary.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnSedetary.Location = new System.Drawing.Point(10, 37);
            this.rbtnSedetary.Name = "rbtnSedetary";
            this.rbtnSedetary.Size = new System.Drawing.Size(235, 24);
            this.rbtnSedetary.TabIndex = 0;
            this.rbtnSedetary.TabStop = true;
            this.rbtnSedetary.Text = "Sedetary (little or no exercise)";
            this.rbtnSedetary.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1014, 961);
            this.Controls.Add(this.grboxBMR);
            this.Controls.Add(this.grboxBMI);
            this.Controls.Add(this.grboxFuel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Universal calculator";
            this.grboxFuel.ResumeLayout(false);
            this.grboxFuel.PerformLayout();
            this.grboxFuelResults.ResumeLayout(false);
            this.grboxFuelResults.PerformLayout();
            this.grboxBMI.ResumeLayout(false);
            this.grboxBMI.PerformLayout();
            this.grboxResultsBMI.ResumeLayout(false);
            this.grboxResultsBMI.PerformLayout();
            this.grboxBMR.ResumeLayout(false);
            this.grboxBMR.PerformLayout();
            this.grboxActivityBMR.ResumeLayout(false);
            this.grboxActivityBMR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grboxFuel;
        private System.Windows.Forms.GroupBox grboxFuelResults;
        private System.Windows.Forms.GroupBox grboxBMI;
        private System.Windows.Forms.GroupBox grboxResultsBMI;
        private System.Windows.Forms.GroupBox grboxBMR;
        private System.Windows.Forms.GroupBox grboxActivityBMR;
        private System.Windows.Forms.TextBox txtPriceFuel;
        private System.Windows.Forms.TextBox txtCurrFuel;
        private System.Windows.Forms.TextBox txtPrevReading;
        private System.Windows.Forms.TextBox txtCurrReading;
        private System.Windows.Forms.Button btnFuelCalc;
        private System.Windows.Forms.Label lblPriceFuel;
        private System.Windows.Forms.Label lblCurrFuel;
        private System.Windows.Forms.Label lblPrevReading;
        private System.Windows.Forms.Label lblCurrReading;
        private System.Windows.Forms.Label lblCostKM;
        private System.Windows.Forms.Label lblFuelConsLSM;
        private System.Windows.Forms.Label lblFuelConsLMM;
        private System.Windows.Forms.Label lblFuelConsLK;
        private System.Windows.Forms.Label lblFuelConsKL;
        private System.Windows.Forms.Label lblCostKMOUT;
        private System.Windows.Forms.Label lblFuelConsLSMOUT;
        private System.Windows.Forms.Label lblFuelConsLMMOUT;
        private System.Windows.Forms.Label lblFuelConsLKOUT;
        private System.Windows.Forms.Label lblFuelConsKLOUT;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnBMICalc;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.RadioButton rbtnImperial;
        private System.Windows.Forms.RadioButton rbtnMetric;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNormalBMI;
        private System.Windows.Forms.Label lblWCategoryOUT;
        private System.Windows.Forms.Label lblBMIOUT;
        private System.Windows.Forms.Label lblWCategory;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Button btnUnselect;
        private System.Windows.Forms.Button btnBMRCalc;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnExtraActive;
        private System.Windows.Forms.RadioButton rbtnVeryActive;
        private System.Windows.Forms.RadioButton rbtnModerately;
        private System.Windows.Forms.RadioButton rbtnLightly;
        private System.Windows.Forms.RadioButton rbtnSedetary;
        private System.Windows.Forms.ListBox lboxBMR;
        private System.Windows.Forms.Label lblListBoxItem;
    }
}

