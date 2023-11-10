using ProyectoSedima.Model;
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
        static string conexionstring = "Data Source=LAPTOP-OSCAR202\\SQLEXPRESS;Initial Catalog=SEDIMA;Integrated Security=True";                                         //"Data Source=LAPTOP-OSCAR202\\SQLEXPRESS;Initial Catalog=SEDIMA;Integrated Security=True";
        SqlConnection conexion = new SqlConnection(conexionstring);
        public FrmEditar()
        {
            InitializeComponent();
        }

        public FrmEditar(int pId)
        {
            InitializeComponent();
            Buscar(pId);
        }

        private void Buscar(int pId)
        {
            try
            {
                using(Model.SEDIMAEntities db = new Model.SEDIMAEntities())
                {
                    var lst = db.REPORTES.Where(p => p.IdReporte == pId).ToList();
                    if(lst.Count > 0)
                    {
                        foreach(REPORTES reporte in lst)
                        {
                            txtID.Text = reporte.IdReporte.ToString();
                            txtCliente.Text = reporte.Cliente;
                            txtCaldera.Text = reporte.Caldera;
                            txtCaldera.Text = reporte.Caldera;
                            txtFecha.Text = reporte.FecRegistro.ToString();
                            txtModelo.Text = reporte.Modelo;
                            txtSerie.Text = reporte.Serie;
                            txtCiudad.Text = reporte.Ciudad;
                            txtFA.Text = reporte.FA;
                            txtFG.Text = reporte.FG;
                            txtPC.Text = reporte.PC;
                            txtABN.Text = reporte.ABN;
                            txtANN.Text = reporte.ANN;
                            txtVN.Text = reporte.VN;
                            txtFCN.Text = reporte.FCN;
                            txtPF.Text = reporte.PF;
                            txtVG.Text = reporte.VG;
                            txtPDC.Text = reporte.PDC;
                            txtMC.Text = reporte.MC;
                            txtVG.Text = reporte.VG;
                            txtBG.Text = reporte.BG;
                            txtPI.Text = reporte.PI;
                            txtEFP.Text = reporte.EFP;
                            txtFF.Text = reporte.FF;
                            txtBNA.Text = reporte.BNA;
                            txtCPV.Text = reporte.CPV;
                            txtLQ.Text = reporte.LQ;
                            txtCE.Text = reporte.CE;
                            txtChimenea.Text = reporte.Chimenea;
                            txtAguaTanque.Text = reporte.Agua_tanque;
                            txtEC.Text = reporte.EC;
                            txtVAP.Text = reporte.VAP;
                            txtAA.Text = reporte.AA;
                            txtAC.Text = reporte.AC;
                            txtBAA.Text = reporte.BAA;
                            txtBAD.Text = reporte.BAD;
                            txtMV.Text = reporte.MV;
                            txtMinCo2.Text = reporte.Min_Co2;
                            txtMinO2.Text = reporte.Min_O2;
                            txtMinPpm.Text = reporte.Min_Ppm;
                            txtMinEx.Text = reporte.Min_Ex_Aire;
                            txtMedCo2.Text = reporte.Med_Co2;
                            txtMedO2.Text = reporte.Med_O2;
                            txtMedPpm.Text = reporte.Med_Ppm;
                            txtMedEx.Text = reporte.Med_Ex_Aire;
                            txtMaxCo2.Text = reporte.Max_Co2;
                            txtMaxO2.Text = reporte.Max_O2;
                            txtMaxPpm.Text = reporte.Max_Ppm;
                            txtMaxEx.Text = reporte.Max_Ex_Aire;
                            txtComentarios.Text = reporte.Comentarios;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            conexion.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string modificar = "UPDATE[dbo].[REPORTES]SET[Cliente] = '"+txtCliente.Text+"', [Caldera] = '"+txtCaldera.Text+"', [Modelo] = '"+txtModelo.Text+"', [Serie] = '"+txtSerie.Text+"', [Ciudad] = '"+txtCiudad.Text+"', [FecRegistro] = '"+txtFecha.Text+"',[FA] = '"+txtFA.Text+"', [FG] = '"+txtFG.Text+"', [PC] = '"+txtPC.Text+"', [ABN] = '"+txtABN.Text+"', [ANN] = '"+txtANN.Text+"', [VN] = '"+txtVN.Text+"', [FCN] = '"+txtFCN.Text+"', [PF] = '"+txtPF.Text+"', [PDC] = '"+txtPDC.Text+"', [MC] = '"+txtMC.Text+"', [VV] = '"+txtVV.Text+"', [VG] = '"+txtVG.Text+"', [BG] = '"+txtBG.Text+"', [PI] = '"+txtPI.Text+"', [EFP] = '"+txtEFP.Text+"', [FF] = '"+txtFF.Text+"', [BNA] = '"+txtBNA.Text+"', [CPV] = '"+txtCPV.Text+"', [LQ] = '"+txtLQ.Text+"', [CE] = '"+txtCE.Text+"', [Chimenea] = '"+txtChimenea.Text+"', [Agua_tanque] = '"+txtAguaTanque.Text+"', [EC] = '"+txtEC.Text+"',  [SC] = '"+txtSC.Text+"', [VAP] = '"+txtVAP.Text+"', [AA] = '"+txtAA.Text+"', [AC] = '"+txtAC.Text+"', [BAA] = '"+txtBAA.Text+"', [BAD] = '"+txtBAD.Text+"', [MV] = '"+txtMV.Text+"', [Min_Co2] = '"+txtMinCo2.Text+"', [Min_O2] = '"+txtMinO2.Text+"', [Min_Ppm] = '"+txtMinPpm.Text+"', [Min_Ex_Aire] = '"+txtMinEx.Text+"',[Med_Co2] = '"+txtMedCo2.Text+"', [Med_O2] = '"+txtMedO2.Text+"', [Med_Ppm] = '"+txtMedPpm.Text+"', [Med_Ex_Aire] = '"+txtMedEx.Text+"', [Max_Co2] = '"+txtMaxCo2.Text+"', [Max_O2] = '"+txtMaxO2.Text+"', [Max_Ppm] = '"+txtMaxPpm.Text+"', [Max_Ex_Aire] = '"+txtMaxEx.Text+"', [Comentarios] = '"+txtComentarios.Text+"'  WHERE[IDReporte] = '"+txtID.Text+ "'";

            SqlCommand comando = new SqlCommand(modificar, conexion);
            comando.ExecuteNonQuery();

            MessageBox.Show("Se modificó correctamente");
            conexion.Close();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtCliente.Focus();
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtCaldera.Focus();
        }

        private void txtCaldera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtFecha.Focus();
        }

        private void txtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtModelo.Focus();
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtCiudad.Focus();
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtSerie.Focus();
        }

        private void txtSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtFA.Focus();
        }

        private void txtFA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtFG.Focus();
        }

        private void txtFecha_Leave(object sender, EventArgs e)
        {
            if (txtFecha.Text == "")
            {
                txtFecha.Text = "YYYY/MM/DD";
            }
        }

        private void txtFecha_Enter(object sender, EventArgs e)
        {
            if (txtFecha.Text == "YYYY/MM/DD")
            {
                txtFecha.Text = "";
            }
        }

        private void txtFG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtPC.Focus();
        }

        private void txtPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtABN.Focus();
        }

        private void txtABN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtANN.Focus();
        }

        private void txtANN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtVN.Focus();
        }

        private void txtVN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtFCN.Focus();
        }

        private void txtFCN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtPF.Focus();
        }

        private void txtPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtPDC.Focus();
        }

        private void txtPDC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtMC.Focus();
        }

        private void txtMC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtVV.Focus();
        }

        private void txtVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtVG.Focus();
        }

        private void txtVG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtBG.Focus();
        }

        private void txtBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtPI.Focus();
        }

        private void txtPI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtEFP.Focus();
        }

        private void txtEFP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtFF.Focus();
        }

        private void txtFF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtBNA.Focus();
        }

        private void txtBNA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtCPV.Focus();
        }

        private void txtCPV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtLQ.Focus();
        }

        private void txtLQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtCE.Focus();
        }

        private void txtCE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtChimenea.Focus();
        }

        private void txtChimenea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtAguaTanque.Focus();
        }

        private void txtAguaTanque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtEC.Focus();
        }

        private void txtEC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtSC.Focus();
        }

        private void txtSC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtVAP.Focus();
        }

        private void txtVAP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtAA.Focus();
        }

        private void txtAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtAC.Focus();
        }

        private void txtAC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtBAA.Focus();
        }

        private void txtBAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtBAD.Focus();
        }

        private void txtBAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtMV.Focus();
        }

        private void txtMV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtMinCo2.Focus();
        }

        private void txtMinCo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtMedCo2.Focus();
        }

        private void txtMedCo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtMaxCo2.Focus();
        }

        private void txtMaxCo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtMinO2.Focus();
        }

        private void txtMinO2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtMedO2.Focus();
        }

        private void txtMedO2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtMaxO2.Focus();
        }

        private void txtMaxO2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtMinPpm.Focus();
        }

        private void txtMinPpm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtMedPpm.Focus();
        }

        private void txtMedPpm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtMaxPpm.Focus();
        }

        private void txtMaxPpm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtMinEx.Focus();
        }

        private void txtMinEx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtMedEx.Focus();
        }

        private void txtMedEx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtMaxEx.Focus();
        }

        private void txtMaxEx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtComentarios.Focus();
        }
    }
}
