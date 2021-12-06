
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
            this.hufcodelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DecodeBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.EncodeBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ProbOfHuff = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Codelist = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(212, 170);
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
            this.label6.Location = new System.Drawing.Point(33, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = " ";
            // 
            // DecodeBox
            // 
            this.DecodeBox.Location = new System.Drawing.Point(26, 228);
            this.DecodeBox.Multiline = true;
            this.DecodeBox.Name = "DecodeBox";
            this.DecodeBox.Size = new System.Drawing.Size(160, 34);
            this.DecodeBox.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(437, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 140);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Code";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.EncodeBox);
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.DecodeBox);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Location = new System.Drawing.Point(358, 56);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(645, 344);
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
            this.button1.Location = new System.Drawing.Point(921, 483);
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
            this.label5.Location = new System.Drawing.Point(308, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 38);
            this.label5.TabIndex = 16;
            this.label5.Text = "Encoder Decoder System";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.EncodeTextbox);
            this.groupBox6.Controls.Add(this.Huffman_Encoder);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.ProbOfHuff);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Location = new System.Drawing.Point(12, 56);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(176, 202);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Huffman";
            // 
            // Codelist
            // 
            this.Codelist.AutoSize = true;
            this.Codelist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Codelist.Location = new System.Drawing.Point(33, 276);
            this.Codelist.Name = "Codelist";
            this.Codelist.Size = new System.Drawing.Size(81, 17);
            this.Codelist.TabIndex = 19;
            this.Codelist.Text = "Huffman码表";
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
            // Encoder_Decoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1024, 534);
            this.Controls.Add(this.Codelist);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.Label Codelist;
        private System.Windows.Forms.Button HUFEncode;
        private System.Windows.Forms.Label hufcodelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}