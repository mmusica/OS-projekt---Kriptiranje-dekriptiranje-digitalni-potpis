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
    public partial class SimetricnaUC : UserControl
    {
        public SimetricnaUC()
        {
            InitializeComponent();
        }

        private void buttonEncyrpt_Click(object sender, EventArgs e)
        {
            FileManager.WriteText("Test");
        }
    }
}
