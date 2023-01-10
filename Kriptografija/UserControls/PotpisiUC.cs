using Kriptografija.Classes;
using System;
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
    public partial class PotpisiUC : UserControl
    {
        public PotpisiUC()
        {
            InitializeComponent();
            richTextBoxInput.Text = FileManager.ReadDefaultText();
        }

        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBoxInput.Text = FileManager.ReadFromFile(openFileDialog1.FileName);
            }
        }

        private void buttonAddSignature_Click(object sender, EventArgs e)
        {
            DigitalSignature.InputDataToSignAndHash(richTextBoxInput.Text);
            DigitalSignature.CreateSignature();
            richTextBoxSignedHash.Text = DigitalSignature.ReturnSignedHashString();
        }

        private void buttonCheckSignature_Click(object sender, EventArgs e)
        {
            richTextBoxCheckSignature.Text =  DigitalSignature.VerifySignature();
        }

        private void richTextBoxSignedHash_TextChanged(object sender, EventArgs e)
        {
            FileManager.WriteSignedHash(richTextBoxSignedHash.Text);
        }

        private void richTextBoxInput_TextChanged(object sender, EventArgs e)
        {
            FileManager.WriteDefaultText(richTextBoxInput.Text);
            DigitalSignature.InputDataToSignAndHash(richTextBoxInput.Text);
        }
    }
}
