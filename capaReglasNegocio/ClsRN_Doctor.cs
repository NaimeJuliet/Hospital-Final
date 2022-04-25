using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using capaDatos;
using CapaEntidad; 

using System.Data;
using System.Data.SqlClient;


namespace capaReglasNegocio
{

        public class ClsRN_Doctor
        {

        ClsDoctor oDatdoctores = new ClsDoctor();

        public DataSet consultar_medico(ClsEDoctor odoctores)
        {
            return oDatdoctores.consultar_medico(odoctores);
        }

        public bool Guardar_Medico(ClsEDoctor ocitas)
        {
            return oDatdoctores.Guardar_Medico(ocitas);
        }


    }
}
