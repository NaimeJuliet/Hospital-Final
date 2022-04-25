using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CapaEntidad;
using capaDatos;

namespace capaReglasNegocio
{
    public class ClsRN_Cita
    {

        ClsDCita oDatcitas = new ClsDCita();

        public DataSet consultar_cita(ClsECita oCitas)
        {
            return oDatcitas.consultar_cita(oCitas);
        }

        public bool guardar_cita(ClsECita oCitas)
        {
            return oDatcitas.guardar_cita(oCitas);
        }



    }
}
