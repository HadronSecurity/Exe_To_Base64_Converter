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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable Files (*.exe)|*.exe";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string exeFilePath = openFileDialog.FileName;
                guna2TextBox1.Text = exeFilePath; // Write the path of the selected file to the TextBox

                byte[] exeData = File.ReadAllBytes(exeFilePath);
                string base64Data = Convert.ToBase64String(exeData);

                // Store base64 code in a temporary variable
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string txtFilePath = openFileDialog.FileName;
                guna2TextBox2.Text = txtFilePath; // Write file path to TextBox
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string txtFilePath = guna2TextBox2.Text;

            if (File.Exists(txtFilePath))
            {
                string base64Data = File.ReadAllText(txtFilePath, Encoding.UTF8);

                if (!string.IsNullOrEmpty(base64Data))
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Executable Files (*.exe)|*.exe";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        byte[] exeData = Convert.FromBase64String(base64Data);
                        File.WriteAllBytes(saveFileDialog.FileName, exeData);
                        MessageBox.Show("Base64 Data " + saveFileDialog.FileName + " was recorded under the name .", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("The text file is empty or does not contain a valid Base64 code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The specified file was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
