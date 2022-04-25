
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
    public class ClsRN_Paciente
    {

        ClsDPaciente oDatpacientes = new ClsDPaciente();

        public DataSet consultar_paciente(ClsEPaciente opacientes)
        {
            return oDatpacientes.consultar_paciente(opacientes);
        }

        public bool Guardar_Pacientes(ClsEPaciente ocitas)
        {
            return oDatpacientes.Guardar_Paciente(ocitas);
        }
    }

    
}
