﻿using System;
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
    public partial class frmExtrato : Form
    {
        Singleton s;
        public frmExtrato()
        {
            InitializeComponent();
            s = Singleton.Instance;
        }
        private void Recarregar()
        {
            var source = new BindingSource(); 
            source.DataSource = s.conta_logada.Transacoes;
            dgvExtrato.DataSource = source;
        }
        private void frmExtrato_Load(object sender, EventArgs e)
        {
            Recarregar();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
            this.Close();
        }
    }
}
