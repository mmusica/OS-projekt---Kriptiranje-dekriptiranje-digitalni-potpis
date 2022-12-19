using Kriptografija.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kriptografija
{
    public partial class KriptoForm : Form
    {
        public KriptoForm()
        {
            InitializeComponent();
        }

        private void kriptoForm_Load(object sender, EventArgs e)
        {
            SimetricnaUC simetricnaUC = new SimetricnaUC();
            AddUserControl(simetricnaUC);
        }

        private void buttonPotpis_Click(object sender, EventArgs e)
        {
            PotpisiUC potpisiUC = new PotpisiUC();
            AddUserControl(potpisiUC);
        }

        private void buttonSimetricna_Click(object sender, EventArgs e)
        {
            SimetricnaUC simetricnaUC = new SimetricnaUC();
            AddUserControl(simetricnaUC);
        }

        private void buttonAsimetricna_Click(object sender, EventArgs e)
        {
            AsimetricnaUC asimetricnaUC = new AsimetricnaUC();
            AddUserControl(asimetricnaUC);
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }

    }
}
