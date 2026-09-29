namespace OrçamentoDev.Views
{
    partial class FrmLogim
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
            lblSenha = new Label();
            lblTitulo = new Label();
            lblUsuario = new Label();
            textUsuario = new TextBox();
            txtSenha = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(38, 200);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 0;
            lblSenha.Text = "Senha:";
            lblSenha.Click += label1_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.White;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Maroon;
            lblTitulo.Location = new Point(49, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(221, 32);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Acesso ao sistema";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(38, 106);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario:";
            lblUsuario.Click += label3_Click;
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(114, 103);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(100, 23);
            textUsuario.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(114, 192);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '-';
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 4;
            txtSenha.TextChanged += textBox2_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(59, 243);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FrmLogim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtSenha);
            Controls.Add(textUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(lblTitulo);
            Controls.Add(lblSenha);
            Name = "FrmLogim";
            Text = "Login - Sistena de Orcamento";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSenha;
        private Label lblTitulo;
        private Label lblUsuario;
        private TextBox textUsuario;
        private TextBox txtSenha;
        private Button btnLogin;
    }
}