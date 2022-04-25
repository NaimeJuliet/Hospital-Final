using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ClsEDoctor
    {
        private string idDoctor, nombreDoctor, especialidad, telefonoMedico;
        private Boolean activo;

        public string IdDoctor { get => idDoctor; set => idDoctor = value; }
        public string NombreDoctor { get => nombreDoctor; set => nombreDoctor = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string TelefonoMedico { get => telefonoMedico; set => telefonoMedico = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}
