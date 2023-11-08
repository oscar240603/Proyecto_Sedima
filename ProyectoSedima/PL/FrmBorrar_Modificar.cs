using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
                if (dtpFec.Text != null && dtpFinal.Text != null)
                {
                    DateTime fechaDesde = DateTime.Parse(dtpFec.Text);
                    DateTime fechaHasta = DateTime.Parse(dtpFinal.Text);

                    // Realizar la consulta utilizando LINQ
                    lst = lst.Where(r => DbFunctions.TruncateTime(r.FecRegistro) >= fechaDesde.Date
                                    && DbFunctions.TruncateTime(r.FecRegistro) <= fechaHasta.Date);
                        
                    /*DateTime fecha = DateTime.Parse(dtpFec.Text);
                    DateTime fecha2 = DateTime.Parse(dtpFinal.Text);
                    lst = lst.Where(d => d.FecRegistro == fecha);*/
                    
                }



                dgvReportes.DataSource = lst.ToList();
                dgvReportes.Columns["IdReporte"].DisplayIndex = 0;
                dgvReportes.Columns["Cliente"].DisplayIndex = 1;
                dgvReportes.Columns["Caldera"].DisplayIndex = 2;
                dgvReportes.Columns["Modelo"].DisplayIndex = 3;
                dgvReportes.Columns["Serie"].DisplayIndex = 4;
                dgvReportes.Columns["Ciudad"].DisplayIndex = 5;
                dgvReportes.Columns["FecRegistro"].DisplayIndex = 6;
                dgvReportes.Columns["FA"].DisplayIndex = 7;
                dgvReportes.Columns["FG"].DisplayIndex = 8;
                dgvReportes.Columns["PC"].DisplayIndex = 9;
                dgvReportes.Columns["STATUS"].DisplayIndex = 10;
                dgvReportes.Columns["Detalle"].DisplayIndex= 11;
                

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

        int ID;
        private void dgvReportes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReportes.Columns[e.ColumnIndex].Name == "Detalle")
            {
                ID = Convert.ToInt32(dgvReportes.CurrentRow.Cells["IdReporte"].Value.ToString());
                FrmEditar frmEditar = new FrmEditar(ID);
                frmEditar.ShowDialog();
                Refresh();
            }
        }
    }
}
