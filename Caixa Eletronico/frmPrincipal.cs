using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_Eletronico
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            FrmInicial frm = new FrmInicial();
            frm.Show();
            this.Close();
        }

        private void btExtrato_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Singleton s = Singleton.Instance;
            lblSaldo.Text = s.conta_logada.Saldo.ToString();
        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }
    }
}
