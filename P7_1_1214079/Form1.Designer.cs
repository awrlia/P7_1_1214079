namespace P7_1_1214079
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
            this.components = new System.ComponentModel.Container();
            this.tbNim = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.tbTA = new System.Windows.Forms.TextBox();
            this.tbSemester = new System.Windows.Forms.TextBox();
            this.cbPS = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Kr2006 = new System.Windows.Forms.RadioButton();
            this.Kr2010 = new System.Windows.Forms.RadioButton();
            this.Kr2014 = new System.Windows.Forms.RadioButton();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.cb6 = new System.Windows.Forms.CheckBox();
            this.cb7 = new System.Windows.Forms.CheckBox();
            this.cb8 = new System.Windows.Forms.CheckBox();
            this.cb9 = new System.Windows.Forms.CheckBox();
            this.cb10 = new System.Windows.Forms.CheckBox();
            this.cb11 = new System.Windows.Forms.CheckBox();
            this.cb12 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbLK = new System.Windows.Forms.RadioButton();
            this.rbPR = new System.Windows.Forms.RadioButton();
            this.EpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.EpError2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EpError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpError2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNim
            // 
            this.tbNim.Location = new System.Drawing.Point(121, 77);
            this.tbNim.Name = "tbNim";
            this.tbNim.Size = new System.Drawing.Size(100, 20);
            this.tbNim.TabIndex = 0;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(121, 111);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(100, 20);
            this.tbNama.TabIndex = 1;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(121, 171);
            this.tbAlamat.Multiline = true;
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(138, 46);
            this.tbAlamat.TabIndex = 2;
            // 
            // tbTA
            // 
            this.tbTA.Location = new System.Drawing.Point(581, 111);
            this.tbTA.Name = "tbTA";
            this.tbTA.Size = new System.Drawing.Size(100, 20);
            this.tbTA.TabIndex = 3;
            this.tbTA.TextChanged += new System.EventHandler(this.tbTA_TextChanged);
            // 
            // tbSemester
            // 
            this.tbSemester.Location = new System.Drawing.Point(581, 144);
            this.tbSemester.Name = "tbSemester";
            this.tbSemester.Size = new System.Drawing.Size(100, 20);
            this.tbSemester.TabIndex = 4;
            this.tbSemester.TextChanged += new System.EventHandler(this.tbSemester_TextChanged);
            // 
            // cbPS
            // 
            this.cbPS.FormattingEnabled = true;
            this.cbPS.Items.AddRange(new object[] {
            "Teknik Informatika",
            "Akutansi",
            ""});
            this.cbPS.Location = new System.Drawing.Point(581, 80);
            this.cbPS.Name = "cbPS";
            this.cbPS.Size = new System.Drawing.Size(121, 21);
            this.cbPS.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Pilih Mata Kuliah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Simpan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(418, 483);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Batal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Kr2014);
            this.groupBox1.Controls.Add(this.Kr2010);
            this.groupBox1.Controls.Add(this.Kr2006);
            this.groupBox1.Location = new System.Drawing.Point(20, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 132);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb12);
            this.groupBox2.Controls.Add(this.cb11);
            this.groupBox2.Controls.Add(this.cb10);
            this.groupBox2.Controls.Add(this.cb9);
            this.groupBox2.Controls.Add(this.cb8);
            this.groupBox2.Controls.Add(this.cb7);
            this.groupBox2.Controls.Add(this.cb6);
            this.groupBox2.Controls.Add(this.cb5);
            this.groupBox2.Controls.Add(this.cb4);
            this.groupBox2.Controls.Add(this.cb3);
            this.groupBox2.Controls.Add(this.cb2);
            this.groupBox2.Controls.Add(this.cb1);
            this.groupBox2.Location = new System.Drawing.Point(288, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 148);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Kr2006
            // 
            this.Kr2006.AutoSize = true;
            this.Kr2006.Location = new System.Drawing.Point(24, 32);
            this.Kr2006.Name = "Kr2006";
            this.Kr2006.Size = new System.Drawing.Size(98, 17);
            this.Kr2006.TabIndex = 0;
            this.Kr2006.TabStop = true;
            this.Kr2006.Text = "Kurikulum 2006";
            this.Kr2006.UseVisualStyleBackColor = true;
            this.Kr2006.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Kr2010
            // 
            this.Kr2010.AutoSize = true;
            this.Kr2010.Location = new System.Drawing.Point(24, 67);
            this.Kr2010.Name = "Kr2010";
            this.Kr2010.Size = new System.Drawing.Size(98, 17);
            this.Kr2010.TabIndex = 1;
            this.Kr2010.TabStop = true;
            this.Kr2010.Text = "Kurikulum 2010";
            this.Kr2010.UseVisualStyleBackColor = true;
            this.Kr2010.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Kr2014
            // 
            this.Kr2014.AutoSize = true;
            this.Kr2014.Location = new System.Drawing.Point(24, 100);
            this.Kr2014.Name = "Kr2014";
            this.Kr2014.Size = new System.Drawing.Size(98, 17);
            this.Kr2014.TabIndex = 2;
            this.Kr2014.TabStop = true;
            this.Kr2014.Text = "Kurikulum 2014";
            this.Kr2014.UseVisualStyleBackColor = true;
            this.Kr2014.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Enabled = false;
            this.cb1.Location = new System.Drawing.Point(7, 19);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(81, 17);
            this.cb1.TabIndex = 0;
            this.cb1.Text = "Matematika";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Enabled = false;
            this.cb2.Location = new System.Drawing.Point(7, 50);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(97, 17);
            this.cb2.TabIndex = 1;
            this.cb2.Text = "Pemograman 1";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Enabled = false;
            this.cb3.Location = new System.Drawing.Point(6, 82);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(97, 17);
            this.cb3.TabIndex = 2;
            this.cb3.Text = "Pemograman 2";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Enabled = false;
            this.cb4.Location = new System.Drawing.Point(6, 115);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(97, 17);
            this.cb4.TabIndex = 3;
            this.cb4.Text = "Pemograman 3";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.Enabled = false;
            this.cb5.Location = new System.Drawing.Point(115, 19);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(97, 17);
            this.cb5.TabIndex = 4;
            this.cb5.Text = "Pemograman 4";
            this.cb5.UseVisualStyleBackColor = true;
            // 
            // cb6
            // 
            this.cb6.AutoSize = true;
            this.cb6.Enabled = false;
            this.cb6.Location = new System.Drawing.Point(113, 50);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(97, 17);
            this.cb6.TabIndex = 5;
            this.cb6.Text = "Pemograman 5";
            this.cb6.UseVisualStyleBackColor = true;
            // 
            // cb7
            // 
            this.cb7.AutoSize = true;
            this.cb7.Enabled = false;
            this.cb7.Location = new System.Drawing.Point(113, 82);
            this.cb7.Name = "cb7";
            this.cb7.Size = new System.Drawing.Size(97, 17);
            this.cb7.TabIndex = 6;
            this.cb7.Text = "Pemograman 6";
            this.cb7.UseVisualStyleBackColor = true;
            // 
            // cb8
            // 
            this.cb8.AutoSize = true;
            this.cb8.Enabled = false;
            this.cb8.Location = new System.Drawing.Point(113, 115);
            this.cb8.Name = "cb8";
            this.cb8.Size = new System.Drawing.Size(97, 17);
            this.cb8.TabIndex = 7;
            this.cb8.Text = "Pemograman 7";
            this.cb8.UseVisualStyleBackColor = true;
            // 
            // cb9
            // 
            this.cb9.AutoSize = true;
            this.cb9.Enabled = false;
            this.cb9.Location = new System.Drawing.Point(240, 19);
            this.cb9.Name = "cb9";
            this.cb9.Size = new System.Drawing.Size(120, 17);
            this.cb9.TabIndex = 8;
            this.cb9.Text = "Penghantar Logistik";
            this.cb9.UseVisualStyleBackColor = true;
            // 
            // cb10
            // 
            this.cb10.AutoSize = true;
            this.cb10.Enabled = false;
            this.cb10.Location = new System.Drawing.Point(240, 50);
            this.cb10.Name = "cb10";
            this.cb10.Size = new System.Drawing.Size(114, 17);
            this.cb10.TabIndex = 9;
            this.cb10.Text = "Jaringan Komputer";
            this.cb10.UseVisualStyleBackColor = true;
            // 
            // cb11
            // 
            this.cb11.AutoSize = true;
            this.cb11.Enabled = false;
            this.cb11.Location = new System.Drawing.Point(240, 82);
            this.cb11.Name = "cb11";
            this.cb11.Size = new System.Drawing.Size(96, 17);
            this.cb11.TabIndex = 10;
            this.cb11.Text = "Sistem Operasi";
            this.cb11.UseVisualStyleBackColor = true;
            // 
            // cb12
            // 
            this.cb12.AutoSize = true;
            this.cb12.Enabled = false;
            this.cb12.Location = new System.Drawing.Point(240, 115);
            this.cb12.Name = "cb12";
            this.cb12.Size = new System.Drawing.Size(148, 17);
            this.cb12.TabIndex = 11;
            this.cb12.Text = "Manajemen Rantai Pasok";
            this.cb12.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "PILIHAN MATA KULIAH MAHASISWA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "NIM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Jenis Kelamin";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Alamat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Program Studi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tahun Akademik";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Semester";
            // 
            // rbLK
            // 
            this.rbLK.AutoSize = true;
            this.rbLK.Location = new System.Drawing.Point(121, 148);
            this.rbLK.Name = "rbLK";
            this.rbLK.Size = new System.Drawing.Size(74, 17);
            this.rbLK.TabIndex = 20;
            this.rbLK.TabStop = true;
            this.rbLK.Text = "Laki - Laki";
            this.rbLK.UseVisualStyleBackColor = true;
            // 
            // rbPR
            // 
            this.rbPR.AutoSize = true;
            this.rbPR.Location = new System.Drawing.Point(201, 148);
            this.rbPR.Name = "rbPR";
            this.rbPR.Size = new System.Drawing.Size(79, 17);
            this.rbPR.TabIndex = 21;
            this.rbPR.TabStop = true;
            this.rbPR.Text = "Perempuan";
            this.rbPR.UseVisualStyleBackColor = true;
            // 
            // EpError
            // 
            this.EpError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.EpError.ContainerControl = this;
            // 
            // EpError2
            // 
            this.EpError2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 531);
            this.Controls.Add(this.rbPR);
            this.Controls.Add(this.rbLK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbPS);
            this.Controls.Add(this.tbSemester);
            this.Controls.Add(this.tbTA);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbNim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EpError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpError2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNim;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.TextBox tbTA;
        private System.Windows.Forms.TextBox tbSemester;
        private System.Windows.Forms.ComboBox cbPS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Kr2014;
        private System.Windows.Forms.RadioButton Kr2010;
        private System.Windows.Forms.RadioButton Kr2006;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb12;
        private System.Windows.Forms.CheckBox cb11;
        private System.Windows.Forms.CheckBox cb10;
        private System.Windows.Forms.CheckBox cb9;
        private System.Windows.Forms.CheckBox cb8;
        private System.Windows.Forms.CheckBox cb7;
        private System.Windows.Forms.CheckBox cb6;
        private System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbLK;
        private System.Windows.Forms.RadioButton rbPR;
        private System.Windows.Forms.ErrorProvider EpError;
        private System.Windows.Forms.ErrorProvider EpError2;
    }
}

