
namespace InformationTheoryExp_1
{
    partial class SystemFigure
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
            this.Entropy = new System.Windows.Forms.Button();
            this.DisEntropy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(226, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Information Source";
            // 
            // Entropy
            // 
            this.Entropy.BackColor = System.Drawing.Color.Silver;
            this.Entropy.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Entropy.Location = new System.Drawing.Point(121, 98);
            this.Entropy.Name = "Entropy";
            this.Entropy.Size = new System.Drawing.Size(154, 157);
            this.Entropy.TabIndex = 1;
            this.Entropy.Text = "Signal Entropy";
            this.Entropy.UseVisualStyleBackColor = false;
            this.Entropy.Click += new System.EventHandler(this.Entropy_Click);
            // 
            // DisEntropy
            // 
            this.DisEntropy.BackColor = System.Drawing.Color.Silver;
            this.DisEntropy.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DisEntropy.Location = new System.Drawing.Point(368, 98);
            this.DisEntropy.Name = "DisEntropy";
            this.DisEntropy.Size = new System.Drawing.Size(157, 157);
            this.DisEntropy.TabIndex = 2;
            this.DisEntropy.Text = "Discrete Sequence Entropy";
            this.DisEntropy.UseVisualStyleBackColor = false;
            this.DisEntropy.Click += new System.EventHandler(this.DisEntropy_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(368, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 157);
            this.button1.TabIndex = 3;
            this.button1.Text = "Information Source Coder";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(551, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(121, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 157);
            this.button3.TabIndex = 8;
            this.button3.Text = "Markov";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SystemFigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(645, 522);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DisEntropy);
            this.Controls.Add(this.Entropy);
            this.Controls.Add(this.label1);
            this.Name = "SystemFigure";
            this.Text = "SystemFigure";
            this.Load += new System.EventHandler(this.SystemFigure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Entropy;
        private System.Windows.Forms.Button DisEntropy;
        private System.Windows.Forms.Button Markov;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}