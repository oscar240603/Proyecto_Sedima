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
    public partial class FrmEditar : Form
    {
        static string conexionstring = "Server=localhost\\SQLEXPRESS;Database=SEDIMA;Trusted_Connection=True;";                                         //"Data Source=LAPTOP-OSCAR202\\SQLEXPRESS;Initial Catalog=SEDIMA;Integrated Security=True";
        SqlConnection conexion = new SqlConnection(conexionstring);
        public FrmEditar()
        {
            InitializeComponent();
        }

        private void FrmEditar_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string buscar = "Select * from REPORTES where IdReporte = '" + txtID.Text + "'";
            SqlCommand comando = new SqlCommand(buscar,conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                txtCliente.Text = lector["CLIENTE"].ToString();
                txtCaldera.Text = lector["CALDERA"].ToString();
                txtFecha.Text = lector["FecRegistro"].ToString();
                txtModelo.Text = lector["MODELO"].ToString();
                txtSerie.Text = lector["SERIE"].ToString();
                txtCiudad.Text = lector["CIUDAD"].ToString();
                txtFA.Text = lector["FA"].ToString();
                txtFG.Text = lector["FG"].ToString();
                txtPC.Text = lector["PC"].ToString();
                txtABN.Text = lector["ABN"].ToString();
                txtANN.Text = lector["ANN"].ToString();
                txtVN.Text = lector["VN"].ToString();
                txtFCN.Text = lector["FCN"].ToString();
                txtPF.Text = lector["PF"].ToString();
                txtPDC.Text = lector["PDC"].ToString();
                txtMC.Text = lector["MC"].ToString();
                txtVV.Text = lector["VV"].ToString();
                txtVG.Text = lector["VG"].ToString();
                txtBG.Text = lector["BG"].ToString();
                txtPI.Text = lector["PI"].ToString();
                txtEFP.Text = lector["EFP"].ToString();
                txtFF.Text = lector["FF"].ToString();
                txtBNA.Text = lector["BNA"].ToString();
                txtCPV.Text = lector["CPV"].ToString();
                txtLQ.Text = lector["LQ"].ToString();
                txtCE.Text = lector["CE"].ToString();
                txtChimenea.Text = lector["Chimenea"].ToString();
                txtAguaTanque.Text = lector["Agua_tanque"].ToString();
                txtEC.Text = lector["EC"].ToString();
                txtSC.Text = lector["SC"].ToString();
                txtVAP.Text = lector["VAP"].ToString();
                txtAA.Text = lector["AA"].ToString();
                txtAC.Text = lector["AC"].ToString();
                txtBAA.Text = lector["BAA"].ToString();
                txtBAD.Text = lector["BAD"].ToString();
                txtMV.Text = lector["MV"].ToString();
                txtMinCo2.Text = lector["Min_Co2"].ToString();
                txtMinO2.Text = lector["Min_O2"].ToString();
                txtMinPpm.Text = lector["Min_Ppm"].ToString();
                txtMinEx.Text = lector["Min_Ex_Aire"].ToString();
                txtMedCo2.Text = lector["Med_Co2"].ToString();
                txtMedO2.Text = lector["Med_O2"].ToString();
                txtMedPpm.Text = lector["Med_Ppm"].ToString();
                txtMedEx.Text = lector["Med_Ex_Aire"].ToString();
                txtMaxCo2.Text = lector["Max_Co2"].ToString();
                txtMaxO2.Text = lector["Max_O2"].ToString();
                txtMaxPpm.Text = lector["Max_Ppm"].ToString();
                txtMaxEx.Text = lector["Max_Ex_Aire"].ToString();
                txtComentarios.Text = lector["Comentarios"].ToString();


                conexion.Close();


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string modificar = "UPDATE[dbo].[REPORTES]SET[Cliente] = '"+txtCliente.Text+"', [Caldera] = '"+txtCaldera.Text+"', [Modelo] = '"+txtModelo.Text+"', [Serie] = '"+txtSerie.Text+"', [Ciudad] = '"+txtCiudad.Text+"', [FecRegistro] = '"+txtFecha.Text+"',[FA] = '"+txtFA.Text+"', [FG] = '"+txtFG.Text+"', [PC] = '"+txtPC.Text+"', [ABN] = '"+txtABN.Text+"', [ANN] = '"+txtANN.Text+"', [VN] = '"+txtVN.Text+"', [FCN] = '"+txtFCN.Text+"', [PF] = '"+txtPF.Text+"', [PDC] = '"+txtPDC.Text+"', [MC] = '"+txtMC.Text+"', [VV] = '"+txtVV.Text+"', [VG] = '"+txtVG.Text+"', [BG] = '"+txtBG.Text+"', [PI] = '"+txtPI.Text+"', [EFP] = '"+txtEFP.Text+"', [FF] = '"+txtFF.Text+"', [BNA] = '"+txtBNA.Text+"', [CPV] = '"+txtCPV.Text+"', [LQ] = '"+txtLQ.Text+"', [CE] = '"+txtCE.Text+"', [Chimenea] = '"+txtChimenea.Text+"', [Agua_tanque] = '"+txtAguaTanque.Text+"', [EC] = '"+txtEC.Text+"',  [SC] = '"+txtSC.Text+"', [VAP] = '"+txtVAP.Text+"', [AA] = '"+txtAA.Text+"', [AC] = '"+txtAC.Text+"', [BAA] = '"+txtBAA.Text+"', [BAD] = '"+txtBAD.Text+"', [MV] = '"+txtMV.Text+"', [Min_Co2] = '"+txtMinCo2.Text+"', [Min_O2] = '"+txtMinO2.Text+"', [Min_Ppm] = '"+txtMinPpm.Text+"', [Min_Ex_Aire] = '"+txtMinEx.Text+"',[Med_Co2] = '"+txtMedCo2.Text+"', [Med_O2] = '"+txtMedO2.Text+"', [Med_Ppm] = '"+txtMedPpm.Text+"', [Med_Ex_Aire] = '"+txtMedEx.Text+"', [Max_Co2] = '"+txtMaxCo2.Text+"', [Max_O2] = '"+txtMaxO2.Text+"', [Max_Ppm] = '"+txtMaxPpm.Text+"', [Max_Ex_Aire] = '"+txtMaxEx.Text+"', [Comentarios] = '"+txtComentarios.Text+"'  WHERE[IDReporte] = '"+txtID.Text+ "'";

            SqlCommand comando = new SqlCommand(modificar, conexion);
            comando.ExecuteNonQuery();

            MessageBox.Show("Se modificó correctamente");
        }
    }
}
