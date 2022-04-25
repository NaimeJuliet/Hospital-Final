using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaReglasNegocio;
using CapaEntidad;
using System.Data;

namespace FormulariosHospital_Karen
{
    public partial class frmPaciente : System.Web.UI.Page
    {

        ClsRN_Paciente oReglasPaciente = new ClsRN_Paciente();
        ClsEPaciente oEntidadPaciente = new ClsEPaciente();

        protected void Limpiar()
        {
            TextBoxPacientePaciente.Text = "";
            TextBoxDocumentoPaciente.Text = "";
            TextBoxNombrePaciente.Text = "";
            TextBoxDireccionPaciente.Text = "";
            TextBoxTelefonoPaciente.Text = "";
            TextBoxCelularPaciente.Text = "";
            LabelMensajePaciente.Text = "";
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGuardarPaciente_Click(object sender, EventArgs e)
        {
            oEntidadPaciente.IdPaciente = TextBoxPacientePaciente.Text;
            oEntidadPaciente.TipoDocumento = TextBoxDocumentoPaciente.Text;
            oEntidadPaciente.NombrePaciente = TextBoxNombrePaciente.Text;
            oEntidadPaciente.DirecionPaciente = TextBoxDireccionPaciente.Text;
            oEntidadPaciente.CwlularPaciente = TextBoxCelularPaciente.Text;
            oEntidadPaciente.TelefonoPaciente = TextBoxTelefonoPaciente.Text;


            if (oReglasPaciente.Guardar_Pacientes(oEntidadPaciente))
            {
                LabelMensajePaciente.Text = "  paciente  Registrado Exitosamente";
            }
            else
            {
                LabelMensajePaciente.Text = "ERROR.......... al guardar el paciente";
            }

        }
        
        protected void ButtonLimpiarPaciente_Click1(object sender, EventArgs e)
        {
            TextBoxPacientePaciente.Text = "";
            Limpiar();
            TextBoxPacientePaciente.Focus();
        }
    }
}