using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ProyectoSedima.DAL;

namespace ProyectoSedima.PL
{
    public partial class FrmReportes : Form
    {
        static string conexionstring = "Data Source=LAPTOP-OSCAR202\\SQLEXPRESS;Initial Catalog=SEDIMA;Integrated Security=True";
        SqlConnection conexion = new SqlConnection(conexionstring);

        private void btnConectar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show("Se conecto a la BD");
        }

        public FrmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
          

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string cadena = "INSERT INTO [dbo].[REPORTES]([Cliente],[Caldera],[Modelo],[Serie],[Ciudad],[FecRegistro],[FA],[FG],[PC],[ABN],[ANN],[VN],[FCN],[PF],[PDC],[MC],[VV],[VG],[BG],[PI],[EFP],[FF],[BNA],[CPV],[LQ],[CE],[Chimenea],[Agua_tanque],[EC],[SC],[VAP],[AA],[AC],[BAA],[BAD],[MV],[Min_Co2],[Min_O2],[Min_Ppm],[Min_Ex_Aire],[Med_Co2],[Med_O2],[Med_Ppm],[Med_Ex_Aire],[Max_Co2],[Max_O2],[Max_Ppm],[Max_Ex_Aire],[Comentarios])" +
                "VALUES('" + txtCliente.Text + "','" + txtCaldera.Text + "','" + txtModelo.Text + "','" + txtSerie.Text + "','" + txtCiudad.Text + "','" + txtFecha.Text + "','" + txtFA.Text + "','" + txtFG.Text + "','" + txtPC.Text + "','" + txtABN.Text + "','','" + txtANN.Text + "','" + txtVN.Text + "','" + txtFCN.Text + "','" + txtPF.Text + "','" + txtPDC.Text + "','" + txtMC.Text + "','" + txtVV.Text + "','" + txtVG.Text + "','" + txtBG.Text + "','" + txtPI.Text + "','" + txtEFP.Text + "','" + txtFF.Text + "','" + txtBNA.Text + "','" + txtCPV.Text + "','" + txtLQ.Text + "','" + txtCE.Text + "','" + txtChimenea.Text + "','" + txtAguaTanque.Text + "','" + txtEC.Text + "','" + txtSC.Text + "','" + txtVAP.Text + "','" + txtAA.Text + "','" + txtBAA.Text + "','" + txtBAD.Text + "','" + txtMV.Text + "'," + txtMinCo2.Text + ",'" + txtMinO2.Text + "','" + txtMinPpm.Text + "','" + txtMinEx.Text + "','" + txtMedCo2.Text + "','" + txtMedO2.Text + "','" + txtMedPpm.Text + "','" + txtMedEx.Text + "','" + txtMaxCo2.Text + "','" + txtMaxO2.Text + "','" + txtMaxPpm.Text + "','" + txtMaxEx.Text + "','" + txtComentarios + "')";

            SqlCommand comando = new SqlCommand(cadena,conexion);
            comando.ExecuteNonQuery();

            MessageBox.Show("Se agrego correctamente");

        }
    }
}
