using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cita
    {
        public int IdCita { get; set; }
        public string NombreDoctor { get; set; }
        public string NombreCliente { get; set; }

        public Cita()
        {
        }

        public Cita(int idCita)
        {
            IdCita = idCita;
        }

        public Cita(int idCita, string nombreDoctor, string nombreCliente)
        {
            IdCita = idCita;
            NombreDoctor = nombreDoctor;
            NombreCliente = nombreCliente;
        }

        public override string ToString()
        {
            return "Numero Cita:"+IdCita+", Nombre Doctor: "+NombreDoctor+", Nompre Paciente: "+ NombreCliente;
        }
    }
}
