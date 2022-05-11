using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploMenu
{
    public partial class FrmVerde : Form
    {
        public FrmVerde()
        {
            InitializeComponent();
        }

        private void exibirFormAzul_Click(object sender, EventArgs e)
        {
            FrmAzul frm = new FrmAzul();
            this.Hide();
            frm.ShowDialog();
        }

        private void exibirFormLaranja_Click(object sender, EventArgs e)
        {
            FrmLaranja frm = new FrmLaranja();
            this.Hide();
            frm.ShowDialog();
        }

        private void exibirFormVerde_Click(object sender, EventArgs e)
        {
            FrmVerde frm = new FrmVerde();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
