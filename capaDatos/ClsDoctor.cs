using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace capaDatos
{
    public class ClsDoctor
    {
        ClsDConexion oConexion = new ClsDConexion();
        SqlCommand OCmd = new SqlCommand();
        public DataSet consultar_medico(ClsEDoctor odoctores)
        {
            try
            {
                OCmd.Connection = oConexion.conectar("BDHospital");
                OCmd.CommandType = CommandType.StoredProcedure;
                OCmd.CommandText = "sp_consultar_medico";
                OCmd.Parameters.Add("@pid_medico", odoctores.IdDoctor);
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

        public bool Guardar_Medico(ClsEDoctor ocitas)
        {
            try
            {
                OCmd.Connection = oConexion.conectar("BDHospital");
                OCmd.CommandType = CommandType.StoredProcedure;
                OCmd.CommandText = "sp_guardar_medico";
                OCmd.Parameters.Add("@pid_medico", ocitas.IdDoctor);
                OCmd.Parameters.Add("@pnom_medico", ocitas.NombreDoctor);
                OCmd.Parameters.Add("@pespecialidad", ocitas.Especialidad);
                OCmd.Parameters.Add("@ptel_medico", ocitas.TelefonoMedico);
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
