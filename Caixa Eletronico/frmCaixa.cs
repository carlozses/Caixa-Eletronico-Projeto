using Caixa_Eletronico.Classes;
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
    public partial class frmCaixa : Form
    {
        Singleton s;
        public frmCaixa()
        {
            InitializeComponent();
            s = Singleton.Instance;
        }

        private void btAcessar_Click(object sender, EventArgs e)
        {
            Conta c = s.BuscarConta(txtBox.Text);
            if (c != null)
            {
                s.conta_logada = c;
                frmPrincipal frm = new frmPrincipal();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Conta nao existe!");
            }
        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
