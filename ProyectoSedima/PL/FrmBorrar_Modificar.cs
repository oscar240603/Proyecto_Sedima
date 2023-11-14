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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoSedima.PL
{
    public partial class FrmBorrar_Modificar : Form
    {
        static string conexionstring = "Data Source=LAPTOP-OSCAR202\\SQLEXPRESS;Initial Catalog=SEDIMA_NEW;Integrated Security=True";
        SqlConnection conexion = new SqlConnection(conexionstring);
        public FrmBorrar_Modificar()
        {
            InitializeComponent();
            carga_datos();
            carga_status();
        }

        private void FrmBorrar_Modificar_Load(object sender, EventArgs e)
        {
            Refresh();
            this.MaximizeBox = false;
            /*string consulta = "Select * from REPORTES";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvReportes.DataSource = dt;*/

        }

        private void Refresh()
        {
            using (Model.SEDIMA_NEWEntities1 db = new Model.SEDIMA_NEWEntities1())
            {
                var lst = (from d in db.REPORTE
                           select new Model.ViewModel.Reporte
                           {
                               IdReporte = d.IdReporte,
                               Cliente = d.Cliente,
                               Caldera = d.Caldera,
                               Modelo = d.Modelo,
                               Serie = d.Serie,
                               Ciudad = d.Ciudad,
                               FecRegistro = d.FecRegistro, 
                               STATUS = d.STATUS
                           }).AsQueryable();




                if (dtpFec.Text != null && dtpFinal.Text != null)
                {
                    DateTime fechaDesde = DateTime.Parse(dtpFec.Text);
                    DateTime fechaHasta = DateTime.Parse(dtpFinal.Text);

                    lst = lst.Where(r => DbFunctions.TruncateTime(r.FecRegistro) >= fechaDesde.Date
                                    && DbFunctions.TruncateTime(r.FecRegistro) <= fechaHasta.Date);

                }
                if (cbCliente.SelectedIndex > 0)
                {
                    lst = lst.Where(d => d.Cliente.Contains(cbCliente.Text.Trim()));
                }
                // Filtrar por Status si se seleccionó algo en el ComboBox
                if (cbStatus.SelectedIndex > 0)
                {
                    lst = lst.Where(d => d.Caldera.Contains(cbStatus.Text.Trim()));
                }
                


                dgvReportes.DataSource = lst.ToList();
                dgvReportes.Columns["IdReporte"].DisplayIndex = 0;
                dgvReportes.Columns["Cliente"].DisplayIndex = 1;
                dgvReportes.Columns["Caldera"].DisplayIndex = 2;
                dgvReportes.Columns["Modelo"].DisplayIndex = 3;
                dgvReportes.Columns["Serie"].DisplayIndex = 4;
                dgvReportes.Columns["Ciudad"].DisplayIndex = 5;
                dgvReportes.Columns["FecRegistro"].DisplayIndex = 6;
                dgvReportes.Columns["STATUS"].DisplayIndex = 7;
                dgvReportes.Columns["Detalle"].DisplayIndex= 8;
                dgvReportes.Columns["Detalle"].Width = 50;
                


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
        
        public void carga_datos()
        {
            
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT CLIENTE FROM REPORTE", conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["CLIENTE"] = "Selecciona un cliente";
            dt.Rows.InsertAt(fila,0);

            cbCliente.ValueMember= "IdReporte";
            cbCliente.DisplayMember= "CLIENTE";
            cbCliente.DataSource= dt;

        }


        public void carga_status()
        {
            conexion.Open();
            SqlCommand status = new SqlCommand("SELECT DISTINCT CALDERA FROM REPORTE", conexion);
            SqlDataAdapter da = new SqlDataAdapter(status);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["CALDERA"] = "Selecciona un modelo de caldera";
            dt.Rows.InsertAt(fila, 0);

            cbStatus.ValueMember = "IdReporte";
            cbStatus.DisplayMember = "CALDERA";
            cbStatus.DataSource = dt;

        }

        private void btnFiltro_MouseEnter(object sender, EventArgs e)
        {
            btnFiltro.BackColor = Color.LightBlue;
        }

        private void btnFiltro_MouseLeave(object sender, EventArgs e)
        {
            btnFiltro.BackColor = Color.White;
        }
    }
}
