namespace Caixa_Eletronico
{
    partial class frmCaixa
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            btAcessar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 76);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Conta:";
            // 
            // btAcessar
            // 
            btAcessar.Location = new Point(133, 121);
            btAcessar.Name = "btAcessar";
            btAcessar.Size = new Size(123, 28);
            btAcessar.TabIndex = 1;
            btAcessar.Text = "Acessar";
            btAcessar.UseVisualStyleBackColor = true;
            btAcessar.Click += btAcessar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtBox
            // 
            txtBox.Location = new Point(108, 73);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(183, 23);
            txtBox.TabIndex = 3;
            txtBox.TextChanged += textBox1_TextChanged;
            // 
            // frmCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 195);
            Controls.Add(txtBox);
            Controls.Add(btAcessar);
            Controls.Add(label1);
            Name = "frmCaixa";
            Text = "frmCaixa";
            Load += frmCaixa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btAcessar;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtBox;
    }
}