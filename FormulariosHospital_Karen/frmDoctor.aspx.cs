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
    public partial class frmDoctor : System.Web.UI.Page
    {

        ClsRN_Doctor oReglaMedico = new ClsRN_Doctor();
        ClsEDoctor oEntidadMedico = new ClsEDoctor();




        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGuardarMedico_Click(object sender, EventArgs e)
        {
            oEntidadMedico.IdDoctor = TextBoxIdMedicoMedico.Text;
            oEntidadMedico.NombreDoctor = TextBoxNombreMedico.Text;
            oEntidadMedico.Especialidad = TextBoxEspecialidadMedico.Text;
            oEntidadMedico.TelefonoMedico = TextBoxTelefonoMedico.Text;

            if (oReglaMedico.Guardar_Medico(oEntidadMedico))
            {
                LabelMensajeMedico.Text = "  Medico  Registro  Exitosamente";
            }
            else
            {
                LabelMensajeMedico.Text = "ERROR.......... al guardar el Medico";
            }
        }

        protected void ButtonLimpiarMedico_Click(object sender, EventArgs e)
        {

            TextBoxIdMedicoMedico.Text = "";
            Limpiar();
            TextBoxIdMedicoMedico.Focus();

        }

        protected void Limpiar()
        {
            TextBoxIdMedicoMedico.Text = "";
            TextBoxNombreMedico.Text = "";
            TextBoxEspecialidadMedico.Text = "";
            TextBoxTelefonoMedico.Text = "";
            LabelMensajeMedico.Text = "";



        }

        protected void ButtonConsultarMedico_Click(object sender, EventArgs e)
        {
            if (TextBoxIdMedicoMedico.Text == " ")
            {
                LabelMensajeMedico.Text = " No se ha digitado el ID de medico ";
                TextBoxIdMedicoMedico.Focus();
            }
            else
            {
                DataSet ds = new DataSet();

                oEntidadMedico.IdDoctor = TextBoxIdMedicoMedico.Text;
                ds = oReglaMedico.consultar_medico(oEntidadMedico);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    LabelMensajeMedico.Text = "Medico Disponible";
                    TextBoxNombreMedico.Focus();
                    Limpiar();
                    //Activar();
                }
                else
                {
                    TextBoxNombreMedico.Text = ds.Tables[0].Rows[0]["nom_medico"].ToString();
                    TextBoxEspecialidadMedico.Text = ds.Tables[0].Rows[0]["especialidad"].ToString();
                    TextBoxTelefonoMedico.Text = ds.Tables[0].Rows[0]["tel_medico"].ToString();

                }
            }

        }

        protected void ButtonLimpiarMedico_Click1(object sender, EventArgs e)
        {
            TextBoxIdMedicoMedico.Text = "";
            Limpiar();
            TextBoxIdMedicoMedico.Focus();
        }

        
    }
}
