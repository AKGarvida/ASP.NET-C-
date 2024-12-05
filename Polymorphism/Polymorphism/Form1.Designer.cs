namespace Polymorphism
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
            this.btn1parameter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn2parameter = new System.Windows.Forms.Button();
            this.btn3parameter = new System.Windows.Forms.Button();
            this.btn4parameter = new System.Windows.Forms.Button();
            this.btnVirtual = new System.Windows.Forms.Button();
            this.btnOverride = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1parameter
            // 
            this.btn1parameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1parameter.Location = new System.Drawing.Point(385, 14);
            this.btn1parameter.Name = "btn1parameter";
            this.btn1parameter.Size = new System.Drawing.Size(188, 68);
            this.btn1parameter.TabIndex = 0;
            this.btn1parameter.Text = "1Parameter";
            this.btn1parameter.UseVisualStyleBackColor = true;
            this.btn1parameter.Click += new System.EventHandler(this.btn1parameter_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 426);
            this.textBox1.TabIndex = 1;
            // 
            // btn2parameter
            // 
            this.btn2parameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2parameter.Location = new System.Drawing.Point(594, 14);
            this.btn2parameter.Name = "btn2parameter";
            this.btn2parameter.Size = new System.Drawing.Size(188, 68);
            this.btn2parameter.TabIndex = 0;
            this.btn2parameter.Text = "2Parameter";
            this.btn2parameter.UseVisualStyleBackColor = true;
            this.btn2parameter.Click += new System.EventHandler(this.btn2parameter_Click);
            // 
            // btn3parameter
            // 
            this.btn3parameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3parameter.Location = new System.Drawing.Point(385, 114);
            this.btn3parameter.Name = "btn3parameter";
            this.btn3parameter.Size = new System.Drawing.Size(188, 68);
            this.btn3parameter.TabIndex = 0;
            this.btn3parameter.Text = "3Parameter";
            this.btn3parameter.UseVisualStyleBackColor = true;
            this.btn3parameter.Click += new System.EventHandler(this.btn3parameter_Click);
            // 
            // btn4parameter
            // 
            this.btn4parameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4parameter.Location = new System.Drawing.Point(594, 114);
            this.btn4parameter.Name = "btn4parameter";
            this.btn4parameter.Size = new System.Drawing.Size(188, 68);
            this.btn4parameter.TabIndex = 0;
            this.btn4parameter.Text = "4parameter";
            this.btn4parameter.UseVisualStyleBackColor = true;
            this.btn4parameter.Click += new System.EventHandler(this.btn4parameter_Click);
            // 
            // btnVirtual
            // 
            this.btnVirtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirtual.Location = new System.Drawing.Point(385, 370);
            this.btnVirtual.Name = "btnVirtual";
            this.btnVirtual.Size = new System.Drawing.Size(188, 68);
            this.btnVirtual.TabIndex = 0;
            this.btnVirtual.Text = "Virtual";
            this.btnVirtual.UseVisualStyleBackColor = true;
            this.btnVirtual.Click += new System.EventHandler(this.btnVirtual_Click);
            // 
            // btnOverride
            // 
            this.btnOverride.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverride.Location = new System.Drawing.Point(594, 370);
            this.btnOverride.Name = "btnOverride";
            this.btnOverride.Size = new System.Drawing.Size(188, 68);
            this.btnOverride.TabIndex = 0;
            this.btnOverride.Text = "Override";
            this.btnOverride.UseVisualStyleBackColor = true;
            this.btnOverride.Click += new System.EventHandler(this.btnOverride_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 469);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn4parameter);
            this.Controls.Add(this.btn3parameter);
            this.Controls.Add(this.btn2parameter);
            this.Controls.Add(this.btnOverride);
            this.Controls.Add(this.btnVirtual);
            this.Controls.Add(this.btn1parameter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1parameter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn2parameter;
        private System.Windows.Forms.Button btn3parameter;
        private System.Windows.Forms.Button btn4parameter;
        private System.Windows.Forms.Button btnVirtual;
        private System.Windows.Forms.Button btnOverride;
    }
}

