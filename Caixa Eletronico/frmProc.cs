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
    public partial class frmProc : Form
    {
        bool pode_N;
        bool pode_T;
        Singleton s;
        private string tipo;
        public frmProc()
        {
            s = Singleton.Instance;
        }
        public frmProc(string tipo) : this()
        {
            InitializeComponent();
            this.tipo = tipo;
        }

        private void frmProc_Load(object sender, EventArgs e)
        {
            lblOp.Text = tipo;
            if (tipo == "Transferência")
            {
                txtConta.Visible = true;
                lblNome.Visible = true;
            }
        }

        private void btFazer_Click(object sender, EventArgs e)
        {
            if(tipo != "Extrato")
            {
                if (tipo == "Saque")
                {
                    double valor = (double)numValor.Value;
                    if (s.conta_logada.Sacar(valor))
                    {
                        MessageBox.Show("Saque realizado!");
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente...");
                    }

                }
                if (tipo == "Depósito")
                {
                    double valor = (double)numValor.Value;
                    s.conta_logada.Depositar(valor);
                    MessageBox.Show("Depósito realizado!");
                }
                if (tipo == "Transferência")
                {
                    double valor = (double)numValor.Value;
                    Conta destino = s.BuscarConta(txtConta.Text);
                    if (destino != null)
                    {
                        if (s.conta_logada.Transferir(destino, valor))
                        {
                            MessageBox.Show("Transferência realizada!");
                        }
                        else
                        {
                            MessageBox.Show("Saldo insuficiente...!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Conta destino não existe!");
                    }
                }
                frmPrincipal frm = new frmPrincipal();
                frm.Show();
                this.Hide();
            }
            else
            {
                frmExtrato frm = new frmExtrato();
                frm.Show();
                this.Close();
            }
        }

        private void numValor_ValueChanged(object sender, EventArgs e)
        {
            if(tipo != "Transferência")
            {
                if (numValor.Value != 0)
                {
                    btFazer.Enabled = true;
                }
                else
                {
                    btFazer.Enabled = false;
                }
            }
            else
            {
                if (numValor.Value != 0)
                {
                    pode_N = true;
                    CheckEnableBtFazer();
                }
                else
                {
                    pode_N = false;
                    CheckEnableBtFazer();
                }
            }
        }

        private void txtConta_TextChanged(object sender, EventArgs e)
        {
            if(txtConta.Text != "") {
                pode_T = true;
                CheckEnableBtFazer();
            }
            else
            {
                btFazer.Enabled=false;
            }
        }
        private void CheckEnableBtFazer()
        {
            if (tipo == "Transferência")
            {
                btFazer.Enabled = pode_N && pode_T;
            }
        }
    }
}
