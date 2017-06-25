using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condi
{
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void bntSalvar_MouseLeave(object sender, EventArgs e)
        {
            btnSalvar.BackgroundImage = Properties.Resources.save_30;
        }

        private void bntSalvar_MouseMove(object sender, MouseEventArgs e)
        {
            btnSalvar.BackgroundImage = Properties.Resources.save_50;
        }

        private void btnCancelar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCancelar.BackgroundImage = Properties.Resources.delete_50;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackgroundImage = Properties.Resources.delete_30;
        }
    }
}
