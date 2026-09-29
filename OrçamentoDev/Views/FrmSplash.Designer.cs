namespace OrçamentoDev.Views
{
    partial class FrmSplash
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
            LblTituloSplash = new Label();
            prgCarregando = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            lblCarregando = new Label();
            SuspendLayout();
            // 
            // LblTituloSplash
            // 
            LblTituloSplash.AutoSize = true;
            LblTituloSplash.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTituloSplash.Location = new Point(369, 37);
            LblTituloSplash.Name = "LblTituloSplash";
            LblTituloSplash.Size = new Size(260, 32);
            LblTituloSplash.TabIndex = 0;
            LblTituloSplash.Text = "SistemaDeOrcamento";
            LblTituloSplash.Click += LblTituloSplash_Click;
            // 
            // prgCarregando
            // 
            prgCarregando.Location = new Point(-3, 209);
            prgCarregando.Name = "prgCarregando";
            prgCarregando.Size = new Size(997, 41);
            prgCarregando.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblCarregando
            // 
            lblCarregando.AutoSize = true;
            lblCarregando.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCarregando.Location = new Point(382, 94);
            lblCarregando.Name = "lblCarregando";
            lblCarregando.Size = new Size(227, 30);
            lblCarregando.TabIndex = 2;
            lblCarregando.Text = "Carregando Modulos...";
            // 
            // FrmSplash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1006, 250);
            Controls.Add(lblCarregando);
            Controls.Add(prgCarregando);
            Controls.Add(LblTituloSplash);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSplash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTituloSplash;
        private ProgressBar prgCarregando;
        private System.Windows.Forms.Timer timer1;
        private Label lblCarregando;
    }
}