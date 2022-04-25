using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using capaReglasNegocio;
using System.Data;
using System.Data.SqlClient;


namespace FormulariosHospital_Karen
{
    public partial class frmCita : System.Web.UI.Page
    {
        ClsECita oEntCitas = new ClsECita();
        ClsRN_Cita oRegNCitas = new ClsRN_Cita();

        ClsEPaciente oEntPaciente = new ClsEPaciente();
        ClsRN_Paciente oRegNPaciente = new ClsRN_Paciente();

        ClsEDoctor oEntDoctor = new ClsEDoctor();
        ClsRN_Doctor oRegNDoctor = new ClsRN_Doctor();


        protected void LimpiarTextos() {
            txtAcompanante.Text = "";
            txtActivo.Text = "";
            txtDiagnostico.Text = "";
            txtFecha.Text = "";
            txtHora.Text = "";
            txtId_Medico.Text = "";
            txtId_Paciente.Text = "";
            txtValor.Text = "";
        }

        protected void activar() {
            txtAcompanante.Enabled = true;
            txtActivo.Enabled = true;
            txtDiagnostico.Enabled = true;
            txtFecha.Enabled = true;
            txtHora.Enabled = true;
            txtId_Medico.Enabled = true;
            txtId_Paciente.Enabled = true;
            txtValor.Enabled = true;
            btnAgendar.Enabled = true;
        }

        protected void Desactivar()
        {
            txtAcompanante.Enabled = false;
            txtActivo.Enabled = false;
            txtDiagnostico.Enabled = false;
            txtFecha.Enabled = false;
            txtHora.Enabled = false;
            txtId_Medico.Enabled = false;
            txtId_Paciente.Enabled = false;
            txtValor.Enabled = false;
            btnAgendar.Enabled = false;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgendar_Click(object sender, EventArgs e)
        {
            oEntCitas.CodCita = txtCita.Text;
            oEntCitas.Fecha = Convert.ToDateTime(txtFecha.Text);
            oEntCitas.Hora = Convert.ToDateTime(txtHora.Text);
            oEntCitas.IdPaciente = txtId_Paciente.Text;
            oEntCitas.IdDoctor = txtId_Medico.Text;
            oEntCitas.Valor = Convert.ToInt32(txtValor.Text);
            oEntCitas.Diagnostico = txtDiagnostico.Text;
            oEntCitas.NombreAcompanante = txtAcompanante.Text;

            if (oRegNCitas.guardar_cita(oEntCitas))
            {
                mensajeCita.Text = "Registro Guardado Exitosamente";
            }
            else
            {
                mensajeCita.Text = "ERROR ... al guardar el registro";
            }

        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            activar();
            LimpiarTextos();
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtCita.Text == "")
            {
                mensajeCita.Text = "No se ha digitado codigo";
                txtCita.Focus();
            }
            else
            {
                DataSet ds = new DataSet();
                oEntCitas.CodCita = txtCita.Text;
                ds = oRegNCitas.consultar_cita(oEntCitas);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    LimpiarTextos();
                    mensajeCita.Text = "Cita disponible";
                    txtFecha.Focus();
                }
                else
                {
                    Desactivar();
                    txtFecha.Text = ds.Tables[0].Rows[0]["fecha"].ToString();
                    txtHora.Text = ds.Tables[0].Rows[0]["hora"].ToString();
                    txtId_Paciente.Text = ds.Tables[0].Rows[0]["Id_paciente"].ToString();
                    txtId_Medico.Text = ds.Tables[0].Rows[0]["id_medico"].ToString();
                    txtValor.Text = ds.Tables[0].Rows[0]["valor"].ToString();
                    txtDiagnostico.Text = ds.Tables[0].Rows[0]["diagnostico"].ToString();
                    txtAcompanante.Text = ds.Tables[0].Rows[0]["nom_acompanante"].ToString();
                    txtActivo.Text = ds.Tables[0].Rows[0]["activo"].ToString();
                }
            }
        }


        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCita.Text = "";
            LimpiarTextos();
            activar();
        }

        protected void btnConsultarPaciente_Click(object sender, EventArgs e)
        {
            if (txtId_Paciente.Text == "")
            {
                txtId_Paciente.Text = "REQUERIDO: id del paciente";
                txtId_Paciente.Focus();
            }
            else {
                DataSet ds = new DataSet();
               
                oEntPaciente.IdPaciente = txtId_Paciente.Text;
                ds = oRegNPaciente.consultar_paciente(oEntPaciente);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    txtId_Paciente.Text = "Paciente no existe";
                    txtId_Paciente.Focus();
                }
                else
                {
                    txtId_Paciente.Text = ds.Tables[0].Rows[0]["nom_paciente"].ToString();
                }

            }


        }

        protected void btnConsultarDoctor_Click(object sender, EventArgs e)
        {
            if (txtId_Medico.Text == "")
            {
                txtId_Medico.Text = "REQUERIDO: id del doctor";
                txtId_Medico.Focus();
            }
            else
            {
                DataSet ds = new DataSet();
                oEntDoctor.IdDoctor = txtId_Medico.Text;
                ds = oRegNDoctor.consultar_medico(oEntDoctor);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    txtId_Medico.Text = "Medico no existe";
                    txtId_Medico.Focus();
                }
                else
                {
                    txtId_Medico.Text = ds.Tables[0].Rows[0]["nom_medico"].ToString();
                }


            }
        }
    }
}