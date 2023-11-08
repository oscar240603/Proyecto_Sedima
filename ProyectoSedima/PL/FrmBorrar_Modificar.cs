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
            Refresh();
            /*string consulta = "Select * from REPORTES";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvReportes.DataSource = dt;*/
            
        }

        private void Refresh()
        {
            using (Model.SEDIMAEntities db = new Model.SEDIMAEntities())
            {
                var lst = (from d in db.REPORTES
                           select new Model.ViewModel.ReporteViewModel
                           {
                               IdReporte = d.IdReporte,
                               Cliente = d.Cliente,
                               Caldera = d.Caldera,
                               Modelo = d.Modelo,
                               Serie = d.Serie,
                               Ciudad = d.Ciudad,
                               FecRegistro = d.FecRegistro,
                               FA = d.FA,
                               FG = d.FG,
                               PC = d.PC,
                               STATUS = d.STATUS
                           }).AsQueryable();

                if (!txtCliente.Text.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.Cliente.Contains(txtCliente.Text.Trim()));
                }
                if (!txtStatus.Text.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.STATUS.Contains(txtStatus.Text.Trim()));
                }
                if (dtpFec.Text != null)
                {
                    DateTime fecha = DateTime.Parse(dtpFec.Text);
                    lst = lst.Where(d => d.FecRegistro == fecha);
                }



                dgvReportes.DataSource = lst.ToList();
            }
                
        }

        

        public void dgvReportes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmEditar frmedit = new FrmEditar();
            this.Hide();
            frmedit.Show();




        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
