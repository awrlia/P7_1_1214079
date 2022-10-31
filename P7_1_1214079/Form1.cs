using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_1214079
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(816, 296);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbNim.Text != "")
            {
                if(tbNama.Text != "")
                {
                    if(rbLK.Checked || rbPR.Checked)
                    {
                        if(tbAlamat.Text != "")
                        {
                            if(cbPS.Text != "")
                            {
                                if (tbTA.Text != "" && Regex.IsMatch(tbTA.Text, @"^\d{4}/\d{4}$"))
                                {
                                   if (tbSemester.Text != "" && (tbSemester.Text).All(Char.IsNumber))
                                    {
                                        MessageBox.Show
                                         ("Lengkap !!!",
                                        "Informasi Data Submit",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Size = new Size(754, 570);
                                    }
                                    else
                                    {
                                        MessageBox.Show
                                     ("Semester Belum Diisi !!!",
                                     "Informasi Data Submit",
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show
                                     ("Tahun Akademik Belum Diisi !!!",
                                     "Informasi Data Submit",
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show
                                ("Program Studi Belum Diisi !!!",
                                "Informasi Data Submit",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show
                            ("Alamat Belum Diisi !!!",
                            "Informasi Data Submit",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show
                       ("Jenis Kelamin Belum Diisi !!!",
                       "Informasi Data Submit",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show
                       ("Nama Belum Diisi !!!",
                       "Informasi Data Submit",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show
                       ("NIM Belum Diisi !!!",
                       "Informasi Data Submit",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbTA_TextChanged(object sender, EventArgs e)
        {
            if(Regex.IsMatch(tbTA.Text, @"^\d{4}/\d{4}$"))
            {
                EpError.SetError(tbTA, "");
            }
            else
            {
                EpError.SetError(tbTA, "Format Tahun Akademik Salah!");
            }
        }

        private void tbSemester_TextChanged(object sender, EventArgs e)
        {
            if ((tbSemester.Text).All(Char.IsNumber))
            {
                EpError2.SetError(tbSemester, "");
            }
            else
            {
                EpError2.SetError(tbSemester, "Inputan Semester Hanya Boleh Angka! ");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Kr2006.Checked)
            {
                cb1.Enabled = true; cb1.Checked = false;
                cb2.Enabled = true; cb2.Checked = false;
                cb3.Enabled = true; cb2.Checked = false;
                cb4.Enabled = true; cb3.Checked = false;
                cb5.Enabled = true; cb3.Checked = false;
                cb6.Enabled = true; cb3.Checked = false;
                cb7.Enabled = true; cb3.Checked = false;
                cb8.Enabled = true; cb3.Checked = false;
                cb9.Enabled = false; cb3.Checked = false;
                cb10.Enabled = true; cb3.Checked = false;
                cb11.Enabled = true; cb3.Checked = false;
                cb12.Enabled = false; cb3.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (Kr2010.Checked)
            {
                cb1.Enabled = false; cb1.Checked = false;
                cb2.Enabled = true; cb2.Checked = false;
                cb3.Enabled = true; cb2.Checked = false;
                cb4.Enabled = true; cb3.Checked = false;
                cb5.Enabled = true; cb3.Checked = false;
                cb6.Enabled = true; cb3.Checked = false;
                cb7.Enabled = true; cb3.Checked = false;
                cb8.Enabled = true; cb3.Checked = false;
                cb9.Enabled = false; cb3.Checked = false;
                cb10.Enabled = true; cb3.Checked = false;
                cb11.Enabled = true; cb3.Checked = false;
                cb12.Enabled = true; cb3.Checked = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (Kr2014.Checked)
            {
                cb1.Enabled = false; cb1.Checked = false;
                cb2.Enabled = true; cb2.Checked = false;
                cb3.Enabled = true; cb2.Checked = false;
                cb4.Enabled = true; cb3.Checked = false;
                cb5.Enabled = true; cb3.Checked = false;
                cb6.Enabled = true; cb3.Checked = false;
                cb7.Enabled = true; cb3.Checked = false;
                cb8.Enabled = true; cb3.Checked = false;
                cb9.Enabled = true; cb3.Checked = false;
                cb10.Enabled = true; cb3.Checked = false;
                cb11.Enabled = true; cb3.Checked = false;
                cb12.Enabled = false; cb3.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Kurikulum = "";
            string Matkul = null;
            string JenisKelamin = null;

            if (rbLK.Checked)
            {
                JenisKelamin = rbLK.Text;
            }
            else
            {
                JenisKelamin = rbPR.Text;
            }

            if (Kr2006.Checked)
            {
                Kurikulum += Kr2006.Text;
            }
            if (Kr2010.Checked)
            {
                Kurikulum += Kr2010.Text;
            }
            if (Kr2014.Checked)
            {
                Kurikulum += Kr2014.Text;
            }
                
            if (cb1.Checked)
            {
                Matkul += cb1.Text;
            }
            if (cb2.Checked)
            {
                Matkul += cb2.Text;
            }
            if (cb3.Checked)
            {
                Matkul += cb3.Text;
            }
            if (cb4.Checked)
            {
                Matkul += cb4.Text;
            }
            if (cb5.Checked)
            {
                Matkul += cb5.Text;
            }
            if (cb6.Checked)
            {
                Matkul += cb6.Text;
            }
            if (cb7.Checked)
            {
                Matkul += cb7.Text;
            }
            if (cb8.Checked)
            {
                Matkul += cb8.Text;
            }
            if (cb9.Checked)
            {
                Matkul += cb9.Text;
            }
            if (cb10.Checked)
            {
                Matkul += cb10.Text;
            }
            if (cb11.Checked)
            {
                Matkul += cb11.Text;
            }
            if (cb12.Checked)
            {
                Matkul += cb12.Text;
            }

            { MessageBox.Show
                   ("NIM : " + tbNim.Text +
                   "\nNama : " + tbNama.Text +
                   "\nJenis Kelamin : " + JenisKelamin +
                   "\nAlamat : " + tbAlamat.Text +
                   "\nProgram Studi : " + cbPS.Text +
                   "\nTahun Akademik : " + tbTA.Text +
                   "\nSemester : " + tbSemester.Text,
                   "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);                   
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
