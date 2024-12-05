namespace JumpStatementsSample
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
            this.breakBtn = new System.Windows.Forms.Button();
            this.continueBtn = new System.Windows.Forms.Button();
            this.goToBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // breakBtn
            // 
            this.breakBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakBtn.Location = new System.Drawing.Point(382, 269);
            this.breakBtn.Name = "breakBtn";
            this.breakBtn.Size = new System.Drawing.Size(117, 49);
            this.breakBtn.TabIndex = 0;
            this.breakBtn.Text = "Break";
            this.breakBtn.UseVisualStyleBackColor = true;
            this.breakBtn.Click += new System.EventHandler(this.breakBtn_Click);
            // 
            // continueBtn
            // 
            this.continueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueBtn.Location = new System.Drawing.Point(521, 269);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(117, 49);
            this.continueBtn.TabIndex = 1;
            this.continueBtn.Text = "Continue";
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // goToBtn
            // 
            this.goToBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToBtn.Location = new System.Drawing.Point(658, 269);
            this.goToBtn.Name = "goToBtn";
            this.goToBtn.Size = new System.Drawing.Size(117, 49);
            this.goToBtn.TabIndex = 2;
            this.goToBtn.Text = "Go To";
            this.goToBtn.UseVisualStyleBackColor = true;
            this.goToBtn.Click += new System.EventHandler(this.goToBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goToBtn);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.breakBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button breakBtn;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Button goToBtn;
    }
}

