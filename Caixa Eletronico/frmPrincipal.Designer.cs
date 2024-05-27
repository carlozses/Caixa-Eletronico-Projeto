namespace Caixa_Eletronico
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btVoltar = new Button();
            btSaque = new Button();
            btDeposita = new Button();
            btTrans = new Button();
            btExtrato = new Button();
            label1 = new Label();
            lblSaldo = new Label();
            SuspendLayout();
            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(12, 12);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(75, 23);
            btVoltar.TabIndex = 0;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // btSaque
            // 
            btSaque.Location = new Point(111, 92);
            btSaque.Name = "btSaque";
            btSaque.Size = new Size(207, 38);
            btSaque.TabIndex = 1;
            btSaque.Text = "Sacar";
            btSaque.UseVisualStyleBackColor = true;
            // 
            // btDeposita
            // 
            btDeposita.Location = new Point(111, 136);
            btDeposita.Name = "btDeposita";
            btDeposita.Size = new Size(207, 38);
            btDeposita.TabIndex = 2;
            btDeposita.Text = "Depositar";
            btDeposita.UseVisualStyleBackColor = true;
            // 
            // btTrans
            // 
            btTrans.Location = new Point(111, 180);
            btTrans.Name = "btTrans";
            btTrans.Size = new Size(207, 38);
            btTrans.TabIndex = 3;
            btTrans.Text = "Transferir";
            btTrans.UseVisualStyleBackColor = true;
            // 
            // btExtrato
            // 
            btExtrato.Location = new Point(111, 224);
            btExtrato.Name = "btExtrato";
            btExtrato.Size = new Size(207, 38);
            btExtrato.TabIndex = 5;
            btExtrato.Text = "Ver extrato";
            btExtrato.UseVisualStyleBackColor = true;
            btExtrato.Click += btExtrato_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 16);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 6;
            label1.Text = "Saldo: ";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(371, 16);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(0, 15);
            lblSaldo.TabIndex = 7;
            lblSaldo.Click += lblSaldo_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 303);
            Controls.Add(lblSaldo);
            Controls.Add(label1);
            Controls.Add(btExtrato);
            Controls.Add(btTrans);
            Controls.Add(btDeposita);
            Controls.Add(btSaque);
            Controls.Add(btVoltar);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVoltar;
        private Button btSaque;
        private Button btDeposita;
        private Button btTrans;
        private Button btExtrato;
        private Label label1;
        private Label lblSaldo;
    }
}