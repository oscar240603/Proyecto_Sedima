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

namespace ProyectoSedima.PL
{
    public partial class FrmBorrar_Modificar : Form
    {
        static string conexionstring = "Data Source=LAPTOP-OSCAR202\\SQLEXPRESS;Initial Catalog=SEDIMA;Integrated Security=True";
        SqlConnection conexion = new SqlConnection(conexionstring);
        public FrmBorrar_Modificar()
        {
            InitializeComponent();
        }

        private void FrmBorrar_Modificar_Load(object sender, EventArgs e)
        {
            string consulta = "Select * from REPORTES";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvReportes.DataSource = dt;
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cancelar = "UPDATE REPORTES SET STATUS = 'Cancelado' WHERE IdReporte ='" + txtBorrar.Text + "'";
            SqlCommand comando = new SqlCommand(cancelar, conexion);
            comando.ExecuteNonQuery();

            MessageBox.Show("Se cancelo correctamente");
        }

        public void dgvReportes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmEditar frmedit = new FrmEditar();
            this.Hide();
            frmedit.Show();




        }
    }
}
