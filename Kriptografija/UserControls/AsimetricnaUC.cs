using Kriptografija.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kriptografija.UserControls
{
    public partial class AsimetricnaUC : UserControl
    {
        public AsimetricnaUC()
        {
            InitializeComponent();
        }

        private void buttonGetHash_Click(object sender, EventArgs e)
        {
            textBoxHash.Text = Hash.GetHash(richTextBoxPlainText.Text);
        }

        private void buttonGenerateKeyPair_Click(object sender, EventArgs e)
        {
            AsymmetricCryptography.CreateKeyPair();
        }

        private void buttonEncyrpt_Click(object sender, EventArgs e)
        {
            richTextBoxPlainText.Text = AsymmetricCryptography.RSAEncrypt(richTextBoxPlainText.Text);
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            richTextBoxPlainText.Text = AsymmetricCryptography.RSADecrypt(richTextBoxPlainText.Text);
        }

        private void buttonReadFromFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBoxPlainText.Text = FileManager.ReadFromFile(openFileDialog1.FileName);
            }
        }

        private void richTextBoxPlainText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AsimetricnaUC_Load(object sender, EventArgs e)
        {

        }
    }
}
