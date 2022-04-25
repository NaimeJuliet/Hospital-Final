using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace capaDatos
{
    public class ClsDPaciente
    {
        ClsDConexion oConexion = new ClsDConexion();
        SqlCommand OCmd = new SqlCommand();

        public DataSet consultar_paciente(ClsEPaciente opacientes)
        {
            try
            {
                OCmd.Connection = oConexion.conectar("BDHospital");
                OCmd.CommandType = CommandType.StoredProcedure;
                OCmd.CommandText = "sp_consultar_paciente";
                OCmd.Parameters.Add("@pId_paciente", opacientes.IdPaciente);
                SqlDataAdapter da = new SqlDataAdapter(OCmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }

            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public bool Guardar_Paciente(ClsEPaciente ocitas)
        {
            try
            {
                OCmd.Connection = oConexion.conectar("BDHospital");
                OCmd.CommandType = CommandType.StoredProcedure;
                OCmd.CommandText = "sp_guardar_paciente";
                OCmd.Parameters.Add("@pId_paciente", ocitas.IdPaciente);
                OCmd.Parameters.Add("@ptip_doc ", ocitas.TipoDocumento);
                OCmd.Parameters.Add("@pnom_paciente", ocitas.NombrePaciente);
                OCmd.Parameters.Add("@pdir_paciente", ocitas.DirecionPaciente);
                OCmd.Parameters.Add("@ptel_paciente", ocitas.TelefonoPaciente);
                OCmd.Parameters.Add("@pcel_paciente", ocitas.CwlularPaciente);
                OCmd.ExecuteNonQuery();


                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }


        }


    }
}
