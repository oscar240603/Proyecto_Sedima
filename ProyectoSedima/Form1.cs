using ProyectoSedima.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSedima
{
    public partial class LOGIN : Form
    {
        static string conexionstring = "Data Source=LAPTOP-OSCAR202\\SQLEXPRESS;Initial Catalog=SEDIMA;Integrated Security=True";                           //"Data Source=LAPTOP-OSCAR202\\SQLEXPRESS;Initial Catalog=SEDIMA;Integrated Security=True";
        SqlConnection conexion = new SqlConnection(conexionstring);

        public LOGIN()
        {
            InitializeComponent();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
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
            conexion.Open();
            string valida = "SELECT Usuario, Contraseña FROM EMPLEADO WHERE Usuario = '"+txtUser.Text+"' and Contraseña = '"+txtContra.Text+"'";
            SqlCommand comando = new SqlCommand(valida,conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if(lector.HasRows == true)
            {
                FrmReportes FrmReporte = new FrmReportes();
                this.Hide();
                FrmReporte.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            conexion.Close();
 

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


        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
