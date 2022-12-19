using Kriptografija.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kriptografija.UserControls
{
    public partial class SimetricnaUC : UserControl
    {
        public SimetricnaUC()
        {
            InitializeComponent();
        }

        private void buttonEncyrpt_Click(object sender, EventArgs e)
        {
            byte[] encryptedText = SymmetricCryptography.EncryptStringToBytes_Aes(richTextBoxPlainText.Text);
            richTextBoxPlainText.Text = Convert.ToBase64String(encryptedText);
            buttonGenerateKey.Enabled = false;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxPlainText.Text = SymmetricCryptography.DecryptStringFromBytes_Aes(Convert.FromBase64String(richTextBoxPlainText.Text));
            }
            catch (Exception)
            {
                buttonGenerateKey.Enabled = true;
                MessageBox.Show("Tekst je do kraja dekriptiran");
              
            }
           

        }

        private void buttonGenerateKey_Click(object sender, EventArgs e)
        {
            SymmetricCryptography.CreateKeyAndIvAES();
        }

        private void buttonReadFromFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBoxPlainText.Text = FileManager.ReadFromFile(openFileDialog1.FileName);
            }
        }

        private void buttonGetHash_Click(object sender, EventArgs e)
        {
            textBoxHash.Text = Hash.GetHash(richTextBoxPlainText.Text);
        }
    }
}
