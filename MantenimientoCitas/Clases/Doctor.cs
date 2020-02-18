using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Doctor : Persona
    {
        private string Especialidad { get; set; }

        public Doctor(int iD, string nombre, string apellidos, int cedula, string especialidad): base(iD, nombre, apellidos, cedula)
        {
            Especialidad = especialidad;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + ", Apellido: " + Apellidos + ", Cedula: " + Cedula + ", Especialidad: " + Especialidad;
        }
    }
}
