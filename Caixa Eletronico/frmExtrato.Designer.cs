namespace Caixa_Eletronico
{
    partial class frmExtrato
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
            dgvExtrato = new DataGridView();
            btVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvExtrato).BeginInit();
            SuspendLayout();
            // 
            // dgvExtrato
            // 
            dgvExtrato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExtrato.Location = new Point(30, 26);
            dgvExtrato.Name = "dgvExtrato";
            dgvExtrato.Size = new Size(537, 252);
            dgvExtrato.TabIndex = 0;

            // 
            // btVoltar
            // 
            btVoltar.Location = new Point(598, 26);
            btVoltar.Name = "btVoltar";
            btVoltar.Size = new Size(75, 23);
            btVoltar.TabIndex = 1;
            btVoltar.Text = "Voltar";
            btVoltar.UseVisualStyleBackColor = true;
            btVoltar.Click += btVoltar_Click;
            // 
            // frmExtrato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 298);
            Controls.Add(btVoltar);
            Controls.Add(dgvExtrato);
            Name = "frmExtrato";
            Text = "frmExtrato";
            Load += frmExtrato_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExtrato).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvExtrato;
        private Button btVoltar;
    }
}