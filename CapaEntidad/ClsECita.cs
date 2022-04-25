using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ClsECita
    {
      
        private DateTime fecha, hora;
        private string codCita, idPaciente, idDoctor, diagnostico, nombreAcompanante;
        private int valor;
        private Boolean activo;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public string CodCita { get => codCita; set => codCita = value; }
        public string IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string IdDoctor { get => idDoctor; set => idDoctor = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string NombreAcompanante { get => nombreAcompanante; set => nombreAcompanante = value; }
        public int Valor { get => valor; set => valor = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}
