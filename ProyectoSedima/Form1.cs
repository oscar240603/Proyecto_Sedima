using ProyectoSedima.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSedima
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "CONTRASEÑA")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.Black;
                txtContra.UseSystemPasswordChar = true;
            }

        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "CONTRASEÑA";
                txtContra.ForeColor = Color.Gray;
                txtContra.UseSystemPasswordChar = false;
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "admin" &&  txtContra.Text == "admin")
            {
                FrmReportes FrmReporte = new FrmReportes();
                this.Hide();
                FrmReporte.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtContra.Focus();
             
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btnLogin.Focus();
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            FrmReportes FrmReporte = new FrmReportes();
            this.Hide();
            FrmReporte.Show();

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                FrmReporte.Focus();
        }
    }
}
