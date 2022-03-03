
namespace ShowSystemInfos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OSBox = new System.Windows.Forms.TextBox();
            this.GrafikBox = new System.Windows.Forms.TextBox();
            this.ProcessorBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PrinterBox = new System.Windows.Forms.RichTextBox();
            this.DriveBox = new System.Windows.Forms.RichTextBox();
            this.ReadInfoBTN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.NetworkBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SoundBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.OSVersionBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SerialBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.RamBox = new System.Windows.Forms.TextBox();
            this.MainboardBox = new System.Windows.Forms.RichTextBox();
            this.Mainboard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OSBox
            // 
            this.OSBox.Location = new System.Drawing.Point(67, 29);
            this.OSBox.Name = "OSBox";
            this.OSBox.ReadOnly = true;
            this.OSBox.Size = new System.Drawing.Size(346, 23);
            this.OSBox.TabIndex = 0;
            // 
            // GrafikBox
            // 
            this.GrafikBox.Location = new System.Drawing.Point(793, 81);
            this.GrafikBox.Name = "GrafikBox";
            this.GrafikBox.ReadOnly = true;
            this.GrafikBox.Size = new System.Drawing.Size(346, 23);
            this.GrafikBox.TabIndex = 2;
            // 
            // ProcessorBox
            // 
            this.ProcessorBox.Location = new System.Drawing.Point(793, 28);
            this.ProcessorBox.Name = "ProcessorBox";
            this.ProcessorBox.ReadOnly = true;
            this.ProcessorBox.Size = new System.Drawing.Size(346, 23);
            this.ProcessorBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(929, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prozessor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(929, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Grafikkarte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Betriebssystem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(739, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Drucker:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Laufwerke:";
            // 
            // PrinterBox
            // 
            this.PrinterBox.Location = new System.Drawing.Point(623, 236);
            this.PrinterBox.Name = "PrinterBox";
            this.PrinterBox.ReadOnly = true;
            this.PrinterBox.Size = new System.Drawing.Size(279, 149);
            this.PrinterBox.TabIndex = 10;
            this.PrinterBox.Text = "";
            // 
            // DriveBox
            // 
            this.DriveBox.Location = new System.Drawing.Point(12, 237);
            this.DriveBox.Name = "DriveBox";
            this.DriveBox.ReadOnly = true;
            this.DriveBox.Size = new System.Drawing.Size(279, 148);
            this.DriveBox.TabIndex = 11;
            this.DriveBox.Text = "";
            // 
            // ReadInfoBTN
            // 
            this.ReadInfoBTN.Location = new System.Drawing.Point(555, 171);
            this.ReadInfoBTN.Name = "ReadInfoBTN";
            this.ReadInfoBTN.Size = new System.Drawing.Size(96, 45);
            this.ReadInfoBTN.TabIndex = 12;
            this.ReadInfoBTN.Text = "Auslesen";
            this.ReadInfoBTN.UseVisualStyleBackColor = true;
            this.ReadInfoBTN.Click += new System.EventHandler(this.ReadInfoBTN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Netzwerke:";
            // 
            // NetworkBox
            // 
            this.NetworkBox.Location = new System.Drawing.Point(317, 237);
            this.NetworkBox.Name = "NetworkBox";
            this.NetworkBox.ReadOnly = true;
            this.NetworkBox.Size = new System.Drawing.Size(279, 148);
            this.NetworkBox.TabIndex = 17;
            this.NetworkBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(544, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Systeminformationen";
            // 
            // SoundBox
            // 
            this.SoundBox.Location = new System.Drawing.Point(923, 237);
            this.SoundBox.Name = "SoundBox";
            this.SoundBox.ReadOnly = true;
            this.SoundBox.Size = new System.Drawing.Size(279, 148);
            this.SoundBox.TabIndex = 19;
            this.SoundBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1037, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Soundkarten:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Version:";
            // 
            // OSVersionBox
            // 
            this.OSVersionBox.Location = new System.Drawing.Point(67, 82);
            this.OSVersionBox.Name = "OSVersionBox";
            this.OSVersionBox.ReadOnly = true;
            this.OSVersionBox.Size = new System.Drawing.Size(346, 23);
            this.OSVersionBox.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(202, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Seriennummer:";
            // 
            // SerialBox
            // 
            this.SerialBox.Location = new System.Drawing.Point(67, 132);
            this.SerialBox.Name = "SerialBox";
            this.SerialBox.ReadOnly = true;
            this.SerialBox.Size = new System.Drawing.Size(346, 23);
            this.SerialBox.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(923, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Arbeitsspeicher:";
            // 
            // RamBox
            // 
            this.RamBox.Location = new System.Drawing.Point(793, 131);
            this.RamBox.Name = "RamBox";
            this.RamBox.ReadOnly = true;
            this.RamBox.Size = new System.Drawing.Size(346, 23);
            this.RamBox.TabIndex = 27;
            // 
            // MainboardBox
            // 
            this.MainboardBox.Location = new System.Drawing.Point(474, 33);
            this.MainboardBox.Name = "MainboardBox";
            this.MainboardBox.ReadOnly = true;
            this.MainboardBox.Size = new System.Drawing.Size(264, 96);
            this.MainboardBox.TabIndex = 28;
            this.MainboardBox.Text = "";
            // 
            // Mainboard
            // 
            this.Mainboard.AutoSize = true;
            this.Mainboard.Location = new System.Drawing.Point(575, 15);
            this.Mainboard.Name = "Mainboard";
            this.Mainboard.Size = new System.Drawing.Size(68, 15);
            this.Mainboard.TabIndex = 29;
            this.Mainboard.Text = "Mainboard:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 416);
            this.Controls.Add(this.Mainboard);
            this.Controls.Add(this.MainboardBox);
            this.Controls.Add(this.RamBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SerialBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.OSVersionBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SoundBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NetworkBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ReadInfoBTN);
            this.Controls.Add(this.DriveBox);
            this.Controls.Add(this.PrinterBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcessorBox);
            this.Controls.Add(this.GrafikBox);
            this.Controls.Add(this.OSBox);
            this.Name = "Form1";
            this.Text = "SystemInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OSBox;
        private System.Windows.Forms.TextBox GrafikBox;
        private System.Windows.Forms.TextBox ProcessorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox PrinterBox;
        private System.Windows.Forms.RichTextBox DriveBox;
        private System.Windows.Forms.Button ReadInfoBTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox NetworkBox;
        private System.Windows.Forms.RichTextBox SoundBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox OSVersionBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SerialBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox RamBox;
        private System.Windows.Forms.RichTextBox MainboardBox;
        private System.Windows.Forms.Label Mainboard;
    }
}

