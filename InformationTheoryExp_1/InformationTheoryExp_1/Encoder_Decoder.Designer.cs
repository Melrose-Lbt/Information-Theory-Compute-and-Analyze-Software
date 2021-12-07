
namespace InformationTheoryExp_1
{
    partial class Encoder_Decoder
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
            this.Huffman_Encoder = new System.Windows.Forms.Button();
            this.LZ_Encoder = new System.Windows.Forms.Button();
            this.EncodeTextbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HUFEncode = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LZ_Decoder = new System.Windows.Forms.Button();
            this.Huffman_Decoder = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.hufcodelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DecodeBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.EncodeBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ProbOfHuff = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // Huffman_Encoder
            // 
            this.Huffman_Encoder.BackColor = System.Drawing.Color.Silver;
            this.Huffman_Encoder.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Huffman_Encoder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Huffman_Encoder.Location = new System.Drawing.Point(17, 156);
            this.Huffman_Encoder.Name = "Huffman_Encoder";
            this.Huffman_Encoder.Size = new System.Drawing.Size(81, 33);
            this.Huffman_Encoder.TabIndex = 4;
            this.Huffman_Encoder.Text = "Encode";
            this.Huffman_Encoder.UseVisualStyleBackColor = false;
            this.Huffman_Encoder.Click += new System.EventHandler(this.Huffman_Encoder_Click);
            // 
            // LZ_Encoder
            // 
            this.LZ_Encoder.BackColor = System.Drawing.Color.Silver;
            this.LZ_Encoder.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LZ_Encoder.Location = new System.Drawing.Point(22, 24);
            this.LZ_Encoder.Name = "LZ_Encoder";
            this.LZ_Encoder.Size = new System.Drawing.Size(159, 39);
            this.LZ_Encoder.TabIndex = 5;
            this.LZ_Encoder.Text = "LZ Encode";
            this.LZ_Encoder.UseVisualStyleBackColor = false;
            this.LZ_Encoder.Click += new System.EventHandler(this.LZ_Encoder_Click);
            // 
            // EncodeTextbox
            // 
            this.EncodeTextbox.Location = new System.Drawing.Point(17, 50);
            this.EncodeTextbox.Multiline = true;
            this.EncodeTextbox.Name = "EncodeTextbox";
            this.EncodeTextbox.Size = new System.Drawing.Size(141, 34);
            this.EncodeTextbox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HUFEncode);
            this.groupBox1.Controls.Add(this.LZ_Encoder);
            this.groupBox1.Location = new System.Drawing.Point(212, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 142);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // HUFEncode
            // 
            this.HUFEncode.BackColor = System.Drawing.Color.Silver;
            this.HUFEncode.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HUFEncode.Location = new System.Drawing.Point(22, 77);
            this.HUFEncode.Name = "HUFEncode";
            this.HUFEncode.Size = new System.Drawing.Size(159, 36);
            this.HUFEncode.TabIndex = 20;
            this.HUFEncode.Text = "Huffman Encode";
            this.HUFEncode.UseVisualStyleBackColor = false;
            this.HUFEncode.Click += new System.EventHandler(this.HUFEncode_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LZ_Decoder);
            this.groupBox2.Controls.Add(this.Huffman_Decoder);
            this.groupBox2.Location = new System.Drawing.Point(212, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 140);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // LZ_Decoder
            // 
            this.LZ_Decoder.BackColor = System.Drawing.Color.Silver;
            this.LZ_Decoder.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LZ_Decoder.Location = new System.Drawing.Point(22, 31);
            this.LZ_Decoder.Name = "LZ_Decoder";
            this.LZ_Decoder.Size = new System.Drawing.Size(160, 36);
            this.LZ_Decoder.TabIndex = 5;
            this.LZ_Decoder.Text = "LZ Decode";
            this.LZ_Decoder.UseVisualStyleBackColor = false;
            this.LZ_Decoder.Click += new System.EventHandler(this.LZ_Decoder_Click);
            // 
            // Huffman_Decoder
            // 
            this.Huffman_Decoder.BackColor = System.Drawing.Color.Silver;
            this.Huffman_Decoder.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Huffman_Decoder.Location = new System.Drawing.Point(22, 80);
            this.Huffman_Decoder.Name = "Huffman_Decoder";
            this.Huffman_Decoder.Size = new System.Drawing.Size(160, 33);
            this.Huffman_Decoder.TabIndex = 4;
            this.Huffman_Decoder.Text = "Huffman Decode";
            this.Huffman_Decoder.UseVisualStyleBackColor = false;
            this.Huffman_Decoder.Click += new System.EventHandler(this.Huffman_Decoder_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.hufcodelabel);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(437, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 136);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Code";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = " ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "LZW";
            // 
            // hufcodelabel
            // 
            this.hufcodelabel.AutoSize = true;
            this.hufcodelabel.Location = new System.Drawing.Point(6, 96);
            this.hufcodelabel.Name = "hufcodelabel";
            this.hufcodelabel.Size = new System.Drawing.Size(12, 17);
            this.hufcodelabel.TabIndex = 1;
            this.hufcodelabel.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hufcode:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(16, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = " ";
            // 
            // DecodeBox
            // 
            this.DecodeBox.Location = new System.Drawing.Point(26, 242);
            this.DecodeBox.Multiline = true;
            this.DecodeBox.Name = "DecodeBox";
            this.DecodeBox.Size = new System.Drawing.Size(160, 34);
            this.DecodeBox.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(437, 186);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 140);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Code";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = " ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "LZW";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Hufcode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = " ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.EncodeBox);
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.DecodeBox);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Location = new System.Drawing.Point(427, 56);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(645, 382);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            // 
            // EncodeBox
            // 
            this.EncodeBox.Location = new System.Drawing.Point(26, 82);
            this.EncodeBox.Multiline = true;
            this.EncodeBox.Name = "EncodeBox";
            this.EncodeBox.Size = new System.Drawing.Size(160, 34);
            this.EncodeBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(17, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "对应符号的概率";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(17, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "符号序列";
            // 
            // ProbOfHuff
            // 
            this.ProbOfHuff.Location = new System.Drawing.Point(17, 107);
            this.ProbOfHuff.Multiline = true;
            this.ProbOfHuff.Name = "ProbOfHuff";
            this.ProbOfHuff.Size = new System.Drawing.Size(141, 34);
            this.ProbOfHuff.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(990, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(414, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 38);
            this.label5.TabIndex = 16;
            this.label5.Text = "Encoder Decoder System";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.EncodeTextbox);
            this.groupBox6.Controls.Add(this.Huffman_Encoder);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.ProbOfHuff);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Location = new System.Drawing.Point(12, 56);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(391, 202);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Huffman";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox7.Location = new System.Drawing.Point(176, 22);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 157);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Huffman 码表";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.button2);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.textBox1);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox8.Location = new System.Drawing.Point(12, 266);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(391, 172);
            this.groupBox8.TabIndex = 19;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "LZ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "LZ 码表";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(285, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 32);
            this.button2.TabIndex = 19;
            this.button2.Text = "Generate";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(17, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "单符号序列";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 25);
            this.textBox1.TabIndex = 14;
            // 
            // Encoder_Decoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1093, 573);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Name = "Encoder_Decoder";
            this.Text = "Encoder_Decoder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Huffman_Encoder;
        private System.Windows.Forms.Button LZ_Encoder;
        private System.Windows.Forms.TextBox EncodeTextbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LZ_Decoder;
        private System.Windows.Forms.Button Huffman_Decoder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox DecodeBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ProbOfHuff;
        private System.Windows.Forms.TextBox EncodeBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button HUFEncode;
        private System.Windows.Forms.Label hufcodelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
    }
}