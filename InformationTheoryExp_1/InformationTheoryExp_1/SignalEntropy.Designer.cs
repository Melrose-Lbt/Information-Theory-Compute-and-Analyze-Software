
namespace InformationTheoryExp_1
{
    partial class SignalEntropy
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SigI1 = new System.Windows.Forms.Label();
            this.SrcEntropy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CalI = new System.Windows.Forms.Button();
            this.EntropyCal = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(213, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Signal Entropy";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(410, 91);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 93);
            this.textBox2.TabIndex = 2;
            // 
            // SigI1
            // 
            this.SigI1.AutoSize = true;
            this.SigI1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SigI1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SigI1.Location = new System.Drawing.Point(56, 191);
            this.SigI1.Name = "SigI1";
            this.SigI1.Size = new System.Drawing.Size(154, 21);
            this.SigI1.TabIndex = 3;
            this.SigI1.Text = "单符号的信息量为：";
            // 
            // SrcEntropy
            // 
            this.SrcEntropy.AutoSize = true;
            this.SrcEntropy.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SrcEntropy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SrcEntropy.Location = new System.Drawing.Point(282, 252);
            this.SrcEntropy.Name = "SrcEntropy";
            this.SrcEntropy.Size = new System.Drawing.Size(74, 21);
            this.SrcEntropy.TabIndex = 4;
            this.SrcEntropy.Text = "信源熵：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(282, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "信源数学模型：";
            // 
            // CalI
            // 
            this.CalI.Location = new System.Drawing.Point(145, 91);
            this.CalI.Name = "CalI";
            this.CalI.Size = new System.Drawing.Size(75, 23);
            this.CalI.TabIndex = 6;
            this.CalI.Text = "计算";
            this.CalI.UseVisualStyleBackColor = true;
            this.CalI.Click += new System.EventHandler(this.CalI_Click);
            // 
            // EntropyCal
            // 
            this.EntropyCal.Location = new System.Drawing.Point(493, 211);
            this.EntropyCal.Name = "EntropyCal";
            this.EntropyCal.Size = new System.Drawing.Size(75, 23);
            this.EntropyCal.TabIndex = 7;
            this.EntropyCal.Text = "计算";
            this.EntropyCal.UseVisualStyleBackColor = true;
            this.EntropyCal.Click += new System.EventHandler(this.EntropyCal_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(520, 325);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 8;
            this.Back.Text = "返回";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(201, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(350, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(56, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "I = log（1/P(X))";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(282, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "H(X)=-Σp(xi)logp(xi)";
            // 
            // SignalEntropy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(607, 360);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.EntropyCal);
            this.Controls.Add(this.CalI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SrcEntropy);
            this.Controls.Add(this.SigI1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "SignalEntropy";
            this.Text = "SignalEntropy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label SigI1;
        private System.Windows.Forms.Label SrcEntropy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CalI;
        private System.Windows.Forms.Button EntropyCal;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}