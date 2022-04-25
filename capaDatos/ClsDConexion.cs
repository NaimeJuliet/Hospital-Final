using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace capaDatos
{
    public class ClsDConexion
    {
        public SqlConnection conectar(string Cnx)
        //Establecer conexion con BD y abrirla
        {
            try
            {
                SqlConnection oconectar = new SqlConnection(ConfigurationSettings.AppSettings[Cnx].ToString());
                oconectar.Open();
                return oconectar;
            }
            catch (Exception err) {
                throw new Exception(err.Message);//Este error es solo si no se conecta a la BD
            }
           
        }
    }
}
