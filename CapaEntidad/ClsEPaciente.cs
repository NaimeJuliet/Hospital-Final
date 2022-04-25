using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ClsEPaciente
    {
        private string idPaciente, tipoDocumento, nombrePaciente, direcionPaciente, telefonoPaciente, cwlularPaciente;
        private Boolean activo;

        public string IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }
        public string NombrePaciente { get => nombrePaciente; set => nombrePaciente = value; }
        public string DirecionPaciente { get => direcionPaciente; set => direcionPaciente = value; }
        public string TelefonoPaciente { get => telefonoPaciente; set => telefonoPaciente = value; }
        public string CwlularPaciente { get => cwlularPaciente; set => cwlularPaciente = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}
