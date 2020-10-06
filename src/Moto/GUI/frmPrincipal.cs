using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moto.GUI;

namespace Moto
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pLACASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmPesquisaCliente())
            {
                frm.ShowDialog();
            }
        }
    }
}
