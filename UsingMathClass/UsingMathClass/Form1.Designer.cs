namespace UsingMathClass
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCopyFirstNumber = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnLog10 = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnAbs = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnCopyFirstNumber);
            this.groupBox1.Controls.Add(this.btnExp);
            this.groupBox1.Controls.Add(this.btnLog10);
            this.groupBox1.Controls.Add(this.btnLog);
            this.groupBox1.Controls.Add(this.btnSqrt);
            this.groupBox1.Controls.Add(this.btnPow);
            this.groupBox1.Controls.Add(this.btnTan);
            this.groupBox1.Controls.Add(this.btnCos);
            this.groupBox1.Controls.Add(this.btnSin);
            this.groupBox1.Controls.Add(this.btnSign);
            this.groupBox1.Controls.Add(this.btnAbs);
            this.groupBox1.Controls.Add(this.btnMax);
            this.groupBox1.Controls.Add(this.btnMin);
            this.groupBox1.Controls.Add(this.btnC);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 474);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnCopyFirstNumber
            // 
            this.btnCopyFirstNumber.BackColor = System.Drawing.Color.Silver;
            this.btnCopyFirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyFirstNumber.Location = new System.Drawing.Point(190, 215);
            this.btnCopyFirstNumber.Name = "btnCopyFirstNumber";
            this.btnCopyFirstNumber.Size = new System.Drawing.Size(178, 53);
            this.btnCopyFirstNumber.TabIndex = 0;
            this.btnCopyFirstNumber.Text = "Copy First Number";
            this.btnCopyFirstNumber.UseVisualStyleBackColor = false;
            this.btnCopyFirstNumber.Click += new System.EventHandler(this.btnCopyFirstNumber_Click);
            // 
            // btnExp
            // 
            this.btnExp.BackColor = System.Drawing.Color.Silver;
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.Location = new System.Drawing.Point(6, 215);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(86, 53);
            this.btnExp.TabIndex = 0;
            this.btnExp.Text = "Exp";
            this.btnExp.UseVisualStyleBackColor = false;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnLog10
            // 
            this.btnLog10.BackColor = System.Drawing.Color.Silver;
            this.btnLog10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog10.Location = new System.Drawing.Point(282, 156);
            this.btnLog10.Name = "btnLog10";
            this.btnLog10.Size = new System.Drawing.Size(86, 53);
            this.btnLog10.TabIndex = 0;
            this.btnLog10.Text = "Log10";
            this.btnLog10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLog10.UseVisualStyleBackColor = false;
            this.btnLog10.Click += new System.EventHandler(this.btnLog10_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Silver;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(190, 156);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(86, 53);
            this.btnLog.TabIndex = 0;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.Color.Silver;
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.Location = new System.Drawing.Point(98, 156);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(86, 53);
            this.btnSqrt.TabIndex = 0;
            this.btnSqrt.Text = "Sqrt";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnPow
            // 
            this.btnPow.BackColor = System.Drawing.Color.Silver;
            this.btnPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPow.Location = new System.Drawing.Point(6, 156);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(86, 53);
            this.btnPow.TabIndex = 0;
            this.btnPow.Text = "Pow";
            this.btnPow.UseVisualStyleBackColor = false;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.Color.Silver;
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTan.Location = new System.Drawing.Point(282, 97);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(86, 53);
            this.btnTan.TabIndex = 0;
            this.btnTan.Text = "Tan";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.Color.Silver;
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.Location = new System.Drawing.Point(190, 97);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(86, 53);
            this.btnCos.TabIndex = 0;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.Color.Silver;
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.Location = new System.Drawing.Point(98, 97);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(86, 53);
            this.btnSin.TabIndex = 0;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.Silver;
            this.btnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.Location = new System.Drawing.Point(6, 97);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(86, 53);
            this.btnSign.TabIndex = 0;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnAbs
            // 
            this.btnAbs.BackColor = System.Drawing.Color.Silver;
            this.btnAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbs.Location = new System.Drawing.Point(282, 38);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.Size = new System.Drawing.Size(86, 53);
            this.btnAbs.TabIndex = 0;
            this.btnAbs.Text = "Abs";
            this.btnAbs.UseVisualStyleBackColor = false;
            this.btnAbs.Click += new System.EventHandler(this.btnAbs_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.Silver;
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.Location = new System.Drawing.Point(190, 38);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(86, 53);
            this.btnMax.TabIndex = 0;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Silver;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(98, 38);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(86, 53);
            this.btnMin.TabIndex = 0;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Silver;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(6, 38);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(86, 53);
            this.btnC.TabIndex = 0;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstNumber.Location = new System.Drawing.Point(514, 50);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(213, 30);
            this.txtFirstNumber.TabIndex = 1;
            this.txtFirstNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstNumber_KeyPress);
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondNumber.Location = new System.Drawing.Point(514, 109);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(213, 30);
            this.txtSecondNumber.TabIndex = 1;
            this.txtSecondNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecondNumber_KeyPress);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(514, 169);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(213, 30);
            this.txtResult.TabIndex = 1;
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNumber.Location = new System.Drawing.Point(771, 50);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(135, 25);
            this.lblFirstNumber.TabIndex = 2;
            this.lblFirstNumber.Text = "First Number";
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondNumber.Location = new System.Drawing.Point(771, 109);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(167, 25);
            this.lblSecondNumber.TabIndex = 2;
            this.lblSecondNumber.Text = "Second Number";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(771, 169);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(72, 25);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(6, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 53);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 591);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSecondNumber);
            this.Controls.Add(this.lblFirstNumber);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.txtFirstNumber);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCopyFirstNumber;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnLog10;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnAbs;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnExit;
    }
}

