using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrçamentoDev.Views
{
    public partial class FrmLogim : Form
    {
        public FrmLogim()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == "admin" && txtSenha.Text == "1234")
            {
                FrmMenu menu = new FrmMenu();

                menu.ShowDialog();

                this.Hide();

            }
            else
            {

                MessageBox.Show("Usuário ou senha inválidos", "Error", MessageBoxButtons.OK,

                    MessageBoxIcon.Error);
            }
        }
    }
}
