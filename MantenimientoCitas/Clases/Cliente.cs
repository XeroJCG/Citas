using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente: Persona
    {
        private int Telefono { get; set; }
        private string Correo { get; set; }

        public Cliente(int iD, string nombre, string apellidos, int cedula, int telefono, string correo):base(iD, nombre, apellidos, cedula)
        {
            Telefono = telefono;
            Correo = correo;
        }

        public override string ToString()
        {
            
            return "Nombre: " + Nombre+", Apellido: "+Apellidos+", Cedula: "+Cedula+", Telefono: "+Telefono+", Correo: "+Correo;
        }
    }
}
