using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Hadron Security Exe To Base64 Converter
//Discord=https://discord.gg/N6AsPfqSDk





namespace Exe_To_Base64_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable Files (*.exe)|*.exe";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string exeFilePath = openFileDialog.FileName;
                guna2TextBox1.Text = exeFilePath; // Seçilen dosyanın yolunu TextBox'a yaz

                byte[] exeData = File.ReadAllBytes(exeFilePath);
                string base64Data = Convert.ToBase64String(exeData);

                // Base64 kodunu geçici bir değişkende sakla
                savedBase64 = base64Data;

                MessageBox.Show("Exe file converted to Base64 format.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string savedBase64 = string.Empty;
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(savedBase64))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, savedBase64, Encoding.UTF8);
                    MessageBox.Show("Base64 data " + saveFileDialog.FileName + " saved in file named.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("First you must select an exe file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/N6AsPfqSDk");
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/@CyberClub758");
        }
    }
}
