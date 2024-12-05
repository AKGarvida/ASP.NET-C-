namespace CountingProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbDivisibleTerm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDivisibleNumbers = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.chBold = new System.Windows.Forms.CheckBox();
            this.chItalic = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "To";
            // 
            // txtStartFrom
            // 
            this.txtStartFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartFrom.Location = new System.Drawing.Point(171, 36);
            this.txtStartFrom.Name = "txtStartFrom";
            this.txtStartFrom.Size = new System.Drawing.Size(224, 30);
            this.txtStartFrom.TabIndex = 1;
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(468, 36);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(216, 30);
            this.txtTo.TabIndex = 5;
            // 
            // btnCount
            // 
            this.btnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.Location = new System.Drawing.Point(427, 80);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(120, 43);
            this.btnCount.TabIndex = 6;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(570, 80);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 43);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbDivisibleTerm
            // 
            this.cmbDivisibleTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDivisibleTerm.FormattingEnabled = true;
            this.cmbDivisibleTerm.Location = new System.Drawing.Point(205, 90);
            this.cmbDivisibleTerm.Name = "cmbDivisibleTerm";
            this.cmbDivisibleTerm.Size = new System.Drawing.Size(190, 33);
            this.cmbDivisibleTerm.TabIndex = 2;
            this.cmbDivisibleTerm.SelectedIndexChanged += new System.EventHandler(this.cmbDivisibleTerm_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Divisible Number";
            // 
            // txtDivisibleNumbers
            // 
            this.txtDivisibleNumbers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDivisibleNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivisibleNumbers.Location = new System.Drawing.Point(0, 190);
            this.txtDivisibleNumbers.Multiline = true;
            this.txtDivisibleNumbers.Name = "txtDivisibleNumbers";
            this.txtDivisibleNumbers.Size = new System.Drawing.Size(1031, 260);
            this.txtDivisibleNumbers.TabIndex = 9;
            this.txtDivisibleNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGreen);
            this.groupBox1.Controls.Add(this.rbRed);
            this.groupBox1.Controls.Add(this.rbBlue);
            this.groupBox1.Controls.Add(this.rbBlack);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(690, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 172);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Color";
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Checked = true;
            this.rbBlack.Location = new System.Drawing.Point(16, 38);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(77, 24);
            this.rbBlack.TabIndex = 0;
            this.rbBlack.TabStop = true;
            this.rbBlack.Text = "Black";
            this.rbBlack.UseVisualStyleBackColor = true;
            this.rbBlack.CheckedChanged += new System.EventHandler(this.rbBlack_CheckedChanged);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(16, 98);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(68, 24);
            this.rbBlue.TabIndex = 2;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rbBlue_CheckedChanged);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(16, 68);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(63, 24);
            this.rbRed.TabIndex = 1;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.rbRed_CheckedChanged);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(16, 128);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(81, 24);
            this.rbGreen.TabIndex = 3;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rbGreen_CheckedChanged);
            // 
            // chBold
            // 
            this.chBold.AutoSize = true;
            this.chBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBold.Location = new System.Drawing.Point(17, 130);
            this.chBold.Name = "chBold";
            this.chBold.Size = new System.Drawing.Size(69, 24);
            this.chBold.TabIndex = 3;
            this.chBold.Text = "Bold";
            this.chBold.UseVisualStyleBackColor = true;
            this.chBold.CheckedChanged += new System.EventHandler(this.chBold_CheckedChanged);
            // 
            // chItalic
            // 
            this.chItalic.AutoSize = true;
            this.chItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chItalic.Location = new System.Drawing.Point(17, 160);
            this.chItalic.Name = "chItalic";
            this.chItalic.Size = new System.Drawing.Size(72, 24);
            this.chItalic.TabIndex = 4;
            this.chItalic.Text = "Italic";
            this.chItalic.UseVisualStyleBackColor = true;
            this.chItalic.CheckedChanged += new System.EventHandler(this.chItalic_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 450);
            this.Controls.Add(this.chItalic);
            this.Controls.Add(this.chBold);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDivisibleNumbers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDivisibleTerm);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtStartFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStartFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbDivisibleTerm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDivisibleNumbers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbBlack;
        private System.Windows.Forms.CheckBox chBold;
        private System.Windows.Forms.CheckBox chItalic;
    }
}

