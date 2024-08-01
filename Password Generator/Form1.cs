using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Password.Generator
{
    public partial class Form1 : Form
    {
        private string folderPath = "";

        public Form1()
        {
            InitializeComponent();
            trackBarlength.Minimum = 5;
            trackBarlength.Maximum = 25;

            lblError.Font = new Font(lblError.Font, FontStyle.Bold);
            lblError.Text = "";

            folderPath = Properties.Settings.Default.FolderPath;

            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);



        }

        const string LowerCharacters = "abcdefghijklmnopqrstuvwxyz";
        const string UpperCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string DigitsCharacters = "1234567890";
        const string SpecialCharacters = "~!@#$%^&*_-+=(){}[]:;<>,.?/";




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblnumlength.Text = trackBarlength.Value.ToString();
        }

        private void Btngen_Click(object sender, EventArgs e)
        {



            if (trackBarlength.Value == trackBarlength.Minimum)
            {
                lblError.Text = "You must select a valid length!";
                return;
            }

            try
            {
                textBoxpw.Text = PasswordGenerator(checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, int.Parse(trackBarlength.Value.ToString()));
            }
            catch (Exception)
            {
                lblError.Text = "You must select at least one Option!";
                return;

            }
        }

        private void Btncopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxpw.Text);
            }
            catch (Exception)
            {
                lblError.Text = ("You must have a Password!");

            }


        }
        public string PasswordGenerator(bool lowerCase, bool upperCase, bool numbers, bool specials, int length)
        {



            StringBuilder pwBuilder = new StringBuilder();
            System.Random random1 = new Random();

            if (lowerCase)
                pwBuilder.Append(LowerCharacters);
            if (upperCase)
                pwBuilder.Append(UpperCharacters);
            if (numbers)
                pwBuilder.Append(DigitsCharacters);
            if (specials)
                pwBuilder.Append(SpecialCharacters);

            string pwChars = pwBuilder.ToString();

            char[] password = new char[length];

            for (int i = 0; i < length; i++)
                password[i] = pwChars[random1.Next(pwChars.Length)];

            return new string(password);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }
        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLabel.Text))
            {
                lblError.Text = ("Enter a label before saving!");

                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxpw.Text))
            {
                lblError.Text = "No password to save!";

                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

                if (!string.IsNullOrWhiteSpace(folderPath))
                {
                    saveFileDialog.InitialDirectory = folderPath;
                }

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    string label = textBoxLabel.Text;
                    string password = textBoxpw.Text;

                    folderPath = Path.GetDirectoryName(filePath) ?? "";

                    Properties.Settings.Default.FolderPath = folderPath;
                    Properties.Settings.Default.Save();

                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("Label: " + label);
                        writer.WriteLine("Password: " + password);
                    }

                    lblError.Text = "Password and label saved!";
                }
            }
        }

        private void openLastUsedFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(folderPath) && Directory.Exists(folderPath))
            {
                Process.Start("explorer.exe", folderPath);
            }
            else
            {
                MessageBox.Show("Must save a password first!", "Error");
            }
        }
        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.FolderPath = folderPath;
            Properties.Settings.Default.Save();
        }
    }
}

