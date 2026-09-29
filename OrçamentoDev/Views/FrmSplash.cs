using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrçamentoDev.Views
{
    public partial class FrmSplash : Form
    {

        private System.Windows.Forms.Timer timersplash;
        public FrmSplash()
        {
            InitializeComponent();

            prgCarregando.Minimum = 0;
            prgCarregando.Maximum = 100;
            prgCarregando.Value = 0;

            //cria e inicia o timer 

            timersplash = new System.Windows.Forms.Timer();
            timersplash.Tick += timer1_Tick;
            timersplash.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(prgCarregando.Value < 100)
            {
                prgCarregando.Value += 2;

            }
            else
            {
                timersplash.Stop();
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Hide();
            }
        }
    }
}
