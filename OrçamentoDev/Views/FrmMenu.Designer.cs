namespace OrçamentoDev.Views
{
    partial class FrmMenu
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
            lblBoaVinda = new Label();
            btnNovoOrcamento = new Button();
            btnRelatorio = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblBoaVinda
            // 
            lblBoaVinda.AutoSize = true;
            lblBoaVinda.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBoaVinda.Location = new Point(226, 25);
            lblBoaVinda.Name = "lblBoaVinda";
            lblBoaVinda.Size = new Size(531, 40);
            lblBoaVinda.TabIndex = 0;
            lblBoaVinda.Text = "Bem vindos ao sistema de oramentos";
            lblBoaVinda.Click += lblBoaVinda_Click;
            // 
            // btnNovoOrcamento
            // 
            btnNovoOrcamento.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnNovoOrcamento.ForeColor = Color.Blue;
            btnNovoOrcamento.Location = new Point(143, 151);
            btnNovoOrcamento.Name = "btnNovoOrcamento";
            btnNovoOrcamento.Size = new Size(148, 33);
            btnNovoOrcamento.TabIndex = 1;
            btnNovoOrcamento.Text = "novo Orcamento";
            btnNovoOrcamento.UseVisualStyleBackColor = true;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnRelatorio.ForeColor = Color.Blue;
            btnRelatorio.Location = new Point(459, 151);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(75, 33);
            btnRelatorio.TabIndex = 2;
            btnRelatorio.Text = "Relatorio";
            btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnSair.ForeColor = Color.Blue;
            btnSair.Location = new Point(769, 151);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 33);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 246);
            Controls.Add(btnSair);
            Controls.Add(btnRelatorio);
            Controls.Add(btnNovoOrcamento);
            Controls.Add(lblBoaVinda);
            Name = "FrmMenu";
            Text = "Menu Principal Orcamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBoaVinda;
        private Button btnNovoOrcamento;
        private Button btnRelatorio;
        private Button btnSair;
    }
}