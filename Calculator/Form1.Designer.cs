namespace Calculator
{
    partial class Form1
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBS = new DevComponents.DotNetBar.ButtonX();
            this.btnCE = new DevComponents.DotNetBar.ButtonX();
            this.btnC = new DevComponents.DotNetBar.ButtonX();
            this.btnPM = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btn9 = new DevComponents.DotNetBar.ButtonX();
            this.btn8 = new DevComponents.DotNetBar.ButtonX();
            this.btn7 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.btn6 = new DevComponents.DotNetBar.ButtonX();
            this.btn5 = new DevComponents.DotNetBar.ButtonX();
            this.btn4 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX9 = new DevComponents.DotNetBar.ButtonX();
            this.btn3 = new DevComponents.DotNetBar.ButtonX();
            this.btn2 = new DevComponents.DotNetBar.ButtonX();
            this.btn1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX13 = new DevComponents.DotNetBar.ButtonX();
            this.btnEquals = new DevComponents.DotNetBar.ButtonX();
            this.buttonX15 = new DevComponents.DotNetBar.ButtonX();
            this.btn0 = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnMinimum = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.Gray;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDisplay.Font = new System.Drawing.Font("IRANSansWeb", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.ForeColor = System.Drawing.Color.White;
            this.txtDisplay.Location = new System.Drawing.Point(0, 30);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(278, 105);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TabStop = false;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(127, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMinimum);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 30);
            this.panel1.TabIndex = 21;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnBS
            // 
            this.btnBS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBS.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBS.Location = new System.Drawing.Point(1, 131);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(68, 56);
            this.btnBS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBS.Symbol = "57674";
            this.btnBS.SymbolColor = System.Drawing.Color.White;
            this.btnBS.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnBS.TabIndex = 22;
            this.btnBS.Click += new System.EventHandler(this.btnBS_Click);
            // 
            // btnCE
            // 
            this.btnCE.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCE.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCE.Location = new System.Drawing.Point(70, 131);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(68, 56);
            this.btnCE.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCE.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnCE.TabIndex = 23;
            this.btnCE.Text = "CE";
            this.btnCE.TextColor = System.Drawing.Color.White;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnC.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnC.Location = new System.Drawing.Point(139, 131);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(68, 56);
            this.btnC.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnC.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnC.TabIndex = 24;
            this.btnC.Text = "C";
            this.btnC.TextColor = System.Drawing.Color.White;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnPM
            // 
            this.btnPM.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPM.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPM.Location = new System.Drawing.Point(1, 362);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(68, 56);
            this.btnPM.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPM.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnPM.TabIndex = 25;
            this.btnPM.Text = "±";
            this.btnPM.TextColor = System.Drawing.Color.White;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX1.Location = new System.Drawing.Point(209, 131);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(68, 56);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX1.TabIndex = 29;
            this.buttonX1.Text = "+";
            this.buttonX1.TextColor = System.Drawing.Color.White;
            this.buttonX1.Click += new System.EventHandler(this.Operational_Function);
            // 
            // btn9
            // 
            this.btn9.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn9.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn9.Location = new System.Drawing.Point(140, 189);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(68, 56);
            this.btn9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn9.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn9.TabIndex = 28;
            this.btn9.Text = "9";
            this.btn9.TextColor = System.Drawing.Color.White;
            this.btn9.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn8
            // 
            this.btn8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn8.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn8.Location = new System.Drawing.Point(71, 189);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(68, 56);
            this.btn8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn8.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn8.TabIndex = 27;
            this.btn8.Text = "8";
            this.btn8.TextColor = System.Drawing.Color.White;
            this.btn8.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn7
            // 
            this.btn7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn7.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn7.Location = new System.Drawing.Point(2, 189);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(68, 56);
            this.btn7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn7.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn7.TabIndex = 26;
            this.btn7.Text = "7";
            this.btn7.TextColor = System.Drawing.Color.White;
            this.btn7.Click += new System.EventHandler(this.NumericValue);
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX5.Location = new System.Drawing.Point(209, 188);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(68, 56);
            this.buttonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX5.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX5.TabIndex = 33;
            this.buttonX5.Text = "-";
            this.buttonX5.TextColor = System.Drawing.Color.White;
            this.buttonX5.Click += new System.EventHandler(this.Operational_Function);
            // 
            // btn6
            // 
            this.btn6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn6.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn6.Location = new System.Drawing.Point(140, 246);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(68, 56);
            this.btn6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn6.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn6.TabIndex = 32;
            this.btn6.Text = "6";
            this.btn6.TextColor = System.Drawing.Color.White;
            this.btn6.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn5
            // 
            this.btn5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn5.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn5.Location = new System.Drawing.Point(71, 246);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(68, 56);
            this.btn5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn5.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn5.TabIndex = 31;
            this.btn5.Text = "5";
            this.btn5.TextColor = System.Drawing.Color.White;
            this.btn5.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn4
            // 
            this.btn4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn4.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn4.Location = new System.Drawing.Point(2, 246);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(68, 56);
            this.btn4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn4.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn4.TabIndex = 30;
            this.btn4.Text = "4";
            this.btn4.TextColor = System.Drawing.Color.White;
            this.btn4.Click += new System.EventHandler(this.NumericValue);
            // 
            // buttonX9
            // 
            this.buttonX9.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonX9.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX9.Location = new System.Drawing.Point(209, 246);
            this.buttonX9.Name = "buttonX9";
            this.buttonX9.Size = new System.Drawing.Size(68, 56);
            this.buttonX9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX9.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX9.TabIndex = 37;
            this.buttonX9.Text = "*";
            this.buttonX9.TextColor = System.Drawing.Color.White;
            this.buttonX9.Click += new System.EventHandler(this.Operational_Function);
            // 
            // btn3
            // 
            this.btn3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn3.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn3.Location = new System.Drawing.Point(140, 304);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(68, 56);
            this.btn3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn3.TabIndex = 36;
            this.btn3.Text = "3";
            this.btn3.TextColor = System.Drawing.Color.White;
            this.btn3.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn2
            // 
            this.btn2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn2.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn2.Location = new System.Drawing.Point(71, 304);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(68, 56);
            this.btn2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn2.TabIndex = 35;
            this.btn2.Text = "2";
            this.btn2.TextColor = System.Drawing.Color.White;
            this.btn2.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn1
            // 
            this.btn1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn1.Location = new System.Drawing.Point(2, 304);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(68, 56);
            this.btn1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn1.TabIndex = 34;
            this.btn1.Text = "1";
            this.btn1.TextColor = System.Drawing.Color.White;
            this.btn1.Click += new System.EventHandler(this.NumericValue);
            // 
            // buttonX13
            // 
            this.buttonX13.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonX13.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX13.Location = new System.Drawing.Point(209, 304);
            this.buttonX13.Name = "buttonX13";
            this.buttonX13.Size = new System.Drawing.Size(68, 56);
            this.buttonX13.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX13.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX13.TabIndex = 41;
            this.buttonX13.Text = "/";
            this.buttonX13.TextColor = System.Drawing.Color.White;
            this.buttonX13.Click += new System.EventHandler(this.Operational_Function);
            // 
            // btnEquals
            // 
            this.btnEquals.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEquals.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEquals.Location = new System.Drawing.Point(209, 362);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(68, 56);
            this.btnEquals.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEquals.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnEquals.TabIndex = 1;
            this.btnEquals.Text = "=";
            this.btnEquals.TextColor = System.Drawing.Color.White;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // buttonX15
            // 
            this.buttonX15.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonX15.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX15.Location = new System.Drawing.Point(140, 362);
            this.buttonX15.Name = "buttonX15";
            this.buttonX15.Size = new System.Drawing.Size(68, 56);
            this.buttonX15.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX15.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX15.TabIndex = 39;
            this.buttonX15.Text = ".";
            this.buttonX15.TextColor = System.Drawing.Color.White;
            this.buttonX15.Click += new System.EventHandler(this.NumericValue);
            // 
            // btn0
            // 
            this.btn0.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn0.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn0.Location = new System.Drawing.Point(71, 362);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(68, 56);
            this.btn0.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn0.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn0.TabIndex = 38;
            this.btn0.Text = "0";
            this.btn0.TextColor = System.Drawing.Color.White;
            this.btn0.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.Location = new System.Drawing.Point(253, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 24);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.Symbol = "57676";
            this.btnClose.SymbolColor = System.Drawing.Color.White;
            this.btnClose.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnClose.SymbolSize = 14F;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimum
            // 
            this.btnMinimum.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMinimum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimum.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnMinimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnMinimum.Location = new System.Drawing.Point(232, 3);
            this.btnMinimum.Name = "btnMinimum";
            this.btnMinimum.Size = new System.Drawing.Size(22, 24);
            this.btnMinimum.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMinimum.Symbol = "57691";
            this.btnMinimum.SymbolColor = System.Drawing.Color.White;
            this.btnMinimum.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnMinimum.SymbolSize = 14F;
            this.btnMinimum.TabIndex = 0;
            this.btnMinimum.TabStop = false;
            this.btnMinimum.TextColor = System.Drawing.Color.White;
            this.btnMinimum.Click += new System.EventHandler(this.btnMinimum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(278, 418);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonX13);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.buttonX15);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.buttonX9);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.buttonX5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnBS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btnBS;
        private DevComponents.DotNetBar.ButtonX btnCE;
        private DevComponents.DotNetBar.ButtonX btnC;
        private DevComponents.DotNetBar.ButtonX btnPM;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btn9;
        private DevComponents.DotNetBar.ButtonX btn8;
        private DevComponents.DotNetBar.ButtonX btn7;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private DevComponents.DotNetBar.ButtonX btn6;
        private DevComponents.DotNetBar.ButtonX btn5;
        private DevComponents.DotNetBar.ButtonX btn4;
        private DevComponents.DotNetBar.ButtonX buttonX9;
        private DevComponents.DotNetBar.ButtonX btn3;
        private DevComponents.DotNetBar.ButtonX btn2;
        private DevComponents.DotNetBar.ButtonX btn1;
        private DevComponents.DotNetBar.ButtonX buttonX13;
        private DevComponents.DotNetBar.ButtonX btnEquals;
        private DevComponents.DotNetBar.ButtonX buttonX15;
        private DevComponents.DotNetBar.ButtonX btn0;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnMinimum;
        private System.Windows.Forms.Label label1;
    }
}

