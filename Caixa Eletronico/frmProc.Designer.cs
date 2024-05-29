namespace Caixa_Eletronico
{
    partial class frmProc
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
            label1 = new Label();
            numValor = new NumericUpDown();
            lblOp = new Label();
            btFazer = new Button();
            lblNome = new Label();
            txtConta = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 46);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor:";
            // 
            // numValor
            // 
            numValor.Location = new Point(112, 64);
            numValor.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numValor.Name = "numValor";
            numValor.Size = new Size(136, 23);
            numValor.TabIndex = 1;
            numValor.ValueChanged += numValor_ValueChanged;
            // 
            // lblOp
            // 
            lblOp.AutoSize = true;
            lblOp.Location = new Point(148, 9);
            lblOp.Name = "lblOp";
            lblOp.Size = new Size(0, 15);
            lblOp.TabIndex = 2;
            // 
            // btFazer
            // 
            btFazer.Enabled = false;
            btFazer.Location = new Point(112, 161);
            btFazer.Name = "btFazer";
            btFazer.Size = new Size(131, 44);
            btFazer.TabIndex = 3;
            btFazer.Text = "Realizar";
            btFazer.UseVisualStyleBackColor = true;
            btFazer.Click += btFazer_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(112, 100);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(145, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Número da conta destino:";
            lblNome.Visible = false;
            // 
            // txtConta
            // 
            txtConta.Location = new Point(112, 118);
            txtConta.Name = "txtConta";
            txtConta.Size = new Size(136, 23);
            txtConta.TabIndex = 6;
            txtConta.Visible = false;
            txtConta.TextChanged += txtConta_TextChanged;
            // 
            // frmProc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 217);
            Controls.Add(txtConta);
            Controls.Add(lblNome);
            Controls.Add(btFazer);
            Controls.Add(lblOp);
            Controls.Add(numValor);
            Controls.Add(label1);
            Name = "frmProc";
            Text = "frmProc";
            Load += frmProc_Load;
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numValor;
        private Label lblOp;
        private Button btFazer;
        private Label lblNome;
        private TextBox txtConta;
    }
}